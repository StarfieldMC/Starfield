// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class StrippedDarkOakWoodBlock : BaseBlock {

        public Axis Axis { get; }

        public StrippedDarkOakWoodBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 58, 143) { }

        public StrippedDarkOakWoodBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 58, state) {
            if(state == 142) {
                Axis = Axis.X;
            } else if(state == 143) {
                Axis = Axis.Y;
            } else if(state == 144) {
                Axis = Axis.Z;
            }
        }

        public StrippedDarkOakWoodBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 58, 143) {
if(axis == Axis.X) {
                State = 142;
            } else if(axis == Axis.Y) {
                State = 143;
            } else if(axis == Axis.Z) {
                State = 144;
            }
        }
    }
}
