// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class SpruceWoodBlock : BaseBlock {

        public Axis Axis { get; }

        public SpruceWoodBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 48, 113) { }

        public SpruceWoodBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 48, state) {
            if(state == 112) {
                Axis = Axis.X;
            } else if(state == 113) {
                Axis = Axis.Y;
            } else if(state == 114) {
                Axis = Axis.Z;
            }
        }

        public SpruceWoodBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 48, 113) {
if(axis == Axis.X) {
                State = 112;
            } else if(axis == Axis.Y) {
                State = 113;
            } else if(axis == Axis.Z) {
                State = 114;
            }
        }
    }
}
