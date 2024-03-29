// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:wheat", 152, 3357, 3364, 3357)]
    public class BlockWheat : BlockBase {

        public override ushort State {
            get {
                if(Age == 0) {
                    return 3357;
                }

                if(Age == 1) {
                    return 3358;
                }

                if(Age == 2) {
                    return 3359;
                }

                if(Age == 3) {
                    return 3360;
                }

                if(Age == 4) {
                    return 3361;
                }

                if(Age == 5) {
                    return 3362;
                }

                if(Age == 6) {
                    return 3363;
                }

                if(Age == 7) {
                    return 3364;
                }

                return DefaultState;
            }

            set {
                if(value == 3357) {
                    Age = 0;
                }

                if(value == 3358) {
                    Age = 1;
                }

                if(value == 3359) {
                    Age = 2;
                }

                if(value == 3360) {
                    Age = 3;
                }

                if(value == 3361) {
                    Age = 4;
                }

                if(value == 3362) {
                    Age = 5;
                }

                if(value == 3363) {
                    Age = 6;
                }

                if(value == 3364) {
                    Age = 7;
                }

            }
        }

        public int Age { get; set; } = 0;

        public BlockWheat() {
            State = DefaultState;
        }

        public BlockWheat(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockWheat(int age) {
            Age = age;
        }
    }
}