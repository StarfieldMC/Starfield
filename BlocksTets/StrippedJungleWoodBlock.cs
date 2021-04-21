// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class StrippedJungleWoodBlock : BaseBlock {

        public Axis Axis { get; }

        public StrippedJungleWoodBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 56, 137) { }

        public StrippedJungleWoodBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 56, state) {
            if(state == 136) {
                Axis = Axis.X;
            } else if(state == 137) {
                Axis = Axis.Y;
            } else if(state == 138) {
                Axis = Axis.Z;
            }
        }

        public StrippedJungleWoodBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 56, 137) {
if(axis == Axis.X) {
                State = 136;
            } else if(axis == Axis.Y) {
                State = 137;
            } else if(axis == Axis.Z) {
                State = 138;
            }
        }
    }
}
