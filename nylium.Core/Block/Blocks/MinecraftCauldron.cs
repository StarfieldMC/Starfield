// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCauldron : BlockBase {

        public override string Id { get { return "minecraft:cauldron"; } }

        public override ushort MinimumState { get { return 5145; } }
        public override ushort MaximumState { get { return 5148; } }
        public override ushort DefaultState { get { return 5145; } }

        public override ushort State {
            get {
                if(Level == 0) {
                    return 5145;
                }

                if(Level == 1) {
                    return 5146;
                }

                if(Level == 2) {
                    return 5147;
                }

                if(Level == 3) {
                    return 5148;
                }

                return DefaultState;
            }

            set {
                if(value == 5145) {
                    Level = 0;
                }

                if(value == 5146) {
                    Level = 1;
                }

                if(value == 5147) {
                    Level = 2;
                }

                if(value == 5148) {
                    Level = 3;
                }

            }
        }

        public int Level { get; set; } = 0;

        public BlockCauldron() {
            State = DefaultState;
        }

        public BlockCauldron(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockCauldron(int level) {
            Level = level;
        }
    }
}