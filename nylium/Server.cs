using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.IO;
using System.Collections.Generic;

namespace nylium {
    class Server {
        List<TcpClient> activeConnections = new List<TcpClient>();
        TcpListener server = null;

        public Server(string ip, int port)
        {
            IPAddress listenAddr = IPAddress.Parse(ip);
            server = new TcpListener(listenAddr, port);
        }

        public void startListening()
        {
            server.Start();
            while(true)
            {
                TcpClient client = server.AcceptTcpClient();
                Thread thread = new Thread(new ParameterizedThreadStart(handle));
                thread.Start(client);
            }
        }

        public void handle(object obj)
        {
            TcpClient client = (TcpClient)obj;
            activeConnections.Add(client);

            NetworkStream stream = client.GetStream();

            while(client.Connected)
            {
                byte[] msg = new byte[1460];
                stream.Read(msg, 0, msg.Length);
            }

            activeConnections.Remove(client);
        }
    }
}
