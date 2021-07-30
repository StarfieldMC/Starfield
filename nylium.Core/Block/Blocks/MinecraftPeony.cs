// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockPeony : BlockBase {

        public override string Id { get { return "minecraft:peony"; } }

        public override ushort MinimumState { get { return 7895; } }
        public override ushort MaximumState { get { return 7896; } }
        public override ushort DefaultState { get { return 7896; } }

        public override ushort State {
            get {
                if(Half == "upper") {
                    return 7895;
                }

                if(Half == "lower") {
                    return 7896;
                }

                return DefaultState;
            }

            set {
                if(value == 7895) {
                    Half = "upper";
                }

                if(value == 7896) {
                    Half = "lower";
                }

            }
        }

        public string Half { get; set; } = "lower";

        public BlockPeony() {
            State = DefaultState;
        }

        public BlockPeony(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockPeony(string half) {
            Half = half;
        }
    }
}