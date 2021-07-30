// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCarrots : BlockBase {

        public override string Id { get { return "minecraft:carrots"; } }

        public override ushort MinimumState { get { return 6334; } }
        public override ushort MaximumState { get { return 6341; } }
        public override ushort DefaultState { get { return 6334; } }

        public override ushort State {
            get {
                if(Age == 0) {
                    return 6334;
                }

                if(Age == 1) {
                    return 6335;
                }

                if(Age == 2) {
                    return 6336;
                }

                if(Age == 3) {
                    return 6337;
                }

                if(Age == 4) {
                    return 6338;
                }

                if(Age == 5) {
                    return 6339;
                }

                if(Age == 6) {
                    return 6340;
                }

                if(Age == 7) {
                    return 6341;
                }

                return DefaultState;
            }

            set {
                if(value == 6334) {
                    Age = 0;
                }

                if(value == 6335) {
                    Age = 1;
                }

                if(value == 6336) {
                    Age = 2;
                }

                if(value == 6337) {
                    Age = 3;
                }

                if(value == 6338) {
                    Age = 4;
                }

                if(value == 6339) {
                    Age = 5;
                }

                if(value == 6340) {
                    Age = 6;
                }

                if(value == 6341) {
                    Age = 7;
                }

            }
        }

        public int Age { get; set; } = 0;

        public BlockCarrots() {
            State = DefaultState;
        }

        public BlockCarrots(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockCarrots(int age) {
            Age = age;
        }
    }
}