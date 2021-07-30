// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockMelonStem : BlockBase {

        public override string Id { get { return "minecraft:melon_stem"; } }

        public override ushort MinimumState { get { return 4784; } }
        public override ushort MaximumState { get { return 4791; } }
        public override ushort DefaultState { get { return 4784; } }

        public override ushort State {
            get {
                if(Age == 0) {
                    return 4784;
                }

                if(Age == 1) {
                    return 4785;
                }

                if(Age == 2) {
                    return 4786;
                }

                if(Age == 3) {
                    return 4787;
                }

                if(Age == 4) {
                    return 4788;
                }

                if(Age == 5) {
                    return 4789;
                }

                if(Age == 6) {
                    return 4790;
                }

                if(Age == 7) {
                    return 4791;
                }

                return DefaultState;
            }

            set {
                if(value == 4784) {
                    Age = 0;
                }

                if(value == 4785) {
                    Age = 1;
                }

                if(value == 4786) {
                    Age = 2;
                }

                if(value == 4787) {
                    Age = 3;
                }

                if(value == 4788) {
                    Age = 4;
                }

                if(value == 4789) {
                    Age = 5;
                }

                if(value == 4790) {
                    Age = 6;
                }

                if(value == 4791) {
                    Age = 7;
                }

            }
        }

        public int Age { get; set; } = 0;

        public BlockMelonStem() {
            State = DefaultState;
        }

        public BlockMelonStem(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockMelonStem(int age) {
            Age = age;
        }
    }
}