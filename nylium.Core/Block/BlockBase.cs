using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using IntervalTree;
using Ionic.Zlib;
using Jil;
using nylium.Utilities;
using nylium.Utilities.Collections;
using Serilog;

namespace nylium.Core.Block {

    public abstract class BlockBase {

        public const int BITS_PER_BLOCK = 15;
        
        private BlockAttribute Attribute {
            get {
                return GetType().GetCustomAttribute<BlockAttribute>(false);
            }
        }
        
        public Identifier Id { get { return Attribute.Id; } }
        public int ProtocolId { get { return Attribute.ProtocolId; } }
        
        public ushort MinimumState { get { return Attribute.MinimumState; } }
        public ushort MaximumState { get { return Attribute.MaximumState; } }
        public ushort DefaultState { get { return Attribute.DefaultState; } }

        public abstract ushort State { get; set; }
        
        public BlockBase() { }
        public BlockBase(ushort state) { }

        private static BlockAttribute GetAttribute(Type block) {
            return block.GetCustomAttribute<BlockAttribute>(false);
        }
        
        public static Identifier GetId(Type block) {
            return GetAttribute(block).Id;
        }
        
        public static int GetProtocolId(Type block) {
            return GetAttribute(block).ProtocolId;
        }
        
        public static ushort GetMinimumState(Type block) {
            return GetAttribute(block).MinimumState;
        }
        
        public static ushort GetMaximumState(Type block) {
            return GetAttribute(block).MaximumState;
        }
        
        public static ushort GetDefaultState(Type block) {
            return GetAttribute(block).DefaultState;
        }
    }
}