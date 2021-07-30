// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockMycelium : BlockBase {

        public override string Id { get { return "minecraft:mycelium"; } }

        public override ushort MinimumState { get { return 5016; } }
        public override ushort MaximumState { get { return 5017; } }
        public override ushort DefaultState { get { return 5017; } }

        public override ushort State {
            get {
                if(Snowy == true) {
                    return 5016;
                }

                if(Snowy == false) {
                    return 5017;
                }

                return DefaultState;
            }

            set {
                if(value == 5016) {
                    Snowy = true;
                }

                if(value == 5017) {
                    Snowy = false;
                }

            }
        }

        public bool Snowy { get; set; } = false;

        public BlockMycelium() {
            State = DefaultState;
        }

        public BlockMycelium(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockMycelium(bool snowy) {
            Snowy = snowy;
        }
    }
}