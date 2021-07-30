using System;
using System.IO;
using System.Net;
using nylium.Core.Networking;
using Serilog;

namespace nylium.Core {

    public class Nylium {

        public const string WORLDS_DIRECTORY = "worlds";

        public static MinecraftServer Server { get; set; }

        public static void Run(string[] args) {
            //Blocks.BlockBase block = new Blocks.Foo.CobblestoneStairs(3662);
            //Console.WriteLine(block.Properties);
            //Console.ReadKey();
            Directory.CreateDirectory(WORLDS_DIRECTORY);

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
#if DEBUG
                .MinimumLevel.Debug()
#else
                .MinimumLevel.Information()
#endif
                .CreateLogger();

            AppDomain.CurrentDomain.UnhandledException += ShutdownHook;
            AppDomain.CurrentDomain.ProcessExit += ShutdownHook;

            Server = new(IPAddress.Any, args.Length > 0 ? int.Parse(args[0]) : 25565);
            Server.Start();
        }

        private static void ShutdownHook(object s, EventArgs e) {
            Log.CloseAndFlush();
            Server?.World?.Format?.Save();
        }
    }
}