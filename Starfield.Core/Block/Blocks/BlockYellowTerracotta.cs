// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:yellow_terracotta", 347, 6855, 6855, 6855)]
    public class BlockYellowTerracotta : BlockBase {

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockYellowTerracotta() {
            State = DefaultState;
        }

        public BlockYellowTerracotta(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}