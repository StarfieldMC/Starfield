// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    [Block("minecraft:jukebox", 190, 3964, 3965, 3965)]
    public class BlockJukebox : BlockBase {

        public override ushort State {
            get {
                if(HasRecord == true) {
                    return 3964;
                }

                if(HasRecord == false) {
                    return 3965;
                }

                return DefaultState;
            }

            set {
                if(value == 3964) {
                    HasRecord = true;
                }

                if(value == 3965) {
                    HasRecord = false;
                }

            }
        }

        public bool HasRecord { get; set; } = false;

        public BlockJukebox() {
            State = DefaultState;
        }

        public BlockJukebox(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockJukebox(bool has_record) {
            HasRecord = has_record;
        }
    }
}