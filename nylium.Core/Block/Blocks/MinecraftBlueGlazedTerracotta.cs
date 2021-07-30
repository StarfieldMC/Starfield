// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBlueGlazedTerracotta : BlockBase {

        public override string Id { get { return "minecraft:blue_glazed_terracotta"; } }

        public override ushort MinimumState { get { return 9422; } }
        public override ushort MaximumState { get { return 9425; } }
        public override ushort DefaultState { get { return 9422; } }

        public override ushort State {
            get {
                if(Facing == "north") {
                    return 9422;
                }

                if(Facing == "south") {
                    return 9423;
                }

                if(Facing == "west") {
                    return 9424;
                }

                if(Facing == "east") {
                    return 9425;
                }

                return DefaultState;
            }

            set {
                if(value == 9422) {
                    Facing = "north";
                }

                if(value == 9423) {
                    Facing = "south";
                }

                if(value == 9424) {
                    Facing = "west";
                }

                if(value == 9425) {
                    Facing = "east";
                }

            }
        }

        public string Facing { get; set; } = "north";

        public BlockBlueGlazedTerracotta() {
            State = DefaultState;
        }

        public BlockBlueGlazedTerracotta(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBlueGlazedTerracotta(string facing) {
            Facing = facing;
        }
    }
}