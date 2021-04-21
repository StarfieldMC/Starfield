// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class PolishedBlackstonePressurePlateBlock : BaseBlock {

        public bool Powered { get; }

        public PolishedBlackstonePressurePlateBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 757, 16760) { }

        public PolishedBlackstonePressurePlateBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 757, state) {
            if(state == 16759) {
                Powered = true;
            } else if(state == 16760) {
                Powered = false;
            }
        }

        public PolishedBlackstonePressurePlateBlock(Chunk chunk, int x, int y, int z, bool powered) : base(chunk, x, y, z, 757, 16760) {
if(powered == true) {
                State = 16759;
            } else if(powered == false) {
                State = 16760;
            }
        }
    }
}
