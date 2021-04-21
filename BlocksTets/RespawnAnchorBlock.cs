// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class RespawnAnchorBlock : BaseBlock {

        public int Charges { get; }

        public RespawnAnchorBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 737, 15837) { }

        public RespawnAnchorBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 737, state) {
            if(state == 15837) {
                Charges = 0;
            } else if(state == 15838) {
                Charges = 1;
            } else if(state == 15839) {
                Charges = 2;
            } else if(state == 15840) {
                Charges = 3;
            } else if(state == 15841) {
                Charges = 4;
            }
        }

        public RespawnAnchorBlock(Chunk chunk, int x, int y, int z, int charges) : base(chunk, x, y, z, 737, 15837) {
if(charges == 0) {
                State = 15837;
            } else if(charges == 1) {
                State = 15838;
            } else if(charges == 2) {
                State = 15839;
            } else if(charges == 3) {
                State = 15840;
            } else if(charges == 4) {
                State = 15841;
            }
        }
    }
}
