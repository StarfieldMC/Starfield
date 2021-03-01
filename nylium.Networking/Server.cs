using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using nylium.Extensions;
using nylium.Networking.Packets;
using nylium.Networking.Packets.Client;
using nylium.Networking.Packets.Server;
using DT = nylium.Networking.DataTypes;

namespace nylium.Networking {

    public class Server {

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

        private readonly IPAddress ip;
        private readonly int port;

        private Socket listener;
        private ManualResetEvent done = new ManualResetEvent(false);

        public Server(IPAddress ip, int port) {
            this.ip = ip;
            this.port = port;

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

            StateObject state = new StateObject();
            state.socket = handler;
            state.protocolState = ProtocolState.HANDSHAKING;

            handler.BeginReceive(state.buffer, 0, StateObject.BUFFER_SIZE, 0,
                new AsyncCallback(ReadCallback), state);
        }

        private void ReadCallback(IAsyncResult ar) {
            StateObject state = (StateObject) ar.AsyncState;
            Socket socket = state.socket;

            int bytesRead = socket.EndReceive(ar);

            if(bytesRead > 0) {
                MemoryStream mem = new MemoryStream(state.buffer, false);
                Packet packet = Packet.CreatePacket(mem, state.protocolState, PacketSide.CLIENT);

                Console.WriteLine(string.Format("Received packet in state [{0}] with id [{1}]", state.protocolState, packet.Id));

                switch(state.protocolState) {
                    case ProtocolState.HANDSHAKING: {
                            switch(packet) {
                                case CH00Handshake:
                                    CH00Handshake handshake = (CH00Handshake) packet;
                                    state.protocolState = handshake.NextState;
                                    break;
                            }
                            break;
                        }
                    case ProtocolState.STATUS: {
                            switch(packet) {
                                case CS00Request: {
                                        SS00Response response = new SS00Response(json);
                                        Send(socket, response.ToArray());
                                        break;
                                    }
                                case CS01Ping: {
                                        CS01Ping ping = (CS01Ping) packet;

                                        SS01Pong pong = new SS01Pong(ping.Payload);
                                        Send(socket, pong.ToArray());

                                        socket.Close();
                                        break;
                                    }
                            }
                            break;
                        }
                }
            }

            try {
                if(socket.IsConnected()) {
                    socket.BeginReceive(state.buffer, 0, StateObject.BUFFER_SIZE, 0,
                        new AsyncCallback(ReadCallback), state);
                } else {
                    socket.Dispose();
                }
            } catch(ObjectDisposedException e) { }
        }

        public void Send(Socket handler, byte[] data) {
            handler.BeginSend(data, 0, data.Length, 0,
                new AsyncCallback(SendCallback), handler);
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

    public class StateObject {

        public const int BUFFER_SIZE = 1024;
        public byte[] buffer = new byte[BUFFER_SIZE];

        public Socket socket = null;

        public ProtocolState protocolState;
    }
}
