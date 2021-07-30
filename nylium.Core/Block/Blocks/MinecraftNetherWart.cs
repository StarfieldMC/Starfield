// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockNetherWart : BlockBase {

        public override string Id { get { return "minecraft:nether_wart"; } }

        public override ushort MinimumState { get { return 5132; } }
        public override ushort MaximumState { get { return 5135; } }
        public override ushort DefaultState { get { return 5132; } }

        public override ushort State {
            get {
                if(Age == 0) {
                    return 5132;
                }

                if(Age == 1) {
                    return 5133;
                }

                if(Age == 2) {
                    return 5134;
                }

                if(Age == 3) {
                    return 5135;
                }

                return DefaultState;
            }

            set {
                if(value == 5132) {
                    Age = 0;
                }

                if(value == 5133) {
                    Age = 1;
                }

                if(value == 5134) {
                    Age = 2;
                }

                if(value == 5135) {
                    Age = 3;
                }

            }
        }

        public int Age { get; set; } = 0;

        public BlockNetherWart() {
            State = DefaultState;
        }

        public BlockNetherWart(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockNetherWart(int age) {
            Age = age;
        }
    }
}