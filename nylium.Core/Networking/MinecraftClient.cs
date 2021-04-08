using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using DaanV2.UUID;
using fNbt.Tags;
using Jil;
using NetCoreServer;
using nylium.Core.Blocks;
using nylium.Core.Configuration;
using nylium.Core.Entity.Entities;
using nylium.Core.Level;
using nylium.Core.Networking.Packet;
using nylium.Core.Networking.Packet.Client.Handshake;
using nylium.Core.Networking.Packet.Client.Login;
using nylium.Core.Networking.Packet.Client.Play;
using nylium.Core.Networking.Packet.Client.Status;
using nylium.Core.Networking.Packet.Server.Login;
using nylium.Core.Networking.Packet.Server.Play;
using nylium.Core.Networking.Packet.Server.Status;
using nylium.Core.Tags;
using nylium.Extensions;
using nylium.Utilities;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.X509;
using Serilog;
using Http = System.Net.Http;

namespace nylium.Core.Networking {

    public class MinecraftClient : TcpSession {

        private static readonly dynamic TIMEOUT_MESSAGE = new { text = "Timed out" };
        public readonly Random random = new();

        private string username;
        private byte[] verifyToken = new byte[16];

        public State GameState { get; set; }
        private ProtocolState ProtocolState { get; set; }

        private KeepAlive KeepAlive { get; }
        public new MinecraftServer Server { get; }

        public ClientConfiguration Configuration { get; }

        public PlayerEntity Player { get; set; }
        public World World { get; set; }

        public List<Chunk> LoadedChunks { get; set; }

        public bool CompressionEnabled { get; set; }
        public bool EncryptionEnabled { get; set; }

        #region encryption
        public BufferedBlockCipher Decryptor { get; set; }
        public BufferedBlockCipher Encryptor { get; set; }
        #endregion

        public MinecraftClient(MinecraftServer server) : base(server) {
            GameState = State.Disconnected;
            ProtocolState = ProtocolState.Unknown;
            KeepAlive = new(Send, () => {
                SP19Disconnect disconnect = new(TIMEOUT_MESSAGE);
                Send(disconnect);
            }, 1000);
            Server = server;
            Configuration = new ClientConfiguration();
        }

        private bool HandleHandshakePacket(MinecraftPacket packet) {
            switch(packet) {
                case CH00Handshake: {
                        CH00Handshake handshake = (CH00Handshake) packet;
                        ProtocolState = handshake.NextState;
                        break;
                    }
                default:
                    return false;
            }

            return true;
        }

        private bool HandleStatusPacket(MinecraftPacket packet) {
            switch(packet) {
                case CS00Request: {
                        SS00Response response = new(MinecraftServer.STATUS_STRING);
                        Send(response);
                        break;
                    }
                case CS01Ping: {
                        CS01Ping ping = (CS01Ping) packet;

                        SS01Pong pong = new(ping.Payload);
                        Send(pong);
                        Disconnect();
                        break;
                    }
                default:
                    return false;
            }

            return true;
        }

        private bool HandleLoginPacket(MinecraftPacket packet) {
            switch(packet) {
                case CL00LoginStart: {
                        CL00LoginStart loginStart = (CL00LoginStart) packet;
                        username = loginStart.Username;

                        if(Server.Configuration.OnlineMode) {
                            RNGCryptoServiceProvider rng = new();
                            rng.GetBytes(verifyToken);

                            SL01EncryptionRequest encryptionRequest = new("",
                                (sbyte[]) (Array) SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(Server.KeyPair.Public).ToAsn1Object().GetDerEncoded(),
                                (sbyte[]) (Array) verifyToken);
                            Send(encryptionRequest);
                        } else {
                            UUID playerUuid = UUIDFactory.CreateUUID(3, 1, "OfflinePlayer:" + username);

                            if(Server.Configuration.CompressionThreshold > 0) {
                                SL03SetCompression setCompression = new(Server.Configuration.CompressionThreshold);
                                Send(setCompression);

                                CompressionEnabled = true;
                            }

                            SL02LoginSuccess loginSuccess = new(playerUuid, username);
                            Send(loginSuccess);

                            ProtocolState = ProtocolState.Play;
                            World = Server.World;
                            Player = new(World, this, username, playerUuid, Gamemode.Creative, 0, 1, 0, 0, 0, true);

                            SP24JoinGame joinGame = new(Player.EntityId, false, Player.Gamemode, Player.Gamemode,
                                new Identifier[] { new(World.Name) }, Server.DimensionCodec.RootTag, Server.OverworldDimension.RootTag,
                                new(World.Name), 0, 99, Server.Configuration.ViewDistance, false, true, false, true);
                            Send(joinGame);

                            LoadedChunks = new();
                            KeepAlive.Start();
                        }
                        break;
                    }
                case CL01EncryptionResponse: {
                        CL01EncryptionResponse encryptionResponse = (CL01EncryptionResponse) packet;

                        byte[] decryptedSharedSecret = Server.Decryptor.ProcessBlock((byte[]) (Array) encryptionResponse.SharedSecret,
                            0, encryptionResponse.SharedSecret.Length);
                        byte[] decryptedVerifyToken = Server.Decryptor.ProcessBlock((byte[]) (Array) encryptionResponse.VerifyToken,
                            0, encryptionResponse.VerifyToken.Length);

                        if(!decryptedVerifyToken.SequenceEqual(verifyToken)) {
                            SL00Disconnect disconnect = new(new {
                                text = "Invalid verify token."
                            });

                            Send(disconnect);
                            Disconnect();
                            break;
                        }

                        Decryptor = new(new CfbBlockCipher(new AesEngine(), 8));
                        Decryptor.Init(false, new ParametersWithIV(new KeyParameter(decryptedSharedSecret), decryptedSharedSecret));

                        Encryptor = new(new CfbBlockCipher(new AesEngine(), 8));
                        Encryptor.Init(true, new ParametersWithIV(new KeyParameter(decryptedSharedSecret), decryptedSharedSecret));

                        string hash = HashUtils.MinecraftShaDigest(Encoding.ASCII.GetBytes("")
                            .Concat(decryptedSharedSecret)
                            .Concat(SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(Server.KeyPair.Public).ToAsn1Object().GetDerEncoded())
                            .ToArray());

                        Http.HttpResponseMessage response = Server.Http.Send(new(Http.HttpMethod.Get,
                            $"https://sessionserver.mojang.com/session/minecraft/hasJoined?username={username}&serverId={hash}"));

                        if(!response.IsSuccessStatusCode) {
                            SL00Disconnect disconnect = new(new {
                                text = "Request to the Mojang session server was not successful."
                            });

                            Send(disconnect);
                            Disconnect();
                            break;
                        }

                        dynamic json = JSON.DeserializeDynamic(response.Content.ReadAsStringAsync().Result);

                        UUID playerUuid = new((string) json.id);
                        username = json.name;

                        EncryptionEnabled = true;

                        if(Server.Configuration.CompressionThreshold > 0) {
                            SL03SetCompression setCompression = new(Server.Configuration.CompressionThreshold);
                            Send(setCompression);

                            CompressionEnabled = true;
                        }

                        SL02LoginSuccess loginSuccess = new(playerUuid, username);
                        Send(loginSuccess);

                        ProtocolState = ProtocolState.Play;
                        World = Server.World;
                        Player = new(World, this, username, playerUuid, Gamemode.Creative, 0, 1, 0, 0, 0, true);

                        SP24JoinGame joinGame = new(Player.EntityId, false, Player.Gamemode, Player.Gamemode,
                            new Identifier[] { new(World.Name) }, Server.DimensionCodec.RootTag, Server.OverworldDimension.RootTag,
                            new(World.Name), 0, 99, Server.Configuration.ViewDistance, false, true, false, true);
                        Send(joinGame);

                        LoadedChunks = new();
                        KeepAlive.Start();
                        break;
                    }
                default:
                    return false;
            }

            return true;
        }

        private bool HandlePlayPacket(MinecraftPacket packet) {
            switch(packet) {
                case CP10KeepAlive: {
                        if(KeepAlive != null) {
                            KeepAlive.HasResponded = true;
                        } else {
                            SP19Disconnect disconnect = new(new {
                                text = "keepAlive == null"
                            });

                            Send(disconnect);
                            Disconnect();
                        }

                        break;
                    }
                case CP05ClientSettings: {
                        CP05ClientSettings clientSettings = (CP05ClientSettings) packet;
                        Configuration.ViewDistance = (clientSettings.ViewDistance > Server.Configuration.ViewDistance)
                            ? Server.Configuration.ViewDistance : clientSettings.ViewDistance;

                        SP13WindowItems windowItems = new(0, Player.Inventory.Slots);
                        Send(windowItems);

                        SP3FHeldItemChange heldItemChange = new((sbyte) (Player.Inventory.HeldSlot - 36)); // mojang moment
                        Send(heldItemChange);

                        SP5ADeclareRecipes declareRecipes = new(Array.Empty<Recipes.Recipe>()); // TODO generate recipes from recipes.json
                        Send(declareRecipes);

                        SP5BTags tags = new(Tag.blockTags.ToArray(),
                            Tag.itemTags.ToArray(),
                            Tag.fluidTags.ToArray(),
                            Tag.entityTags.ToArray());
                        Send(tags);

                        //SP1AEntityStatus entityStatus = new(Player.EntityId, SP1AEntityStatus.EntityStatus.SetOpLevel4);
                        //Send(entityStatus);

                        //SP35UnlockRecipes unlockRecipes = new(SP35UnlockRecipes.RecipeAction.Init,
                        //    false, false, false, false, false, false, false, false, new Utilities.Identifier[] { }, new Utilities.Identifier[] { });
                        //Send(unlockRecipes);

                        SP34PlayerPositionAndLook playerPositionAndLook = new(Player.X, Player.Y, Player.Z,
                            Player.Yaw, Player.Pitch, 0, random.Next(int.MaxValue));
                        Send(playerPositionAndLook);

                        SP40UpdateViewPosition updateViewPosition = new(Player.ChunkX, Player.ChunkZ);
                        Send(updateViewPosition);

                        Chunk[] chunks = World.GetChunksInViewDistance(Player.ChunkX, Player.ChunkZ,
                            (sbyte) (Configuration.ViewDistance - 1));
                        LoadChunks(chunks);

                        SP3DWorldBorder worldBorder = new(0, 0, 0, 4096, 0, 2048, 16, 2);
                        Send(worldBorder);

                        SP42SpawnPosition spawnPosition = new(new(0, 1, 0));
                        Send(spawnPosition);

                        for(int i = 0; i < World.PlayerEntities.Count; i++) {
                            PlayerEntity player = World.PlayerEntities[i];

                            SP32PlayerInfo _playerInfo = new(player.Uuid, player.Username, player.Gamemode, 0);
                            Send(_playerInfo);

                            _playerInfo = new(player.Uuid, 100); // TODO actual ping
                            Send(_playerInfo);

                            if(LoadedChunks.Contains(World.GetChunk(player.ChunkX, player.ChunkZ))) {
                                SP04SpawnPlayer _spawnPlayer = new(player.EntityId, player.Uuid, player.X, player.Y, player.Z,
                                    player.Yaw, player.Pitch);
                                Send(_spawnPlayer);
                            }
                        }

                        World.PlayerEntities.Add(Player);

                        SP32PlayerInfo playerInfo = new(Player.Uuid, Player.Username, Player.Gamemode, 0);
                        Server.Multicast(playerInfo);

                        playerInfo = new(Player.Uuid, 100); // TODO actual ping
                        Server.Multicast(playerInfo);

                        SP04SpawnPlayer spawnPlayer = new(Player.EntityId, Player.Uuid, Player.X, Player.Y, Player.Z,
                            Player.Yaw, Player.Pitch);
                        Server.MulticastAsync(spawnPlayer, this);

                        GameState = State.Playing;
                        break;
                    }
                case CP2CAnimation: {
                        CP2CAnimation animation = (CP2CAnimation) packet;

                        SP05EntityAnimation entityAnimation = new(Player.EntityId, animation.MainHand ?
                            SP05EntityAnimation.AnimationType.SwingMainArm : SP05EntityAnimation.AnimationType.SwingOffhand);
                        Server.MulticastAsync(entityAnimation, this);
                        break;
                    }
                case CP12PlayerPosition: {
                        Player.HandleMovement(packet);
                        break;
                    }
                case CP13PlayerPositionAndRotation: {
                        Player.HandleMovement(packet);
                        break;
                    }
                case CP14PlayerRotation: {
                        Player.HandleMovement(packet);
                        break;
                    }
                case CP15PlayerMovement: {
                        Player.HandleMovement(packet);
                        break;
                    }
                case CP1BPlayerDigging: {
                        Player.HandleWorldAction(packet);
                        break;
                    }
                case CP2EPlayerBlockPlacement: {
                        Player.HandleWorldAction(packet);
                        break;
                    }
                case CP1CEntityAction: {
                        Player.HandleWorldAction(packet);
                        break;
                    }
                case CP25HeldItemChange: {
                        Player.HandleInventoryAction(packet);
                        break;
                    }
                case CP28CreativeInventoryAction: {
                        Player.HandleInventoryAction(packet);
                        break;
                    }
                default:
                    return false;
            }

            return true;
        }

        public void LoadChunks(Chunk[] chunks) {
            MemoryStream convertStream = RMSManager.Get().GetStream("nylium.Core.Networking.MinecraftClient.LoadChunks()");

            // TODO somehow the entire chunk is underwater?
            for(int i = 0; i < chunks.Length; i++) {
                Chunk chunk = chunks[i];
                NbtCompound heightmap = chunk.CreateHeightmap();

                int[] biomes = Enumerable.Repeat(127, 1024).ToArray();
                int mask = 0;

                for(int j = 0; j < chunk.Sections.Length; j++) {
                    Chunk.Section section = chunk.Sections[j];

                    if(section == null) {
                        mask.ClearBit((byte) j);
                        continue;
                    }

                    if(!section.IsEmpty()) {
                        mask.SetBit((byte) j);

                        int nonAirBlockCount = 0;

                        section.Iterate(block => {
                            if(block != null) nonAirBlockCount++;
                        });

                        DataTypes.Short blockCount = new((short) nonAirBlockCount);
                        DataTypes.UByte bitsPerBlock = new((byte) Block.bitsPerBlock);

                        long[] compactedLong = section.ToCompactedLongArray(Block.bitsPerBlock);

                        DataTypes.VarInt dataArrayLength = new(compactedLong.Length);
                        DataTypes.Array<long, DataTypes.Long> dataArray = new(compactedLong);

                        blockCount.Write(convertStream);
                        bitsPerBlock.Write(convertStream);
                        dataArrayLength.Write(convertStream);
                        dataArray.Write(convertStream);
                    } else {
                        mask.ClearBit((byte) j);
                    }
                }

                SP20ChunkData chunkData = new(chunk.X, chunk.Z, true, mask, heightmap,
                    biomes, (sbyte[]) (Array) convertStream.ToArray(), Array.Empty<NbtCompound>());
                SendAsync(chunkData);

                LoadedChunks.Add(chunk);

                convertStream.Position = 0;
                convertStream.SetLength(0);
            }

            convertStream.Dispose();
        }

        public void UnloadChunks(Chunk[] chunks) {
            for(int i = 0; i < chunks.Length; i++) {
                Chunk chunk = chunks[i];

                SP1CUnloadChunk unloadChunk = new(chunk.X, chunk.Z);
                SendAsync(unloadChunk);

                LoadedChunks.Remove(chunk);
            }
        }

        protected override void OnReceived(byte[] buffer, long offset, long size) {
            if(ProtocolState == ProtocolState.Unknown) ProtocolState = ProtocolState.Handshaking;

            MemoryStream mem = RMSManager.Get().GetStream(buffer);
            mem.SetLength(size);

            MinecraftPacket packet = MinecraftPacket.CreateClientPacket(this, mem, ProtocolState);

            if(packet == null) {
                //if(EncryptionEnabled) {
                //    byte[] decrypted = Decryptor.ProcessBytes(buffer, 0, (int) size);

                //    mem.Position = 0;
                //    mem.SetLength(0);
                //    mem.Write(decrypted);
                //}

                //DataTypes.VarInt varInt = new();
                //varInt.Read(mem);
                //varInt.Read(mem);

                //int id = varInt.Value;

                Log.Debug($"Received unknown packet in state [{ProtocolState}]");
                return;
            }

            Log.Debug($"Received packet in state [{ProtocolState}] with id [0x{packet.Id:X}]");

            switch(ProtocolState) {
                case ProtocolState.Handshaking:
                    if(!HandleHandshakePacket(packet)) {
                        Log.Debug($"Warning: Packet in state [{ProtocolState}] with id [0x{packet.Id:X}] might not have been handled correctly");
                    }
                    break;

                case ProtocolState.Status:
                    if(!HandleStatusPacket(packet)) {
                        Log.Debug($"Warning: Packet in state [{ProtocolState}] with id [0x{packet.Id:X}] might not have been handled correctly");
                    }
                    break;

                case ProtocolState.Login:
                    if(!HandleLoginPacket(packet)) {
                        Log.Debug($"Warning: Packet in state [{ProtocolState}] with id [0x{packet.Id:X}] might not have been handled correctly");
                    }
                    break;

                case ProtocolState.Play:
                    if(!HandlePlayPacket(packet)) {
                        Log.Debug($"Warning: Packet in state [{ProtocolState}] with id [0x{packet.Id:X}] might not have been handled correctly");
                    }
                    break;
            }

            mem.Dispose();
            packet.Dispose();
        }

        protected override void OnConnected() {
            Log.Debug($"Client with id [{Id}] connected");
            GameState = State.Connecting;

            base.OnConnected();
        }

        protected override void OnDisconnected() {
            Log.Debug($"Client with id [{Id}] disconnected");

            if(ProtocolState == ProtocolState.Play && Player != null) {
                if(World.Format != null) World.Format.Save(Player);
                World.PlayerEntities.Remove(Player);

                SP32PlayerInfo playerInfo = new(Player.Uuid);
                Server.MulticastAsync(playerInfo, this);

                // TODO is there a packet to destroy only one entity?
                SP36DestroyEntities destroyEntities = new(new int[] { Player.EntityId });
                Server.MulticastAsync(destroyEntities, this);
            }

            ProtocolState = ProtocolState.Unknown;
            GameState = State.Disconnected;

            KeepAlive.Stop();

            base.OnDisconnected();
        }

        protected override void OnError(SocketError error) {
            Log.Debug($"Error in client occurred: {error}");
        }

        public void Send(MinecraftPacket packet) {
            if(ProtocolState != ProtocolState.Unknown) {
                Log.Debug($"Sending packet in state [{ProtocolState}] with id [0x{packet.Id:X}]");
                base.Send(packet.ToArray(CompressionEnabled, EncryptionEnabled, Encryptor));
            }

            packet.Dispose();
        }

        public void SendAsync(MinecraftPacket packet) {
            if(ProtocolState != ProtocolState.Unknown) {
                Log.Debug($"Sending packet in state [{ProtocolState}] with id [0x{packet.Id:X}]");
                base.Send(packet.ToArray(CompressionEnabled, EncryptionEnabled, Encryptor));
            }

            packet.Dispose();
        }

        public enum State {

            Disconnected,
            Connecting,
            Playing
        }
    }
}