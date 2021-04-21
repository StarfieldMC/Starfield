// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class ComparatorBlock : BaseBlock {

        public Face Facing { get; }
        public bool Powered { get; }

        public ComparatorBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 332, 6683) { }

        public ComparatorBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 332, state) {
            if(state == 6682) {
                Facing = Face.North;
                Powered = true;
            } else if(state == 6683) {
                Facing = Face.North;
                Powered = false;
            } else if(state == 6684) {
                Facing = Face.North;
                Powered = true;
            } else if(state == 6685) {
                Facing = Face.North;
                Powered = false;
            } else if(state == 6686) {
                Facing = Face.South;
                Powered = true;
            } else if(state == 6687) {
                Facing = Face.South;
                Powered = false;
            } else if(state == 6688) {
                Facing = Face.South;
                Powered = true;
            } else if(state == 6689) {
                Facing = Face.South;
                Powered = false;
            } else if(state == 6690) {
                Facing = Face.West;
                Powered = true;
            } else if(state == 6691) {
                Facing = Face.West;
                Powered = false;
            } else if(state == 6692) {
                Facing = Face.West;
                Powered = true;
            } else if(state == 6693) {
                Facing = Face.West;
                Powered = false;
            } else if(state == 6694) {
                Facing = Face.East;
                Powered = true;
            } else if(state == 6695) {
                Facing = Face.East;
                Powered = false;
            } else if(state == 6696) {
                Facing = Face.East;
                Powered = true;
            } else if(state == 6697) {
                Facing = Face.East;
                Powered = false;
            }
        }

        public ComparatorBlock(Chunk chunk, int x, int y, int z, Face facing, bool powered) : base(chunk, x, y, z, 332, 6683) {
if(facing == Face.North && powered == true) {
                State = 6682;
            } else if(facing == Face.North && powered == false) {
                State = 6683;
            } else if(facing == Face.North && powered == true) {
                State = 6684;
            } else if(facing == Face.North && powered == false) {
                State = 6685;
            } else if(facing == Face.South && powered == true) {
                State = 6686;
            } else if(facing == Face.South && powered == false) {
                State = 6687;
            } else if(facing == Face.South && powered == true) {
                State = 6688;
            } else if(facing == Face.South && powered == false) {
                State = 6689;
            } else if(facing == Face.West && powered == true) {
                State = 6690;
            } else if(facing == Face.West && powered == false) {
                State = 6691;
            } else if(facing == Face.West && powered == true) {
                State = 6692;
            } else if(facing == Face.West && powered == false) {
                State = 6693;
            } else if(facing == Face.East && powered == true) {
                State = 6694;
            } else if(facing == Face.East && powered == false) {
                State = 6695;
            } else if(facing == Face.East && powered == true) {
                State = 6696;
            } else if(facing == Face.East && powered == false) {
                State = 6697;
            }
        }
    }
}
