// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBlackGlazedTerracotta : BlockBase {

        public override string Id { get { return "minecraft:black_glazed_terracotta"; } }

        public override ushort MinimumState { get { return 9438; } }
        public override ushort MaximumState { get { return 9441; } }
        public override ushort DefaultState { get { return 9438; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9438;
                }

                if(Facing == "south") {
                    return 9439;
                }

                if(Facing == "west") {
                    return 9440;
                }

                if(Facing == "east") {
                    return 9441;
                }

                return DefaultState;
            }

            set {
                if(value == 9438) {
                    Facing = "north";
                }

                if(value == 9439) {
                    Facing = "south";
                }

                if(value == 9440) {
                    Facing = "west";
                }

                if(value == 9441) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockBlackGlazedTerracotta() {
            State = DefaultState;
        }

        public BlockBlackGlazedTerracotta(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBlackGlazedTerracotta(string facing) {
            Facing = facing;
        }
    }
}