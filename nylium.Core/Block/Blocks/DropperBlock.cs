// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class DropperBlock : BaseBlock {

        public Face Facing { get; }
        public bool Triggered { get; }

        public DropperBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 342, 6840) { }

        public DropperBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 342, state) {
            if(state == 6839) {
                Facing = Face.North;
                Triggered = true;
            } else if(state == 6840) {
                Facing = Face.North;
                Triggered = false;
            } else if(state == 6841) {
                Facing = Face.East;
                Triggered = true;
            } else if(state == 6842) {
                Facing = Face.East;
                Triggered = false;
            } else if(state == 6843) {
                Facing = Face.South;
                Triggered = true;
            } else if(state == 6844) {
                Facing = Face.South;
                Triggered = false;
            } else if(state == 6845) {
                Facing = Face.West;
                Triggered = true;
            } else if(state == 6846) {
                Facing = Face.West;
                Triggered = false;
            } else if(state == 6847) {
                Facing = Face.Up;
                Triggered = true;
            } else if(state == 6848) {
                Facing = Face.Up;
                Triggered = false;
            } else if(state == 6849) {
                Facing = Face.Down;
                Triggered = true;
            } else if(state == 6850) {
                Facing = Face.Down;
                Triggered = false;
            }
        }

        public DropperBlock(Chunk chunk, int x, int y, int z, Face facing, bool triggered) : base(chunk, x, y, z, 342, 6840) {
if(facing == Face.North && triggered == true) {
                State = 6839;
            } else if(facing == Face.North && triggered == false) {
                State = 6840;
            } else if(facing == Face.East && triggered == true) {
                State = 6841;
            } else if(facing == Face.East && triggered == false) {
                State = 6842;
            } else if(facing == Face.South && triggered == true) {
                State = 6843;
            } else if(facing == Face.South && triggered == false) {
                State = 6844;
            } else if(facing == Face.West && triggered == true) {
                State = 6845;
            } else if(facing == Face.West && triggered == false) {
                State = 6846;
            } else if(facing == Face.Up && triggered == true) {
                State = 6847;
            } else if(facing == Face.Up && triggered == false) {
                State = 6848;
            } else if(facing == Face.Down && triggered == true) {
                State = 6849;
            } else if(facing == Face.Down && triggered == false) {
                State = 6850;
            }
        }
    }
}
