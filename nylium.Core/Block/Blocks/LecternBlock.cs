// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class LecternBlock : BaseBlock {

        public Face Facing { get; }
        public bool Has_Book { get; }
        public bool Powered { get; }

        public LecternBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 674, 14840) { }

        public LecternBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 674, state) {
            if(state == 14837) {
                Facing = Face.North;
                Has_Book = true;
                Powered = true;
            } else if(state == 14838) {
                Facing = Face.North;
                Has_Book = true;
                Powered = false;
            } else if(state == 14839) {
                Facing = Face.North;
                Has_Book = false;
                Powered = true;
            } else if(state == 14840) {
                Facing = Face.North;
                Has_Book = false;
                Powered = false;
            } else if(state == 14841) {
                Facing = Face.South;
                Has_Book = true;
                Powered = true;
            } else if(state == 14842) {
                Facing = Face.South;
                Has_Book = true;
                Powered = false;
            } else if(state == 14843) {
                Facing = Face.South;
                Has_Book = false;
                Powered = true;
            } else if(state == 14844) {
                Facing = Face.South;
                Has_Book = false;
                Powered = false;
            } else if(state == 14845) {
                Facing = Face.West;
                Has_Book = true;
                Powered = true;
            } else if(state == 14846) {
                Facing = Face.West;
                Has_Book = true;
                Powered = false;
            } else if(state == 14847) {
                Facing = Face.West;
                Has_Book = false;
                Powered = true;
            } else if(state == 14848) {
                Facing = Face.West;
                Has_Book = false;
                Powered = false;
            } else if(state == 14849) {
                Facing = Face.East;
                Has_Book = true;
                Powered = true;
            } else if(state == 14850) {
                Facing = Face.East;
                Has_Book = true;
                Powered = false;
            } else if(state == 14851) {
                Facing = Face.East;
                Has_Book = false;
                Powered = true;
            } else if(state == 14852) {
                Facing = Face.East;
                Has_Book = false;
                Powered = false;
            }
        }

        public LecternBlock(Chunk chunk, int x, int y, int z, Face facing, bool has_book, bool powered) : base(chunk, x, y, z, 674, 14840) {
if(facing == Face.North && has_book == true && powered == true) {
                State = 14837;
            } else if(facing == Face.North && has_book == true && powered == false) {
                State = 14838;
            } else if(facing == Face.North && has_book == false && powered == true) {
                State = 14839;
            } else if(facing == Face.North && has_book == false && powered == false) {
                State = 14840;
            } else if(facing == Face.South && has_book == true && powered == true) {
                State = 14841;
            } else if(facing == Face.South && has_book == true && powered == false) {
                State = 14842;
            } else if(facing == Face.South && has_book == false && powered == true) {
                State = 14843;
            } else if(facing == Face.South && has_book == false && powered == false) {
                State = 14844;
            } else if(facing == Face.West && has_book == true && powered == true) {
                State = 14845;
            } else if(facing == Face.West && has_book == true && powered == false) {
                State = 14846;
            } else if(facing == Face.West && has_book == false && powered == true) {
                State = 14847;
            } else if(facing == Face.West && has_book == false && powered == false) {
                State = 14848;
            } else if(facing == Face.East && has_book == true && powered == true) {
                State = 14849;
            } else if(facing == Face.East && has_book == true && powered == false) {
                State = 14850;
            } else if(facing == Face.East && has_book == false && powered == true) {
                State = 14851;
            } else if(facing == Face.East && has_book == false && powered == false) {
                State = 14852;
            }
        }
    }
}
