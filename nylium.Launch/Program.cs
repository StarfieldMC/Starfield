using System.Net;
using nylium.Core;

namespace nylium.Launch {

    class Program {

        static void Main(string[] args) {
            GameServer.Start(IPAddress.Any, 25565);
        }
    }
}
