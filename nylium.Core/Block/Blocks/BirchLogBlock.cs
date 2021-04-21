// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class BirchLogBlock : BaseBlock {

        public Axis Axis { get; }

        public BirchLogBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 37, 80) { }

        public BirchLogBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 37, state) {
            if(state == 79) {
                Axis = Axis.X;
            } else if(state == 80) {
                Axis = Axis.Y;
            } else if(state == 81) {
                Axis = Axis.Z;
            }
        }

        public BirchLogBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 37, 80) {
if(axis == Axis.X) {
                State = 79;
            } else if(axis == Axis.Y) {
                State = 80;
            } else if(axis == Axis.Z) {
                State = 81;
            }
        }
    }
}
