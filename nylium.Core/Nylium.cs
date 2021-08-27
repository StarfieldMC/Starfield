﻿using System;
using System.IO;
using System.Net;
using nylium.Core.Block;
using nylium.Core.Entity;
using nylium.Core.Items;
using nylium.Core.Networking;
using nylium.Core.Networking.Packet;
using nylium.Core.Tags;
using Serilog;

namespace nylium.Core {

    public class Nylium {

        public const string WORLDS_DIRECTORY = "worlds";

        public static MinecraftServer Server { get; set; }

        public static void Run(string[] args) {
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
            
            MinecraftPacket.Initialize();
            BaseEntity.Initialize();
            BlockRepository.Initialize();
            Item.Initialize();
            Tag.Initialize();

            Server = new(IPAddress.Any, args.Length > 0 ? int.Parse(args[0]) : 25565);
            Server.Start();
        }

        private static void ShutdownHook(object s, EventArgs e) {
            Log.CloseAndFlush();
            Server?.World?.Format?.Save();
        }
    }
}