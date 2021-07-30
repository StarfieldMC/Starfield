// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockComposter : BlockBase {

        public override string Id { get { return "minecraft:composter"; } }

        public override ushort MinimumState { get { return 15759; } }
        public override ushort MaximumState { get { return 15767; } }
        public override ushort DefaultState { get { return 15759; } }

        public override ushort State {
            get {
                if(Level == 0) {
                    return 15759;
                }

                if(Level == 1) {
                    return 15760;
                }

                if(Level == 2) {
                    return 15761;
                }

                if(Level == 3) {
                    return 15762;
                }

                if(Level == 4) {
                    return 15763;
                }

                if(Level == 5) {
                    return 15764;
                }

                if(Level == 6) {
                    return 15765;
                }

                if(Level == 7) {
                    return 15766;
                }

                if(Level == 8) {
                    return 15767;
                }

                return DefaultState;
            }

            set {
                if(value == 15759) {
                    Level = 0;
                }

                if(value == 15760) {
                    Level = 1;
                }

                if(value == 15761) {
                    Level = 2;
                }

                if(value == 15762) {
                    Level = 3;
                }

                if(value == 15763) {
                    Level = 4;
                }

                if(value == 15764) {
                    Level = 5;
                }

                if(value == 15765) {
                    Level = 6;
                }

                if(value == 15766) {
                    Level = 7;
                }

                if(value == 15767) {
                    Level = 8;
                }

            }
        }

        public int Level { get; set; } = 0;

        public BlockComposter() {
            State = DefaultState;
        }

        public BlockComposter(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockComposter(int level) {
            Level = level;
        }
    }
}