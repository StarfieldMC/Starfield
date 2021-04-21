// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class DeadBrainCoralFanBlock : BaseBlock {

        public bool Waterlogged { get; }

        public DeadBrainCoralFanBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 599, 9546) { }

        public DeadBrainCoralFanBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 599, state) {
            if(state == 9546) {
                Waterlogged = true;
            } else if(state == 9547) {
                Waterlogged = false;
            }
        }

        public DeadBrainCoralFanBlock(Chunk chunk, int x, int y, int z, bool waterlogged) : base(chunk, x, y, z, 599, 9546) {
if(waterlogged == true) {
                State = 9546;
            } else if(waterlogged == false) {
                State = 9547;
            }
        }
    }
}
