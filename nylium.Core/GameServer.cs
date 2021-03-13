using System;
using System.Buffers.Binary;
using System.Collections.Generic;
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
using nylium.Core.DataTypes;
using nylium.Core.Packet;
using nylium.Core.Packet.Client.Handshake;
using nylium.Core.Packet.Client.Login;
using nylium.Core.Packet.Client.Play;
using nylium.Core.Packet.Client.Status;
using nylium.Core.Packet.Server.Login;
using nylium.Core.Packet.Server.Play;
using nylium.Core.Packet.Server.Status;
using nylium.Utilities;

namespace nylium.Core {

    public class GameServer {

        public const double TARGET_TPS = 20.0;
        public const string STATUS_STRING = @"{
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
        public const string TIMEOUT_MESSAGE = @"{""text"":""Timed out""}";

        public static NbtFile DimensionCodec { get; }
        public static NbtFile OverworldDimension { get; }
        public static NbtFile NetherDimension { get; }
        public static NbtFile TheEndDimension { get; }

        private static readonly List<GameClient> connectedClients = new();

        private static Socket listener;
        private static ManualResetEvent done = new(false);

        public static GameWorld World { get; set; }

        static GameServer() {
            DimensionCodec = new();
            OverworldDimension = new();
            NetherDimension = new();
            TheEndDimension = new();

            DimensionCodec.LoadFromBuffer(Properties.Resources.dimension_codec, 0,
                Properties.Resources.dimension_codec.Length, NbtCompression.AutoDetect);
            OverworldDimension.LoadFromBuffer(Properties.Resources.overworld, 0,
                Properties.Resources.overworld.Length, NbtCompression.AutoDetect);
            NetherDimension.LoadFromBuffer(Properties.Resources.nether, 0,
                Properties.Resources.nether.Length, NbtCompression.AutoDetect);
            TheEndDimension.LoadFromBuffer(Properties.Resources.the_end, 0,
                Properties.Resources.the_end.Length, NbtCompression.AutoDetect);

            NetworkPacket.Initialize();
            GameBlock.Initialize();
            GameEntity.Initialize();
            GameItem.Initialize();
            Tag.Initialize();
        }

        public static void Start(IPAddress ip, int port) {
            World = new GameWorld("world", new FlatWorldGenerator());

            listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

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

        private static void AcceptCallback(IAsyncResult ar) {
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

            GameClient client = new(handler);
            connectedClients.Add(client);

            handler.BeginReceive(client.buffer, 0, GameClient.BUFFER_SIZE, 0,
                new AsyncCallback(ReadCallback), client);
        }

        private static void ReadCallback(IAsyncResult ar) {
            GameClient client = (GameClient) ar.AsyncState;
            Socket socket = client.Socket;

            int bytesRead = socket.EndReceive(ar);

            if(!connectedClients.Contains(client)) return;

            if(bytesRead > 0) {
                MemoryStream mem = RMSManager.Get().GetStream("nylium.Networking.Server.ReadCallback", client.buffer);
                NetworkPacket packet = NetworkPacket.CreateClientPacket(mem, client.ProtocolState);

                if(packet == null) {
                    VarInt varInt = new();
                    varInt.Read(mem);
                    varInt.Read(mem);

                    int id = varInt.Value;

                    Console.WriteLine("Received unknown packet in state " + client.ProtocolState + " with id " + id);
                    return;
                }

                Console.WriteLine("Received packet in state " + client.ProtocolState + " with id " + packet.Id);

                try {
                    client.HandlePacket(packet);
                } catch(SocketException) {
                    connectedClients.Remove(client);
                }

                packet.Dispose();
                mem.Close();
                packet = null;
                mem = null;
            }

            // what a mess
            try {
                if(socket.IsConnected()) {
                    socket.BeginReceive(client.buffer, 0, GameClient.BUFFER_SIZE, 0,
                            new AsyncCallback(ReadCallback), client);
                } else {
                    if(connectedClients.Contains(client)) {
                        connectedClients.Remove(client);
                    }

                    client.Dispose();
                    client = null;
                }
            } catch(Exception) {
                if(connectedClients.Contains(client)) {
                    connectedClients.Remove(client);
                }

                try {
                    client.Dispose();
                } catch(ObjectDisposedException) { }

                client = null;
            }
        }

        public static void Broadcast(byte[] data) {
            for(int i = 0; i < connectedClients.Count; i++) {
                GameClient client = connectedClients[i];

                if(client.Ready) {
                    Send(connectedClients[i], data);
                }
            }
        }

        public static void Send(GameClient client, byte[] data) {
            try {
                if(client.Socket.IsConnected()) {
                    client.Socket.BeginSend(data, 0, data.Length, 0,
                        new AsyncCallback(SendCallback), client.Socket);
                } else {
                    if(connectedClients.Contains(client)) {
                        connectedClients.Remove(client);
                    }

                    client.Dispose();
                    client = null;
                }
            } catch(Exception) {
                if(connectedClients.Contains(client)) {
                    connectedClients.Remove(client);
                }

                try {
                    client.Dispose();
                } catch(ObjectDisposedException) { }

                client = null;
            }
        }

        private static void SendCallback(IAsyncResult ar) {
            try {
                Socket handler = (Socket) ar.AsyncState;

                int bytesSent = handler.EndSend(ar);
                //Console.WriteLine("Sent {0} bytes to client.", bytesSent);
            } catch(Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
