// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockBubbleColumn : BlockBase {

        public override string Id { get { return "minecraft:bubble_column"; } }

        public override ushort MinimumState { get { return 9671; } }
        public override ushort MaximumState { get { return 9672; } }
        public override ushort DefaultState { get { return 9671; } }

        public override ushort State {
            get {
                if(Drag == true) {
                    return 9671;
                }

                if(Drag == false) {
                    return 9672;
                }

                return DefaultState;
            }

            set {
                if(value == 9671) {
                    Drag = true;
                }

                if(value == 9672) {
                    Drag = false;
                }

            }
        }

        public bool Drag { get; set; } = true;

        public BlockBubbleColumn() {
            State = DefaultState;
        }

        public BlockBubbleColumn(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBubbleColumn(bool drag) {
            Drag = drag;
        }
    }
}