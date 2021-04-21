// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class StrippedJungleLogBlock : BaseBlock {

        public Axis Axis { get; }

        public StrippedJungleLogBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 43, 98) { }

        public StrippedJungleLogBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 43, state) {
            if(state == 97) {
                Axis = Axis.X;
            } else if(state == 98) {
                Axis = Axis.Y;
            } else if(state == 99) {
                Axis = Axis.Z;
            }
        }

        public StrippedJungleLogBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 43, 98) {
if(axis == Axis.X) {
                State = 97;
            } else if(axis == Axis.Y) {
                State = 98;
            } else if(axis == Axis.Z) {
                State = 99;
            }
        }
    }
}
