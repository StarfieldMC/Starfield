using System;
using System.Buffers.Binary;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using DaanV2.UUID;
using fNbt.Tags;
using NetCoreServer;
using nylium.Core.Block;
using nylium.Core.Configuration;
using nylium.Core.DataTypes;
using nylium.Core.Entity;
using nylium.Core.Entity.Entities;
using nylium.Core.Packet;
using nylium.Core.Packet.Client.Handshake;
using nylium.Core.Packet.Client.Login;
using nylium.Core.Packet.Client.Play;
using nylium.Core.Packet.Client.Status;
using nylium.Core.Packet.Server.Login;
using nylium.Core.Packet.Server.Play;
using nylium.Core.Packet.Server.Status;
using nylium.Core.Tags;
using nylium.Core.World;
using nylium.Utilities;

namespace nylium.Core {

    public class GameClient : TcpSession {

        private readonly dynamic TIMEOUT_MESSAGE = new { text = "Timed out" };
        private readonly Random random = new();

        public State GameState { get; set; }
        private ProtocolState ProtocolState { get; set; }

        private KeepAlive KeepAlive { get; }

#pragma warning disable 0108
        private GameServer Server { get; }
#pragma warning restore 0108

        public ClientConfiguration Configuration { get; }

        public PlayerEntity Player { get; set; }
        public GameWorld World { get; set; }

        public GameClient(GameServer server) : base(server) {
            GameState = State.Disconnected;
            ProtocolState = ProtocolState.Unknown;
            KeepAlive = new(Send, () => {
                SP19Disconnect disconnect = new(TIMEOUT_MESSAGE);
                Send(disconnect);
            }, 1000);
            Server = server;
            Configuration = new ClientConfiguration();
        }

        private bool HandleHandshakePacket(NetworkPacket packet) {
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

        private bool HandleStatusPacket(NetworkPacket packet) {
            switch(packet) {
                case CS00Request: {
                        SS00Response response = new(GameServer.STATUS_STRING);
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

        private bool HandleLoginPacket(NetworkPacket packet) {
            switch(packet) {
                case CL00LoginStart: {
                        CL00LoginStart loginStart = (CL00LoginStart) packet;

                        DaanV2.UUID.UUID playerUuid = UUIDFactory.CreateUUID(3, 1, "OfflinePlayer:" + loginStart.Username);

                        SL02LoginSuccess loginSuccess = new(playerUuid, loginStart.Username);
                        Send(loginSuccess);

                        ProtocolState = ProtocolState.Play;
                        World = Server.World;
                        Player = new(World, loginStart.Username, playerUuid, Gamemode.Creative, 0, 1, 0, 0, 0, true);

                        SP24JoinGame joinGame = new(Player.EntityId, false, Player.Gamemode, Player.Gamemode,
                            new Utilities.Identifier[] { new("world") }, Server.DimensionCodec.RootTag, Server.OverworldDimension.RootTag,
                            new("world"), 0, 99, 8, false, true, false, true);
                        Send(joinGame);

                        KeepAlive.Start();

                        SP17PluginMessage brand = new(new Utilities.Identifier("minecraft", "brand"),
                            (sbyte[]) (Array) Encoding.UTF8.GetBytes("nylium"));
                        // TODO this causes out of bounds on the client
                        //Send(brand);
                        break;
                    }
                default:
                    return false;
            }

            return true;
        }

        private bool HandlePlayPacket(NetworkPacket packet) {
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
                        Configuration.ViewDistance = clientSettings.ViewDistance;

                        SP3FHeldItemChange heldItemChange = new(0);
                        Send(heldItemChange);

                        SP5ADeclareRecipes declareRecipes = new(null); // TODO generate recipes from recipes.json
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

                        SP40UpdateViewPosition updateViewPosition = new(0, 0);
                        Send(updateViewPosition);

                        Chunk[] chunks = World.GetChunksInViewDistance((int) Math.Floor(Player.X / 16), (int) Math.Floor(Player.Z / 16),
                            (sbyte) (Configuration.ViewDistance - 1));

                        // TODO unhardcode everything here
                        int mask = 0b00000000_00000000_00000000_00000001;

                        byte[] a = new byte[] { 0x01, 0x00, 0x80, 0x40, 0x20, 0x10, 0x08, 0x04 };
                        byte[] b = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x20, 0x10, 0x08, 0x04 };

                        long al = BinaryPrimitives.ReadInt64LittleEndian(a);
                        long bl = BinaryPrimitives.ReadInt64LittleEndian(b);

                        NbtCompound heightmap = new("") {
                            new NbtLongArray("MOTION_BLOCKING", new long[] {
                                            al, al, al, al, al, al, al, al, al, al, al, al, al, al, al, al, al, al, al, al,
                                            al, al, al, al, al, al, al, al, al, al, al, al, al, al, al,
                                            bl
                                        }),
                            new NbtLongArray("WORLD_SURFACE")
                        };

                        int[] biomes = Enumerable.Repeat(127, 1024).ToArray();

                        // TODO somehow the entire chunk is underwater?
                        for(int i = 0; i < chunks.Length; i++) {
                            Chunk chunk = chunks[i];
                            sbyte[] data = null;

                            using(MemoryStream stream = RMSManager.Get().GetStream("chunk data convert thing")) {
                                // only 1 section sent (see primary bit mask) therefore no loop
                                int nonAirBlockCount = chunk.GetBlockCountInSection(0, false);

                                Short blockCount = new((short) nonAirBlockCount);
                                UByte bitsPerBlock = new((byte) GameBlock.bitsPerBlock);

                                VarInt paletteLength = new(3);
                                VarInt stone = new(1);
                                VarInt air = new(0);

                                int[] blockIds = chunk.GetBlocksInSection(0);
                                long[] compactedLong = SectionUtils.ToCompactedLongArray(blockIds, GameBlock.bitsPerBlock);

                                VarInt dataArrayLength = new(compactedLong.Length);
                                Array<long, Long> dataArray = new(compactedLong);

                                blockCount.Write(stream);
                                bitsPerBlock.Write(stream);
                                dataArrayLength.Write(stream);
                                dataArray.Write(stream);

                                data = (sbyte[]) (Array) stream.ToArray();
                            }

                            SP20ChunkData chunkData = new(chunk.X, chunk.Z, true, mask, heightmap,
                                biomes, data, Array.Empty<NbtCompound>());
                            Send(chunkData);
                        }

                        SP3DWorldBorder worldBorder = new(0, 0, 0, 64, 0, 29999984, 16, 2);
                        Send(worldBorder);

                        SP42SpawnPosition spawnPosition = new(new(0, 16, 0));
                        Send(spawnPosition);

                        GameState = State.Playing;

                        for(int i = 0; i < World.PlayerEntities.Count; i++) {
                            PlayerEntity player = World.PlayerEntities[i];

                            SP32PlayerInfo _playerInfo = new(player.Uuid, player.Username, player.Gamemode, 0);
                            Send(_playerInfo);

                            _playerInfo = new(player.Uuid, 100); // TODO actual ping
                            Send(_playerInfo);
                        }

                        World.PlayerEntities.Add(Player);

                        SP32PlayerInfo playerInfo = new(Player.Uuid, Player.Username, Player.Gamemode, 0);
                        Server.Multicast(playerInfo);

                        playerInfo = new(Player.Uuid, 100); // TODO actual ping
                        Server.Multicast(playerInfo);

                        SP04SpawnPlayer spawnPlayer = new(Player.EntityId, Player.Uuid, Player.X, Player.Y, Player.Z,
                            Player.Yaw, Player.Pitch);
                        Server.MulticastAsync(spawnPlayer, this);
                        break;
                    }
                case CP12PlayerPosition: {
                        Player.LastX = Player.X;
                        Player.LastY = Player.Y;
                        Player.LastZ = Player.Z;
                        Player.LastOnGround = Player.OnGround;

                        CP12PlayerPosition playerPosition = (CP12PlayerPosition) packet;

                        if(double.IsInfinity(playerPosition.X) || double.IsInfinity(playerPosition.FeetY) || double.IsInfinity(playerPosition.Z)
                            || playerPosition.X > 3.2 * Math.Pow(10, 7) || playerPosition.Z > 3.2 * Math.Pow(10, 7)) {

                            SP19Disconnect disconnect = new(new {
                                text = "Invalid move packet received"
                            });
                            Send(disconnect);
                            Disconnect();
                            break;
                        }

                        double deltaX = Player.LastX - playerPosition.X;
                        double deltaY = Player.LastY - playerPosition.FeetY;
                        double deltaZ = Player.LastZ - playerPosition.Z;

                        double total = Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2);
                        double expected = Math.Pow(Player.LastX, 2) + Math.Pow(Player.LastY, 2) + Math.Pow(Player.LastZ, 2);
                        
                        // TODO               300 if elytra
                        if(total - expected > 100) {
                            Console.WriteLine($"Client with id [{Id}] moved too fast!");

                            SP56EntityTeleport teleport = new(Player.EntityId, Player.LastX, Player.LastY, Player.LastZ,
                                Player.Yaw, Player.Pitch, Player.LastOnGround);
                            Send(teleport);
                            break;
                        }

                        Player.X = playerPosition.X;
                        Player.Y = playerPosition.FeetY;
                        Player.Z = playerPosition.Z;
                        Player.OnGround = playerPosition.OnGround;

                        SP27EntityPosition entityPosition = new(Player.EntityId, (short) deltaX, (short) deltaY, (short) deltaZ, Player.OnGround);
                        Server.MulticastAsync(entityPosition, this);
                        break;
                    }
                case CP13PlayerPositionAndRotation: {
                        CP13PlayerPositionAndRotation playerPositionAndRotation = (CP13PlayerPositionAndRotation) packet;

                        Player.LastX = Player.X;
                        Player.LastY = Player.Y;
                        Player.LastZ = Player.Z;
                        Player.LastOnGround = Player.OnGround;

                        if(double.IsInfinity(playerPositionAndRotation.X) || double.IsInfinity(playerPositionAndRotation.FeetY) || double.IsInfinity(playerPositionAndRotation.Z)
                            || playerPositionAndRotation.X > 3.2 * Math.Pow(10, 7) || playerPositionAndRotation.Z > 3.2 * Math.Pow(10, 7)) {

                            SP19Disconnect disconnect = new(new {
                                text = "Invalid move packet received"
                            });
                            Send(disconnect);
                            Disconnect();
                            break;
                        }

                        double deltaX = Player.LastX - playerPositionAndRotation.X;
                        double deltaY = Player.LastY - playerPositionAndRotation.FeetY;
                        double deltaZ = Player.LastZ - playerPositionAndRotation.Z;

                        double total = Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2);
                        double expected = Math.Pow(Player.LastX, 2) + Math.Pow(Player.LastY, 2) + Math.Pow(Player.LastZ, 2);

                        // TODO               300 if elytra
                        if(total - expected > 100) {
                            Console.WriteLine($"Client with id [{Id}] moved too fast!");

                            SP56EntityTeleport teleport = new(Player.EntityId, Player.LastX, Player.LastY, Player.LastZ,
                                Player.Yaw, Player.Pitch, Player.LastOnGround);
                            Send(teleport);
                            break;
                        }

                        Player.X = playerPositionAndRotation.X;
                        Player.Y = playerPositionAndRotation.FeetY;
                        Player.Z = playerPositionAndRotation.Z;
                        Player.OnGround = playerPositionAndRotation.OnGround;

                        Player.Yaw = playerPositionAndRotation.Yaw;
                        Player.Pitch = playerPositionAndRotation.Pitch;

                        SP28EntityPositionAndRotation entityPositionAndRotation = new(Player.EntityId,
                            (short) deltaX, (short) deltaY, (short) deltaZ, Player.Yaw, Player.Pitch, Player.OnGround);
                        Server.MulticastAsync(entityPositionAndRotation, this);
                        break;
                    }
                case CP14PlayerRotation: {
                        Player.LastOnGround = Player.OnGround;

                        CP14PlayerRotation playerRotation = (CP14PlayerRotation) packet;

                        Player.Yaw = playerRotation.Yaw;
                        Player.Pitch = playerRotation.Pitch;
                        Player.OnGround = playerRotation.OnGround;

                        SP29EntityRotation entityRotation = new(Player.EntityId, Player.Yaw, Player.Pitch, Player.OnGround);
                        Server.MulticastAsync(entityRotation, this);
                        break;
                    }
                case CP15PlayerMovement: {
                        Player.LastOnGround = Player.OnGround;
                        CP15PlayerMovement playerMovement = (CP15PlayerMovement) packet;
                        Player.OnGround = playerMovement.OnGround;

                        SP2AEntityMovement entityMovement = new(Player.EntityId);
                        Server.MulticastAsync(entityMovement, this);
                        break;
                    }
                default:
                    return false;
            }

            return true;
        }

        protected override void OnConnected() {
            Console.WriteLine($"Client with id [{Id}] connected");
            GameState = State.Connecting;

            base.OnConnected();
        }

        protected override void OnReceived(byte[] buffer, long offset, long size) {
            if(ProtocolState == ProtocolState.Unknown) ProtocolState = ProtocolState.Handshaking;

            MemoryStream mem = RMSManager.Get().GetStream(buffer);
            NetworkPacket packet = NetworkPacket.CreateClientPacket(mem, ProtocolState);

            if(packet == null) {
                VarInt varInt = new();
                varInt.Read(mem);
                varInt.Read(mem);

                int id = varInt.Value;

                Console.WriteLine($"Received unknown packet in state [{ProtocolState}] with id [0x{id:X}]");
                return;
            }

            Console.WriteLine($"Received packet in state [{ProtocolState}] with id [0x{packet.Id:X}]");

            switch(ProtocolState) {
                case ProtocolState.Handshaking:
                    if(!HandleHandshakePacket(packet)) {
                        Console.WriteLine($"Warning: Packet in state [{ProtocolState}] with id [0x{packet.Id:X}] might not have been handled correctly");
                    }
                    break;

                case ProtocolState.Status:
                    if(!HandleStatusPacket(packet)) {
                        Console.WriteLine($"Warning: Packet in state [{ProtocolState}] with id [0x{packet.Id:X}] might not have been handled correctly");
                    }
                    break;

                case ProtocolState.Login:
                    if(!HandleLoginPacket(packet)) {
                        Console.WriteLine($"Warning: Packet in state [{ProtocolState}] with id [0x{packet.Id:X}] might not have been handled correctly");
                    }
                    break;

                case ProtocolState.Play:
                    if(!HandlePlayPacket(packet)) {
                        Console.WriteLine($"Warning: Packet in state [{ProtocolState}] with id [0x{packet.Id:X}] might not have been handled correctly");
                    }
                    break;
            }

            mem.Dispose();
            packet.Dispose();
        }

        protected override void OnDisconnected() {
            Console.WriteLine($"Client with id [{Id}] disconnected");

            if(ProtocolState == ProtocolState.Play && Player != null) {
                World.PlayerEntities.Remove(Player);
            }

            ProtocolState = ProtocolState.Unknown;
            GameState = State.Disconnected;

            KeepAlive.Stop();

            base.OnDisconnected();
        }

        protected override void OnError(SocketError error) {
            Console.WriteLine($"Error in client occured: {error}");
        }

        public void Send(NetworkPacket packet) {
            Console.WriteLine($"Sending packet in state [{ProtocolState}] with id [{packet.Id:X}]");
            base.Send(packet.ToBytes());

            packet.Dispose();
        }

        public enum State {

            Disconnected,
            Connecting,
            Playing
        }
    }
}