﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using DaanV2.UUID;
using Jil;
using NetCoreServer;
using Starfield.Extensions;
using Starfield.Logging;
using Starfield.Nbt.Tags;
using Starfield.Utilities;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.X509;
using Starfield.Core.Block;
using Starfield.Core.Configuration;
using Starfield.Core.Entity.Entities;
using Starfield.Core.Level;
using Starfield.Core.Networking.Packet;
using Starfield.Core.Networking.Packet.Client.Handshake;
using Starfield.Core.Networking.Packet.Client.Login;
using Starfield.Core.Networking.Packet.Client.Play;
using Starfield.Core.Networking.Packet.Client.Status;
using Starfield.Core.Networking.Packet.Server.Login;
using Starfield.Core.Networking.Packet.Server.Play;
using Starfield.Core.Networking.Packet.Server.Status;
using Starfield.Core.Tags;
using Http = System.Net.Http;

namespace Starfield.Core.Networking {

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
            KeepAlive = new KeepAlive(this, () => {
                SP19Disconnect disconnect = new(this, TIMEOUT_MESSAGE);
                Send(disconnect);
            }, 1000);
            Server = server;
            Configuration = new ClientConfiguration();
        }

        private bool HandleHandshakePacket(MinecraftPacket packet) {
            switch(packet) {
                case CH00Handshake handshake: {
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
                        SS00Response response = new(this, MinecraftServer.STATUS_STRING);
                        Send(response);
                        break;
                    }
                case CS01Ping ping: {
                    SS01Pong pong = new(this, ping.Payload);
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
                case CL00LoginStart loginStart: {
                    username = loginStart.Username;

                        if(Server.Configuration.OnlineMode) {
                            RNGCryptoServiceProvider rng = new();
                            rng.GetBytes(verifyToken);

                            SL01EncryptionRequest encryptionRequest = new(this, "",
                                (sbyte[]) (Array) SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(Server.KeyPair.Public).ToAsn1Object().GetDerEncoded(),
                                (sbyte[]) (Array) verifyToken);
                            Send(encryptionRequest);
                        } else {
                            UUID playerUuid = UUIDFactory.CreateUUID(3, 1, "OfflinePlayer:" + username);

                            if(Server.Configuration.CompressionThreshold > 0) {
                                SL03SetCompression setCompression = new(this, Server.Configuration.CompressionThreshold);
                                Send(setCompression);

                                CompressionEnabled = true;
                            }

                            SL02LoginSuccess loginSuccess = new(this, playerUuid, username);
                            Send(loginSuccess);

                            ProtocolState = ProtocolState.Play;
                            World = Server.World;
                            Player = new PlayerEntity(World, this, username, playerUuid, Gamemode.Creative, 0, 1, 0, 0, 0, true);

                            SP24JoinGame joinGame = new(this, Player.EntityId, false, Player.Gamemode, Player.Gamemode,
                                new Identifier[] { new(World.Name) }, Server.DimensionCodec.Root, Server.OverworldDimension.Root,
                                new Identifier(World.Name), 0, 99, Server.Configuration.ViewDistance, false, true, false, true);
                            Send(joinGame);

                            LoadedChunks = new List<Chunk>();
                            KeepAlive.Start();
                        }
                        break;
                    }
                case CL01EncryptionResponse encryptionResponse: {
                    byte[] decryptedSharedSecret = Server.Decryptor.ProcessBlock((byte[]) (Array) encryptionResponse.SharedSecret,
                            0, encryptionResponse.SharedSecret.Length);
                        byte[] decryptedVerifyToken = Server.Decryptor.ProcessBlock((byte[]) (Array) encryptionResponse.VerifyToken,
                            0, encryptionResponse.VerifyToken.Length);

                        if(!decryptedVerifyToken.SequenceEqual(verifyToken)) {
                            SL00Disconnect disconnect = new(this, new {
                                text = "Invalid verify token."
                            });

                            Send(disconnect);
                            Disconnect();
                            break;
                        }

                        Decryptor = new BufferedBlockCipher(new CfbBlockCipher(new AesEngine(), 8));
                        Decryptor.Init(false, new ParametersWithIV(new KeyParameter(decryptedSharedSecret), decryptedSharedSecret));

                        Encryptor = new BufferedBlockCipher(new CfbBlockCipher(new AesEngine(), 8));
                        Encryptor.Init(true, new ParametersWithIV(new KeyParameter(decryptedSharedSecret), decryptedSharedSecret));

                        string hash = HashUtils.MinecraftShaDigest(Encoding.ASCII.GetBytes("")
                            .Concat(decryptedSharedSecret)
                            .Concat(SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(Server.KeyPair.Public).ToAsn1Object().GetDerEncoded())
                            .ToArray());

                        Http.HttpResponseMessage response = Server.Http.Send(new Http.HttpRequestMessage(Http.HttpMethod.Get,
                            $"https://sessionserver.mojang.com/session/minecraft/hasJoined?username={username}&serverId={hash}"));

                        if(!response.IsSuccessStatusCode) {
                            SL00Disconnect disconnect = new(this, new {
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
                            SL03SetCompression setCompression = new(this, Server.Configuration.CompressionThreshold);
                            Send(setCompression);

                            CompressionEnabled = true;
                        }

                        SL02LoginSuccess loginSuccess = new(this, playerUuid, username);
                        Send(loginSuccess);

                        ProtocolState = ProtocolState.Play;
                        World = Server.World;
                        Player = new PlayerEntity(World, this, username, playerUuid, Gamemode.Creative, 0, 1, 0, 0, 0, true);

                        SP24JoinGame joinGame = new(this, Player.EntityId, false, Player.Gamemode, Player.Gamemode,
                            new Identifier[] { new(World.Name) }, Server.DimensionCodec.Root, Server.OverworldDimension.Root,
                            new Identifier(World.Name), 0, 99, Server.Configuration.ViewDistance, false, true, false, true);
                        Send(joinGame);

                        LoadedChunks = new List<Chunk>();
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
                            SP19Disconnect disconnect = new(this, new {
                                text = "keepAlive == null"
                            });

                            Send(disconnect);
                            Disconnect();
                        }

                        break;
                    }
                case CP05ClientSettings clientSettings: {
                    Configuration.ViewDistance = (clientSettings.ViewDistance > Server.Configuration.ViewDistance)
                            ? Server.Configuration.ViewDistance : clientSettings.ViewDistance;

                        SP13WindowItems windowItems = new(this, 0, Player.Inventory.Slots);
                        Send(windowItems);

                        SP3FHeldItemChange heldItemChange = new(this, (sbyte) (Player.Inventory.HeldSlot - 36)); // mojang moment
                        Send(heldItemChange);

                        SP5ADeclareRecipes declareRecipes = new(this, Array.Empty<Recipes.Recipe>()); // TODO generate recipes from recipes.json
                        Send(declareRecipes);

                        SP5BTags tags = new(this, Tag.blockTags.ToArray(),
                            Tag.itemTags.ToArray(),
                            Tag.fluidTags.ToArray(),
                            Tag.entityTags.ToArray());
                        Send(tags);

                        //SP1AEntityStatus entityStatus = new(this, Player.EntityId, SP1AEntityStatus.EntityStatus.SetOpLevel4);
                        //Send(entityStatus);

                        //SP35UnlockRecipes unlockRecipes = new(this, SP35UnlockRecipes.RecipeAction.Init,
                        //    false, false, false, false, false, false, false, false, new Utilities.Identifier[] { }, new Utilities.Identifier[] { });
                        //Send(unlockRecipes);

                        SP34PlayerPositionAndLook playerPositionAndLook = new(this, Player.X, Player.Y, Player.Z,
                            Player.Yaw, Player.Pitch, 0, random.Next(int.MaxValue));
                        Send(playerPositionAndLook);

                        SP40UpdateViewPosition updateViewPosition = new(this, Player.ChunkX, Player.ChunkZ);
                        Send(updateViewPosition);

                        Chunk[] chunks = World.GetChunksInViewDistance(Player.ChunkX, Player.ChunkZ,
                            (sbyte) (Configuration.ViewDistance - 1));
                        LoadChunks(chunks);

                        SP3DWorldBorder worldBorder = new(this, 0, 0, 0, 4096, 0, 2048, 16, 2);
                        Send(worldBorder);

                        SP42SpawnPosition spawnPosition = new(this, new Position.Int(0, 1, 0));
                        Send(spawnPosition);

                        foreach(PlayerEntity player in World.PlayerEntities) {
                            SP32PlayerInfo _playerInfo = new(this, player.Uuid, player.Username, player.Gamemode, 0);
                            Send(_playerInfo);

                            _playerInfo = new SP32PlayerInfo(this, player.Uuid, 100); // TODO actual ping
                            Send(_playerInfo);

                            if(LoadedChunks.Contains(World.GetChunk(player.ChunkX, player.ChunkZ))) {
                                SP04SpawnPlayer _spawnPlayer = new(this, player.EntityId, player.Uuid, player.X, player.Y, player.Z,
                                    player.Yaw, player.Pitch);
                                Send(_spawnPlayer);
                            }
                        }

                        World.PlayerEntities.Add(Player);

                        SP32PlayerInfo playerInfo = new(null, Player.Uuid, Player.Username, Player.Gamemode, 0);
                        Server.Multicast(playerInfo);

                        playerInfo = new SP32PlayerInfo(null, Player.Uuid, 100); // TODO actual ping
                        Server.Multicast(playerInfo);

                        SP04SpawnPlayer spawnPlayer = new(null, Player.EntityId, Player.Uuid, Player.X, Player.Y, Player.Z,
                            Player.Yaw, Player.Pitch);
                        Server.MulticastAsync(spawnPlayer, this);

                        GameState = State.Playing;
                        break;
                    }
                case CP2CAnimation animation: {
                    SP05EntityAnimation entityAnimation = new(null, Player.EntityId, animation.MainHand ?
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
            MemoryStream convertStream = RMSManager.Get().GetStream("Starfield.Core.Networking.MinecraftClient.LoadChunks()");

            foreach(Chunk chunk in chunks) {
                TagCompound heightmap = chunk.CreateHeightmap();

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
                        DataTypes.UByte bitsPerBlock = new(BlockBase.BITS_PER_BLOCK);

                        long[] compactedLong = section.ToCompactedLongArray(BlockBase.BITS_PER_BLOCK);

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

                SP20ChunkData chunkData = new(this, chunk.X, chunk.Z, true, mask, heightmap,
                    biomes, (sbyte[]) (Array) convertStream.ToArray(), Array.Empty<TagCompound>());
                SendAsync(chunkData);

                LoadedChunks.Add(chunk);

                convertStream.Position = 0;
                convertStream.SetLength(0);
            }

            convertStream.Dispose();
        }

        public void UnloadChunks(Chunk[] chunks) {
            foreach(Chunk chunk in chunks) {
                SP1CUnloadChunk unloadChunk = new(this, chunk.X, chunk.Z);
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

                Logger.Debug($"Received unknown packet in state [{ProtocolState}]");
                return;
            }

            Logger.Debug($"Received packet in state [{ProtocolState}] with id [0x{packet.Id:X}]");

            switch(ProtocolState) {
                case ProtocolState.Handshaking:
                    if(!HandleHandshakePacket(packet)) {
                        Logger.Debug($"Warning: Packet in state [{ProtocolState}] with id [0x{packet.Id:X}] might not have been handled correctly");
                    }
                    break;
                case ProtocolState.Status:
                    if(!HandleStatusPacket(packet)) {
                        Logger.Debug($"Warning: Packet in state [{ProtocolState}] with id [0x{packet.Id:X}] might not have been handled correctly");
                    }
                    break;
                case ProtocolState.Login:
                    if(!HandleLoginPacket(packet)) {
                        Logger.Debug($"Warning: Packet in state [{ProtocolState}] with id [0x{packet.Id:X}] might not have been handled correctly");
                    }
                    break;
                case ProtocolState.Play:
                    if(!HandlePlayPacket(packet)) {
                        Logger.Debug($"Warning: Packet in state [{ProtocolState}] with id [0x{packet.Id:X}] might not have been handled correctly");
                    }
                    break;
            }

            mem.Dispose();
            packet.Dispose();
        }

        protected override void OnConnected() {
            Logger.Debug($"Client with id [{Id}] connected");
            GameState = State.Connecting;

            base.OnConnected();
        }

        protected override void OnDisconnected() {
            Logger.Debug($"Client with id [{Id}] disconnected");

            if(ProtocolState == ProtocolState.Play && Player != null) {
                World.Format.Save(Player);
                World.PlayerEntities.Remove(Player);

                SP32PlayerInfo playerInfo = new(null, Player.Uuid);
                Server.MulticastAsync(playerInfo, this);

                SP36DestroyEntities destroyEntities = new(null, new int[] { Player.EntityId });
                Server.MulticastAsync(destroyEntities, this);
            }

            ProtocolState = ProtocolState.Unknown;
            GameState = State.Disconnected;

            KeepAlive.Stop();

            base.OnDisconnected();
        }

        protected override void OnError(SocketError error) {
            Logger.Debug($"Error in client occurred: {error}");
        }

        public void Send(MinecraftPacket packet, bool dispose = true) {
            if(ProtocolState != ProtocolState.Unknown) {
                Logger.Debug($"Sending packet in state [{ProtocolState}] with id [0x{packet.Id:X}]");
                base.Send(packet.ToArray());
            }

            if(dispose) packet.Dispose();
        }

        public void SendAsync(MinecraftPacket packet, bool dispose = true) {
            if(ProtocolState != ProtocolState.Unknown) {
                Logger.Debug($"Sending packet in state [{ProtocolState}] with id [0x{packet.Id:X}]");
                base.Send(packet.ToArray());
            }

            if(dispose) packet.Dispose();
        }

        public enum State {

            Disconnected,
            Connecting,
            Playing
        }
    }
}