// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class StrippedCrimsonHyphaeBlock : BaseBlock {

        public Axis Axis { get; }

        public StrippedCrimsonHyphaeBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 695, 14993) { }

        public StrippedCrimsonHyphaeBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 695, state) {
            if(state == 14992) {
                Axis = Axis.X;
            } else if(state == 14993) {
                Axis = Axis.Y;
            } else if(state == 14994) {
                Axis = Axis.Z;
            }
        }

        public StrippedCrimsonHyphaeBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 695, 14993) {
if(axis == Axis.X) {
                State = 14992;
            } else if(axis == Axis.Y) {
                State = 14993;
            } else if(axis == Axis.Z) {
                State = 14994;
            }
        }
    }
}
