// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:redstone_lamp", 266, 5160, 5161, 5161)]
    public class BlockRedstoneLamp : BlockBase {

        public override ushort State {
            get {
                if(Lit == true) {
                    return 5160;
                }

                if(Lit == false) {
                    return 5161;
                }

                return DefaultState;
            }

            set {
                if(value == 5160) {
                    Lit = true;
                }

                if(value == 5161) {
                    Lit = false;
                }

            }
        }

        public bool Lit { get; set; } = false;

        public BlockRedstoneLamp() {
            State = DefaultState;
        }

        public BlockRedstoneLamp(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockRedstoneLamp(bool lit) {
            Lit = lit;
        }
    }
}