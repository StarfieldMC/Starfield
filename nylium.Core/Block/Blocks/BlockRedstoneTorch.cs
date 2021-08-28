// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:redstone_torch", 181, 3887, 3888, 3887)]
    public class BlockRedstoneTorch : BlockBase {

        public override ushort State {
            get {
                if(Lit == true) {
                    return 3887;
                }

                if(Lit == false) {
                    return 3888;
                }

                return DefaultState;
            }

            set {
                if(value == 3887) {
                    Lit = true;
                }

                if(value == 3888) {
                    Lit = false;
                }

            }
        }

        public bool Lit { get; set; } = true;

        public BlockRedstoneTorch() {
            State = DefaultState;
        }

        public BlockRedstoneTorch(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockRedstoneTorch(bool lit) {
            Lit = lit;
        }
    }
}