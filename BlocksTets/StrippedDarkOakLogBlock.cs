// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class StrippedDarkOakLogBlock : BaseBlock {

        public Axis Axis { get; }

        public StrippedDarkOakLogBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 45, 104) { }

        public StrippedDarkOakLogBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 45, state) {
            if(state == 103) {
                Axis = Axis.X;
            } else if(state == 104) {
                Axis = Axis.Y;
            } else if(state == 105) {
                Axis = Axis.Z;
            }
        }

        public StrippedDarkOakLogBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 45, 104) {
if(axis == Axis.X) {
                State = 103;
            } else if(axis == Axis.Y) {
                State = 104;
            } else if(axis == Axis.Z) {
                State = 105;
            }
        }
    }
}
