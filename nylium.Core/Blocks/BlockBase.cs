using System;
using System.Collections.Generic;
using System.Dynamic;

namespace nylium.Core.Blocks {

    public class BlockBase {

        public static string Id { get; set; }
        public static ushort DefaultState { get; set; }
        public static ushort MinimumState { get; set; }
        public static ushort MaximumState { get; set; }

        public ushort State { get; }
        public dynamic Properties { get; }

        public BlockBase(dynamic properties) {
            Properties = properties;
        }

        public BlockBase(ushort state) {
            Properties = new { };
            State = state;
        }

        public string GetId() => Id;
        public ushort GetDefaultState() => DefaultState;
        public ushort GetMinimumState() => MinimumState;
        public ushort GetMaximumState() => MaximumState;
    }
}