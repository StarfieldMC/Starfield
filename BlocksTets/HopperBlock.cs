// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class HopperBlock : BaseBlock {

        public bool Enabled { get; }
        public Face Facing { get; }

        public HopperBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 336, 6732) { }

        public HopperBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 336, state) {
            if(state == 6732) {
                Enabled = true;
                Facing = Face.Down;
            } else if(state == 6733) {
                Enabled = true;
                Facing = Face.North;
            } else if(state == 6734) {
                Enabled = true;
                Facing = Face.South;
            } else if(state == 6735) {
                Enabled = true;
                Facing = Face.West;
            } else if(state == 6736) {
                Enabled = true;
                Facing = Face.East;
            } else if(state == 6737) {
                Enabled = false;
                Facing = Face.Down;
            } else if(state == 6738) {
                Enabled = false;
                Facing = Face.North;
            } else if(state == 6739) {
                Enabled = false;
                Facing = Face.South;
            } else if(state == 6740) {
                Enabled = false;
                Facing = Face.West;
            } else if(state == 6741) {
                Enabled = false;
                Facing = Face.East;
            }
        }

        public HopperBlock(Chunk chunk, int x, int y, int z, bool enabled, Face facing) : base(chunk, x, y, z, 336, 6732) {
if(enabled == true && facing == Face.Down) {
                State = 6732;
            } else if(enabled == true && facing == Face.North) {
                State = 6733;
            } else if(enabled == true && facing == Face.South) {
                State = 6734;
            } else if(enabled == true && facing == Face.West) {
                State = 6735;
            } else if(enabled == true && facing == Face.East) {
                State = 6736;
            } else if(enabled == false && facing == Face.Down) {
                State = 6737;
            } else if(enabled == false && facing == Face.North) {
                State = 6738;
            } else if(enabled == false && facing == Face.South) {
                State = 6739;
            } else if(enabled == false && facing == Face.West) {
                State = 6740;
            } else if(enabled == false && facing == Face.East) {
                State = 6741;
            }
        }
    }
}
