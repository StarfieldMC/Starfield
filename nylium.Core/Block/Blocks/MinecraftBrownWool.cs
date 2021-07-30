// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBrownWool : BlockBase {

        public override string Id { get { return "minecraft:brown_wool"; } }

        public override ushort MinimumState { get { return 1396; } }
        public override ushort MaximumState { get { return 1396; } }
        public override ushort DefaultState { get { return 1396; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockBrownWool() {
            State = DefaultState;
        }

        public BlockBrownWool(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}