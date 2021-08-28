// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:nether_wart", 258, 5132, 5135, 5132)]
    public class BlockNetherWart : BlockBase {

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

        public BlockNetherWart(ushort state) : base(state) {
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