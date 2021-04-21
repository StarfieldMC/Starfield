// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class StrippedSpruceLogBlock : BaseBlock {

        public Axis Axis { get; }

        public StrippedSpruceLogBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 41, 92) { }

        public StrippedSpruceLogBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 41, state) {
            if(state == 91) {
                Axis = Axis.X;
            } else if(state == 92) {
                Axis = Axis.Y;
            } else if(state == 93) {
                Axis = Axis.Z;
            }
        }

        public StrippedSpruceLogBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 41, 92) {
if(axis == Axis.X) {
                State = 91;
            } else if(axis == Axis.Y) {
                State = 92;
            } else if(axis == Axis.Z) {
                State = 93;
            }
        }
    }
}
