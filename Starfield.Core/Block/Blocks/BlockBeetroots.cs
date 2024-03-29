// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:beetroots", 497, 9223, 9226, 9223)]
    public class BlockBeetroots : BlockBase {

        public override ushort State {
            get {
                if(Age == 0) {
                    return 9223;
                }

                if(Age == 1) {
                    return 9224;
                }

                if(Age == 2) {
                    return 9225;
                }

                if(Age == 3) {
                    return 9226;
                }

                return DefaultState;
            }

            set {
                if(value == 9223) {
                    Age = 0;
                }

                if(value == 9224) {
                    Age = 1;
                }

                if(value == 9225) {
                    Age = 2;
                }

                if(value == 9226) {
                    Age = 3;
                }

            }
        }

        public int Age { get; set; } = 0;

        public BlockBeetroots() {
            State = DefaultState;
        }

        public BlockBeetroots(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBeetroots(int age) {
            Age = age;
        }
    }
}