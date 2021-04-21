// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class DeadTubeCoralFanBlock : BaseBlock {

        public bool Waterlogged { get; }

        public DeadTubeCoralFanBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 598, 9544) { }

        public DeadTubeCoralFanBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 598, state) {
            if(state == 9544) {
                Waterlogged = true;
            } else if(state == 9545) {
                Waterlogged = false;
            }
        }

        public DeadTubeCoralFanBlock(Chunk chunk, int x, int y, int z, bool waterlogged) : base(chunk, x, y, z, 598, 9544) {
if(waterlogged == true) {
                State = 9544;
            } else if(waterlogged == false) {
                State = 9545;
            }
        }
    }
}
