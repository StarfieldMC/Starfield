using System;

namespace nylium.Core.Configuration {

    public class ServerConfiguration {

        public sbyte ViewDistance { get; set; }
        public int CompressionThreshold { get; set; }
        public bool OnlineMode { get; set; }
        public dynamic WorldGenArgs { get; set; }
    }
}