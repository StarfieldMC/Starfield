// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class QuartzPillarBlock : BaseBlock {

        public Axis Axis { get; }

        public QuartzPillarBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 339, 6745) { }

        public QuartzPillarBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 339, state) {
            if(state == 6744) {
                Axis = Axis.X;
            } else if(state == 6745) {
                Axis = Axis.Y;
            } else if(state == 6746) {
                Axis = Axis.Z;
            }
        }

        public QuartzPillarBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 339, 6745) {
if(axis == Axis.X) {
                State = 6744;
            } else if(axis == Axis.Y) {
                State = 6745;
            } else if(axis == Axis.Z) {
                State = 6746;
            }
        }
    }
}
