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

        public const string TIMEOUT_MESSAGE = @"{""text"":""Timed out""}";

        private readonly Random random = new();

        public State GameState { get; set; }
        private ProtocolState ProtocolState { get; set; }

        private KeepAlive KeepAlive { get; }

#pragma warning disable 0108
        private GameServer Server { get; }
#pragma warning restore 0108

        public ClientConfiguration Configuration { get; }

        public GameEntity Player { get; set; }
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

                        Dispose();
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

                        SL02LoginSuccess loginSuccess = new(
                            UUIDFactory.CreateUUID(3, 1, "OfflinePlayer:" + loginStart.Username),
                            loginStart.Username);
                        Send(loginSuccess);

                        ProtocolState = ProtocolState.Play;
                        World = Server.World;
                        Player = new(World, "minecraft:player", 0, 16, 0, 0, 0);

                        SP24JoinGame joinGame = new(Player.EntityId, false, Gamemode.Creative, Gamemode.Creative,
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

                            Dispose();
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

                        SP32PlayerInfo playerInfo = new();
                        Send(playerInfo);

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

                        GameState = State.Playing;

                        SP42SpawnPosition spawnPosition = new(new(0, 16, 0));
                        Send(spawnPosition);

                        //playerPositionAndLook = new(Player.X, Player.Y, Player.Z,
                        //    Player.Yaw, Player.Pitch, 0, random.Next(int.MaxValue));
                        //Send(playerPositionAndLook);

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
        }

        protected override void OnDisconnected() {
            Console.WriteLine($"Client with id [{Id}] disconnected");
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
        }

        public enum State {
            Disconnected,
            Connecting,
            Playing
        }
    }
}