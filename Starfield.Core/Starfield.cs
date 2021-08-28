using System;
using System.IO;
using System.Net;
using Starfield.Logging;
using Starfield.Core.Block;
using Starfield.Core.Entity;
using Starfield.Core.Item;
using Starfield.Core.Networking;
using Starfield.Core.Networking.Packet;
using Starfield.Core.Tags;

namespace Starfield.Core {

    public class Nylium {

        public const string WORLDS_DIRECTORY = "worlds";

        public static MinecraftServer Server { get; set; }

        public static void Run(string[] args) {
            Directory.CreateDirectory(WORLDS_DIRECTORY);

            Logger.Out = Console.Out;
            
#if DEBUG
            Logger.MinimumLevel = LogLevel.Debug;
#else
            Logger.MinimumLevel = LogLevel.Info;
#endif

            AppDomain.CurrentDomain.UnhandledException += ShutdownHook;
            AppDomain.CurrentDomain.ProcessExit += ShutdownHook;
            
            MinecraftPacket.Initialize();
            BaseEntity.Initialize();
            BlockRepository.Initialize();
            ItemRepository.Initialize();
            Tag.Initialize();

            Server = new MinecraftServer(IPAddress.Any, args.Length > 0 ? int.Parse(args[0]) : 25565);
            Server.Start();
        }

        private static void ShutdownHook(object s, EventArgs e) {
            Server?.World?.Format?.Save();
        }
    }
}