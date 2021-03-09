using System.Net;
using nylium.Networking;

namespace nylium.Launch {

    class Program {

        static void Main(string[] args) {
            GameServer server = new(IPAddress.Any, 25565);
            server.StartListening();
        }
    }
}
