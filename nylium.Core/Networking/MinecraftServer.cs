using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using fNbt;
using NetCoreServer;
using nylium.Core.Blocks;
using nylium.Core.Entity;
using nylium.Core.Items;
using nylium.Core.Level;
using nylium.Core.Level.Generation.Generators;
using nylium.Core.Networking.Packet;
using nylium.Core.Tags;
using Serilog;

namespace nylium.Core.Networking {

    public class MinecraftServer : TcpServer {

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

        public NbtFile DimensionCodec { get; set; }
        public NbtFile OverworldDimension { get; set; }
        public NbtFile NetherDimension { get; set; }
        public NbtFile TheEndDimension { get; set; }

        public World World { get; set; }

        public MinecraftServer(IPAddress address, int port) : base(address, port) {
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

            MinecraftPacket.Initialize();
            Block.Initialize();
            GameEntity.Initialize();
            Item.Initialize();
            Tag.Initialize();

            World = new(this, "world", new FlatWorldGenerator());
        }

        protected override TcpSession CreateSession() {
            return new MinecraftClient(this);
        }

        protected override void OnError(SocketError error) {
            Log.Error($"Error in server occurred: {error}");
        }

        public void Multicast(MinecraftPacket packet, TcpSession excludeSession = null) {
            if(!IsStarted)
                return;

            if(packet == null)
                return;

            byte[] buffer = packet.ToBytes();
            int size = buffer.Length;

            foreach(TcpSession session in Sessions.Values) {
                if(session is MinecraftClient client) {
                    if(client.GameState != MinecraftClient.State.Playing) continue;
                }

                if(excludeSession != null) {
                    if(session != excludeSession) {
                        session.Send(buffer, 0, size);
                    }
                } else {
                    session.Send(buffer, 0, size);
                }
            }

            packet.Dispose();
        }

        public void MulticastAsync(MinecraftPacket packet, TcpSession excludeSession = null) {
            Task.Run(() => {
                if(!IsStarted)
                    return;

                if(packet == null)
                    return;

                byte[] buffer = packet.ToBytes();
                int size = buffer.Length;

                foreach(TcpSession session in Sessions.Values) {
                    if(session is MinecraftClient client) {
                        if(client.GameState != MinecraftClient.State.Playing) continue;
                    }

                    if(excludeSession != null) {
                        if(session != excludeSession) {
                            session.SendAsync(buffer, 0, size);
                        }
                    } else {
                        session.SendAsync(buffer, 0, size);
                    }
                }

                packet.Dispose();
            });
        }

        public void Multicast(MinecraftPacket packet, TcpSession excludeSession = null, params TcpSession[] sessions) {
            if(!IsStarted)
                return;

            if(packet == null)
                return;

            byte[] buffer = packet.ToBytes();
            int size = buffer.Length;

            foreach(TcpSession session in sessions) {
                if(session is MinecraftClient client) {
                    if(client.GameState != MinecraftClient.State.Playing) continue;
                }

                if(excludeSession != null) {
                    if(session != excludeSession) {
                        session.SendAsync(buffer, 0, size);
                    }
                } else {
                    session.SendAsync(buffer, 0, size);
                }
            }

            packet.Dispose();
        }

        public void MulticastAsync(MinecraftPacket packet, TcpSession excludeSession = null, params TcpSession[] sessions) {
            Task.Run(() => {
                if(!IsStarted)
                    return;

                if(packet == null)
                    return;

                byte[] buffer = packet.ToBytes();
                int size = buffer.Length;

                foreach(TcpSession session in sessions) {
                    if(session is MinecraftClient client) {
                        if(client.GameState != MinecraftClient.State.Playing) continue;
                    }

                    if(excludeSession != null) {
                        if(session != excludeSession) {
                            session.SendAsync(buffer, 0, size);
                        }
                    } else {
                        session.SendAsync(buffer, 0, size);
                    }
                }

                packet.Dispose();
            });
        }

        public ICollection<TcpSession> GetSessions() {
            return Sessions.Values;
        }
    }
}