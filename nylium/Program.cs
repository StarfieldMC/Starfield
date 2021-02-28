using System;
using System.Net;

namespace nylium {

    class Program {

        public static void Main(string[] args) {
            Server server = new Server(IPAddress.Any, 25565);
            server.StartListening();
        }
    }
}
