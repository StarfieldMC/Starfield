﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using DT = nylium.DataTypes;
using nylium.Packets;
using System.Diagnostics;
using System.Linq;
using nylium.Extensions;
using System.Net.NetworkInformation;

namespace nylium {

    class Server {

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

        private IPAddress ip;
        private int port;

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

                    Console.WriteLine("Waiting for a connection...");
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

            StateObject state = new StateObject();
            state.socket = handler;

            handler.BeginReceive(state.buffer, 0, StateObject.BUFFER_SIZE, 0,
                new AsyncCallback(ReadCallback), state);
        }

        private void ReadCallback(IAsyncResult ar) {
            StateObject state = (StateObject) ar.AsyncState;
            Socket socket = state.socket;

            int bytesRead = socket.EndReceive(ar);

            if(bytesRead > 0) {
                Packet packet = new Packet();
                packet.Read(new MemoryStream(state.buffer));

                Console.Write(string.Format("Received packet with id [{0}] and data [", packet.Id));
                packet.Data.ToArray().Print(Console.Out);
                Console.WriteLine("]");

                if(packet.Id == 0) {
                    Packet response = new Packet(0x00, new byte[] { });

                    DT.String jsonData = new DT.String(json);
                    jsonData.Write(response.Data);

                    Send(socket, response.GetBytes());
                } else if(packet.Id == 0x01) {
                    Packet pong = new Packet(0x01, packet.Data.ToArray());
                    Send(socket, pong.GetBytes());

                    socket.Close();
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
    }
}
