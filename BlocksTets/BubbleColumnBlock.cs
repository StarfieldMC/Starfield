// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class BubbleColumnBlock : BaseBlock {

        public bool Drag { get; }

        public BubbleColumnBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 626, 9671) { }

        public BubbleColumnBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 626, state) {
            if(state == 9671) {
                Drag = true;
            } else if(state == 9672) {
                Drag = false;
            }
        }

        public BubbleColumnBlock(Chunk chunk, int x, int y, int z, bool drag) : base(chunk, x, y, z, 626, 9671) {
if(drag == true) {
                State = 9671;
            } else if(drag == false) {
                State = 9672;
            }
        }
    }
}
