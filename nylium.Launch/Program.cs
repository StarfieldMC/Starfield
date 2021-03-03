using System.Net;
using nylium.Networking;

namespace nylium.Launch {

    class Program {

        static void Main(string[] args) {
            Server server = new Server(IPAddress.Any, 25565);
            server.StartListening();
        }
    }
}
