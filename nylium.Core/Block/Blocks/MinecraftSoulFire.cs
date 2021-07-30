// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockSoulFire : BlockBase {

        public override string Id { get { return "minecraft:soul_fire"; } }

        public override ushort MinimumState { get { return 1952; } }
        public override ushort MaximumState { get { return 1952; } }
        public override ushort DefaultState { get { return 1952; } }

        public override ushort State {
            get {
                return DefaultState;
            }

            set {
            }
        }


        public BlockSoulFire() {
            State = DefaultState;
        }

        public BlockSoulFire(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }
    }
}