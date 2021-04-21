// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class CommandBlockBlock : BaseBlock {

        public bool Conditional { get; }
        public Face Facing { get; }

        public CommandBlockBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 277, 5654) { }

        public CommandBlockBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 277, state) {
            if(state == 5648) {
                Conditional = true;
                Facing = Face.North;
            } else if(state == 5649) {
                Conditional = true;
                Facing = Face.East;
            } else if(state == 5650) {
                Conditional = true;
                Facing = Face.South;
            } else if(state == 5651) {
                Conditional = true;
                Facing = Face.West;
            } else if(state == 5652) {
                Conditional = true;
                Facing = Face.Up;
            } else if(state == 5653) {
                Conditional = true;
                Facing = Face.Down;
            } else if(state == 5654) {
                Conditional = false;
                Facing = Face.North;
            } else if(state == 5655) {
                Conditional = false;
                Facing = Face.East;
            } else if(state == 5656) {
                Conditional = false;
                Facing = Face.South;
            } else if(state == 5657) {
                Conditional = false;
                Facing = Face.West;
            } else if(state == 5658) {
                Conditional = false;
                Facing = Face.Up;
            } else if(state == 5659) {
                Conditional = false;
                Facing = Face.Down;
            }
        }

        public CommandBlockBlock(Chunk chunk, int x, int y, int z, bool conditional, Face facing) : base(chunk, x, y, z, 277, 5654) {
if(conditional == true && facing == Face.North) {
                State = 5648;
            } else if(conditional == true && facing == Face.East) {
                State = 5649;
            } else if(conditional == true && facing == Face.South) {
                State = 5650;
            } else if(conditional == true && facing == Face.West) {
                State = 5651;
            } else if(conditional == true && facing == Face.Up) {
                State = 5652;
            } else if(conditional == true && facing == Face.Down) {
                State = 5653;
            } else if(conditional == false && facing == Face.North) {
                State = 5654;
            } else if(conditional == false && facing == Face.East) {
                State = 5655;
            } else if(conditional == false && facing == Face.South) {
                State = 5656;
            } else if(conditional == false && facing == Face.West) {
                State = 5657;
            } else if(conditional == false && facing == Face.Up) {
                State = 5658;
            } else if(conditional == false && facing == Face.Down) {
                State = 5659;
            }
        }
    }
}
