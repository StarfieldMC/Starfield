using System;
using System.Net;
using nylium.Core.Networking;

namespace nylium.Core {

    public class Nylium {

        public const string WORLDS_DIRECTORY = "worlds";

        public static GameServer Server { get; set; }

        public static void Run(string[] args) {
            Server = new(IPAddress.Any, args.Length > 0 ? int.Parse(args[0]) : 25565);
            Server.Start();
        }
    }
}