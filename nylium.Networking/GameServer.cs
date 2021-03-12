using System;
using System.Buffers.Binary;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using DaanV2.UUID;
using fNbt;
using fNbt.Tags;
using nylium.Core.Block;
using nylium.Core.Entity;
using nylium.Core.Item;
using nylium.Core.Tags;
using nylium.Core.World;
using nylium.Core.World.Generation.Generators;
using nylium.Extensions;
using nylium.Networking.DataTypes;
using nylium.Networking.Packets;
using nylium.Networking.Packets.Client.Handshake;
using nylium.Networking.Packets.Client.Login;
using nylium.Networking.Packets.Client.Play;
using nylium.Networking.Packets.Client.Status;
using nylium.Networking.Packets.Server.Login;
using nylium.Networking.Packets.Server.Play;
using nylium.Networking.Packets.Server.Status;
using nylium.Utilities;

namespace nylium.Networking {

    public class GameServer {

        string json = @"{
    ""version"": {
        ""name"": ""1.16.5"",
        ""protocol"": 754
    },
    ""players"": {
        ""max"": 99,
        ""online"": 1,
        ""sample"": [
            {
                ""name"": ""dskprt"",
                ""id"": ""1e6610a5-66b1-418f-bbf0-ec25ad892d57""
            }
        ]
    },
    ""description"": {
    ""text"": ""Hello world""
    },
    ""favicon"": ""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAEAAAABACAMAAACdt4HsAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAGeUExURf////7+/v39/fLy8tLS0sXFxcjIyOTk5Pr6+urq6snJycTExMzMzO/v7/Hx8aenp0JCQh8fHyUlJXV1ddXV1eXl5YeHhycnJx0dHTAwMJeXl+7u7rGxsTIyMgQEBAAAAAwMDPb29oyMjA4ODgEBARsbG6CgoPv7+2NjYy0tLV1dXQoKCujo6CYmJgMDAzo6Ovn5+X9/fxkZGU9PTwUFBfz8/NfX12FhYb6+vg0NDREREUlJSc7OzsLCwmVlZVtbW29vb8rKyqSkpLu7u+vr67Ozs0VFRb29vaurq5+fn93d3QICAgkJCW5ubuPj49/f3xUVFRISEl5eXtjY2KOjoygoKKampufn50RERGdnZ/Pz8wgICC4uLvX19ampqSwsLBQUFBgYGNra2uLi4u3t7XNzczQ0NJSUlCAgIGlpaQ8PDz4+PoaGhrS0tL+/v7y8vLq6uqqqqlBQUDw8PFNTU6+vryQkJHp6eisrK05OTgYGBnBwcPf397W1tT09PUFBQcfHxxwcHFpaWh4eHgcHBxMTE4qKitDQ0PT09Pj4+Ifx2AUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAIqSURBVFhH7dXrW9JQGABwzpkImMHUKA2EmYsRGA5iimYmWZGKGV3UsKVdNbqoZRdr3bXyv+6c8TIZYxsf63n2+8DD++7s3DjnxeVwOP5jCCP4pmOSNmLa3O0eLwQa7Os40nkUAkv+ANvV3XOsoQccPH6it+9kCEILKNwfiUa5Hg/EYODUYDTKn47Zr0KIc1Giu13f1HeGZiOsALE5byJJm3a5MSRUaOgszaaGRUiYw+kMT4dq088gdC5LOuDiEsQWRkYzSa4/wEAIhNzwWHL8/ASEVtBIOhEP+yHSeC9MXpyaaO0kYK/QrKHkbWH+jn8dwq0WhOaY/KXY9GUIbGFJd5cI5gqbzI5dLdhfR8pzbSYwqzt3KM/O0ftYnL/ewjoWJm9wpZu36ieBb6tlghSVO4uGe9JoaZkOlr1bhpjCsZVqB6Qo3Fusf2Ig318lBYFYW4IMhXIP1KQqwk7LZgtBDxO1oVYeQU71+AmtKDXZp+sLIkY15CeWJEkQRTE0s1Ednij54N2q4DNtERRfef7i5avNzUKhkMttba+np0ZfL7/pW1O3WsXvNNQ/+S2sTcPXg9yhd3l48VDwfQke2uM/bDUeJULs2P0IDWxUPs0232bl85f6zTQx9/Wb4b9RUw6zut004sfTlncGKZ3z31PQ2Igf3HGbDw+koe0fP4uRlCayV+Qq+5nejdXdX78VaGUJCUqZodRPP1P+I8sDinJwIDbZe4fD4SBcrr+GmnBV9BcBXAAAAABJRU5ErkJggg==""
}";

        private const string timeoutMessage = @"{""text"":""Timed out""}";

        private static readonly Random random = new();

        private static readonly NbtFile dimensionCodec = new();
        private static readonly NbtFile overworldDimension = new();
        private static readonly NbtFile netherDimension = new();
        private static readonly NbtFile theEndDimension = new();

        private readonly IPAddress ip;
        private readonly int port;

        private readonly Socket listener;
        private readonly ManualResetEvent done = new(false);

        private readonly World world;

        static GameServer() {
            dimensionCodec.LoadFromBuffer(Properties.Resources.dimension_codec, 0,
                Properties.Resources.dimension_codec.Length, NbtCompression.AutoDetect);
            overworldDimension.LoadFromBuffer(Properties.Resources.overworld, 0,
                Properties.Resources.overworld.Length, NbtCompression.AutoDetect);
            netherDimension.LoadFromBuffer(Properties.Resources.nether, 0,
                Properties.Resources.nether.Length, NbtCompression.AutoDetect);
            theEndDimension.LoadFromBuffer(Properties.Resources.the_end, 0,
                Properties.Resources.the_end.Length, NbtCompression.AutoDetect);
        }

        public GameServer(IPAddress ip, int port) {
            this.ip = ip;
            this.port = port;

            Packet.Initialize();
            Block.Initialize();
            Entity.Initialize();
            Item.Initialize();
            Tag.Initialize();

            world = new World("world", new FlatWorldGenerator());

            listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
        }

        public void StartListening() {
            try {
                listener.Bind(new IPEndPoint(ip, port));
                listener.Listen(100);

                while(true) {
                    done.Reset();

                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback),
                        listener);

                    done.WaitOne();
                }

            } catch(Exception e) {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private void AcceptCallback(IAsyncResult ar) {
            done.Set();

            Socket listener = (Socket) ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            IPEndPoint remoteEndPoint = (IPEndPoint) handler.RemoteEndPoint;
            IPEndPoint localEndPoint = (IPEndPoint) handler.LocalEndPoint;

            if(remoteEndPoint != null) {
                Console.WriteLine(string.Format("User [{0}:{1}] connected", remoteEndPoint.Address, remoteEndPoint.Port));
            } else {
                Console.WriteLine(string.Format("User [{0}:{1}] connected", localEndPoint.Address, localEndPoint.Port));
            }

            StateObject state = new() {
                socket = handler,
                protocolState = ProtocolState.Handshaking,
            };

            handler.BeginReceive(state.buffer, 0, StateObject.BUFFER_SIZE, 0,
                new AsyncCallback(ReadCallback), state);
        }

        private void ReadCallback(IAsyncResult ar) {
            StateObject state = (StateObject) ar.AsyncState;
            Socket socket = state.socket;

            int bytesRead = socket.EndReceive(ar);

            if(bytesRead > 0) {
                MemoryStream mem = RMSManager.Get().GetStream("nylium.Networking.Server.ReadCallback", state.buffer);
                Packet packet = Packet.CreateClientPacket(mem, state.protocolState);

                if(packet == null) {
                    VarInt varInt = new();
                    varInt.Read(mem);
                    varInt.Read(mem);

                    int id = varInt.Value;

                    Console.WriteLine("Received unknown packet in state " + state.protocolState + " with id " + id);
                    return;
                }

                Console.WriteLine("Received packet in state " + state.protocolState + " with id " + packet.Id);

                switch(state.protocolState) {
                    case ProtocolState.Handshaking:
                        switch(packet) {
                            case CH00Handshake: {
                                    CH00Handshake handshake = (CH00Handshake) packet;
                                    state.protocolState = handshake.NextState;
                                    break;
                                }
                        }
                        break;
                    case ProtocolState.Status:
                        switch(packet) {
                            case CS00Request: {
                                    SS00Response response = new(json);
                                    Send(socket, response.ToBytes());
                                    break;
                                }
                            case CS01Ping: {
                                    CS01Ping ping = (CS01Ping) packet;

                                    SS01Pong pong = new(ping.Payload);
                                    Send(socket, pong.ToBytes());

                                    socket.Close();
                                    return;
                                }
                        }
                        break;
                    case ProtocolState.Login:
                        switch(packet) {
                            case CL00LoginStart: {
                                    CL00LoginStart loginStart = (CL00LoginStart) packet;

                                    SL02LoginSuccess loginSuccess = new(
                                        UUIDFactory.CreateUUID(3, 1, "OfflinePlayer:" + loginStart.Username),
                                        loginStart.Username);
                                    Send(socket, loginSuccess.ToBytes());

                                    state.protocolState = ProtocolState.Play;
                                    state.player = new(world, "minecraft:player", 0, 260, 0, 0, 0);

                                    SP24JoinGame joinGame = new(state.player.EntityId, false, Gamemode.Creative, Gamemode.Creative,
                                        new Utilities.Identifier[] { new("world") }, dimensionCodec.RootTag, overworldDimension.RootTag,
                                        new("world"), 0, 99, 8, false, true, false, true);
                                    Send(socket, joinGame.ToBytes());

                                    state.keepAlive = new(socket, Send, Timeout, 1000);

                                    SP17PluginMessage brand = new(new Utilities.Identifier("minecraft", "brand"),
                                        (sbyte[]) (Array) Encoding.UTF8.GetBytes("nylium"));
                                    // TODO this causes out of bounds on the client
                                    //Send(socket, brand.ToBytes());
                                    break;
                                }
                        }
                        break;
                    case ProtocolState.Play:
                        switch(packet) {
                            case CP10KeepAlive: {
                                    if(state.keepAlive != null) {
                                        state.keepAlive.HasResponded = true;
                                    } else {
                                        SP19Disconnect disconnect = new(new {
                                            text = "keepAlive == null"
                                        });

                                        socket.Close();
                                        return;
                                    }
                                    break;
                                }
                            case CP05ClientSettings: {
                                    CP05ClientSettings clientSettings = (CP05ClientSettings) packet;
                                    state.viewDistance = clientSettings.ViewDistance;

                                    SP3FHeldItemChange heldItemChange = new(0);
                                    Send(socket, heldItemChange.ToBytes());

                                    SP5ADeclareRecipes declareRecipes = new(null); // TODO generate recipes from recipes.json
                                    Send(socket, declareRecipes.ToBytes());

                                    SP5BTags tags = new(Tag.blockTags.ToArray(),
                                        Tag.itemTags.ToArray(),
                                        Tag.fluidTags.ToArray(),
                                        Tag.entityTags.ToArray());
                                    Send(socket, tags.ToBytes());

                                    SP34PlayerPositionAndLook playerPositionAndLook = new(state.player.X, state.player.Y, state.player.Z,
                                        state.player.Yaw, state.player.Pitch, 0, random.Next(int.MaxValue));
                                    Send(socket, playerPositionAndLook.ToBytes());

                                    SP40UpdateViewPosition updateViewPosition = new(0, 0);
                                    Send(socket, updateViewPosition.ToBytes());

                                    Chunk[] chunks = world.GetChunksInViewDistance((int) Math.Floor(state.player.X / 16), (int) Math.Floor(state.player.Z / 16),
                                        (sbyte)(state.viewDistance - 1));

                                    byte sections0 = 0;
                                    byte sections1 = 0;

                                    sections0.SetBit(7, true);

                                    int mask = sections0 | (sections1 << 8);

                                    // idk
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

                                    for(int i = 0; i < chunks.Length; i++) {
                                        Chunk chunk = chunks[i];
                                        sbyte[] data = null;

                                        using(MemoryStream stream = RMSManager.Get().GetStream("chunk data convert thing")) {
                                            // only 1 section sent (see primary bit mask) therefore no loop
                                            int nonAirBlockCount = chunk.GetBlockCountInSection(0, false);

                                            Short blockCount = new((short) nonAirBlockCount);
                                            UByte bitsPerBlock = new(8);

                                            VarInt paletteLength = new(3);
                                            VarInt stone = new(1);
                                            VarInt air = new(0);

                                            int[] blockIds = chunk.GetBlocksInSection(0);

                                            VarInt dataArrayLength = new(16 * 16 * 16);
                                            byte[] dataArrayRaw = new byte[16 * 16 * 16];

                                            int k = 0;

                                            for(int j = blockIds.Length - 1; j >= 0; j--) {
                                                int id = blockIds[j];

                                                byte bb = 0;

                                                // hardcode idk
                                                if(id == 1) {
                                                    bb.SetBit(0, true);
                                                }

                                                dataArrayRaw[k] = bb;
                                                k++;
                                            }

                                            ByteArray dataArray = new((sbyte[]) (Array) dataArrayRaw);

                                            blockCount.Write(stream);
                                            bitsPerBlock.Write(stream);
                                            paletteLength.Write(stream);
                                            air.Write(stream);
                                            stone.Write(stream);
                                            stone.Write(stream);
                                            dataArrayLength.Write(stream);
                                            dataArray.Write(stream);

                                            data = (sbyte[]) (Array) stream.ToArray();
                                        }

                                        SP20ChunkData chunkData = new(chunk.X, chunk.Z, true, mask, heightmap,
                                            biomes, data, new NbtCompound[] { });
                                        Send(socket, chunkData.ToBytes());
                                    }

                                    SP3DWorldBorder worldBorder = new(0, 0, 0, 64, 0, 29999984, 16, 2);
                                    Send(socket, worldBorder.ToBytes());

                                    SP42SpawnPosition spawnPosition = new(new(0, 260, 0));
                                    Send(socket, spawnPosition.ToBytes());

                                    Send(socket, playerPositionAndLook.ToBytes());

                                    state.keepAlive.Start();
                                    break;
                                }
                        }
                        break;
                }

                packet.Dispose();
                mem.Close();
                packet = null;
                mem = null;
            }

            try {
                if(socket.IsConnected()) {
                    socket.BeginReceive(state.buffer, 0, StateObject.BUFFER_SIZE, 0,
                        new AsyncCallback(ReadCallback), state);
                } else {
                    if(state.keepAlive != null) {
                        state.keepAlive.Stop();
                    }

                    socket.Dispose();
                    socket = null;
                    state = null;
                }
            } catch(ObjectDisposedException) {
                if(state.keepAlive != null) {
                    state.keepAlive.Stop();
                }

                state = null;
            }
        }

        private void Timeout(Socket handler) {
            SP19Disconnect disconnect = new(timeoutMessage);
            Send(handler, disconnect.ToBytes());
        }

        private void Send(Socket handler, byte[] data) {
            try {
                if(handler.IsConnected()) {
                    handler.BeginSend(data, 0, data.Length, 0,
                        new AsyncCallback(SendCallback), handler);
                } else {
                    handler.Dispose();
                }
            } catch(ObjectDisposedException) { } catch(SocketException) { }
        }

        private void SendCallback(IAsyncResult ar) {
            try {
                Socket handler = (Socket) ar.AsyncState;

                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);
            } catch(Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
    }

    class StateObject {

        public const int BUFFER_SIZE = 1024;
        public byte[] buffer = new byte[BUFFER_SIZE];

        public Socket socket;
        public KeepAlive keepAlive;

        public ProtocolState protocolState;

        // TODO add other things from 0x05 client settings
        public sbyte viewDistance;

        public Entity player;
    }
}
