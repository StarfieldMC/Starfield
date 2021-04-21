// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class DeadHornCoralFanBlock : BaseBlock {

        public bool Waterlogged { get; }

        public DeadHornCoralFanBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 602, 9552) { }

        public DeadHornCoralFanBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 602, state) {
            if(state == 9552) {
                Waterlogged = true;
            } else if(state == 9553) {
                Waterlogged = false;
            }
        }

        public DeadHornCoralFanBlock(Chunk chunk, int x, int y, int z, bool waterlogged) : base(chunk, x, y, z, 602, 9552) {
if(waterlogged == true) {
                State = 9552;
            } else if(waterlogged == false) {
                State = 9553;
            }
        }
    }
}
