using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using nylium.Core.Networking;
using nylium.Utilities;

namespace nylium.Core {

    public class Nylium {

        public const string WORLDS_DIRECTORY = "worlds";

        public static GameServer Server { get; set; }

        public static void Run(string[] args) {
            if(!Directory.Exists(WORLDS_DIRECTORY)) Directory.CreateDirectory(WORLDS_DIRECTORY);

            AppDomain.CurrentDomain.UnhandledException += ShutdownHook;
            AppDomain.CurrentDomain.ProcessExit += ShutdownHook;

            Server = new(IPAddress.Any, args.Length > 0 ? int.Parse(args[0]) : 25565);
            Server.Start();
        }

        private static void ShutdownHook(object s, EventArgs e) {
            if(Server != null) {
                if(Server.World != null) {
                    if(Server.World.Format != null) {
                        Server.World.Format.Save();
                    }
                }
            }
        }
    }
}