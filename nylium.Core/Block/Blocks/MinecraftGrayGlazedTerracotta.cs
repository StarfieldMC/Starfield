// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockGrayGlazedTerracotta : BlockBase {

        public override string Id { get { return "minecraft:gray_glazed_terracotta"; } }

        public override ushort MinimumState { get { return 9406; } }
        public override ushort MaximumState { get { return 9409; } }
        public override ushort DefaultState { get { return 9406; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9406;
                }

                if(Facing == "south") {
                    return 9407;
                }

                if(Facing == "west") {
                    return 9408;
                }

                if(Facing == "east") {
                    return 9409;
                }

                return DefaultState;
            }

            set {
                if(value == 9406) {
                    Facing = "north";
                }

                if(value == 9407) {
                    Facing = "south";
                }

                if(value == 9408) {
                    Facing = "west";
                }

                if(value == 9409) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockGrayGlazedTerracotta() {
            State = DefaultState;
        }

        public BlockGrayGlazedTerracotta(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockGrayGlazedTerracotta(string facing) {
            Facing = facing;
        }
    }
}