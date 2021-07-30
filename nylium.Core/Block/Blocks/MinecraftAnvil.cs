// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockAnvil : BlockBase {

        public override string Id { get { return "minecraft:anvil"; } }

        public override ushort MinimumState { get { return 6614; } }
        public override ushort MaximumState { get { return 6617; } }
        public override ushort DefaultState { get { return 6614; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 6614;
                }

                if(Facing == "south") {
                    return 6615;
                }

                if(Facing == "west") {
                    return 6616;
                }

                if(Facing == "east") {
                    return 6617;
                }

                return DefaultState;
            }

            set {
                if(value == 6614) {
                    Facing = "north";
                }

                if(value == 6615) {
                    Facing = "south";
                }

                if(value == 6616) {
                    Facing = "west";
                }

                if(value == 6617) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockAnvil() {
            State = DefaultState;
        }

        public BlockAnvil(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockAnvil(string facing) {
            Facing = facing;
        }
    }
}