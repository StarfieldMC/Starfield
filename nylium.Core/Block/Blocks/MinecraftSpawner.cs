// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockSpawner : BlockBase {

        public override string Id { get { return "minecraft:spawner"; } }

        public override ushort MinimumState { get { return 1953; } }
        public override ushort MaximumState { get { return 1953; } }
        public override ushort DefaultState { get { return 1953; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockSpawner() {
            State = DefaultState;
        }

        public BlockSpawner(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}