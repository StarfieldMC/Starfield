// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class AcaciaLogBlock : BaseBlock {

        public Axis Axis { get; }

        public AcaciaLogBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 39, 86) { }

        public AcaciaLogBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 39, state) {
            if(state == 85) {
                Axis = Axis.X;
            } else if(state == 86) {
                Axis = Axis.Y;
            } else if(state == 87) {
                Axis = Axis.Z;
            }
        }

        public AcaciaLogBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 39, 86) {
if(axis == Axis.X) {
                State = 85;
            } else if(axis == Axis.Y) {
                State = 86;
            } else if(axis == Axis.Z) {
                State = 87;
            }
        }
    }
}
