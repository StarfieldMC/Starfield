// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class SkeletonSkullBlock : BaseBlock {

        public int Rotation { get; }

        public SkeletonSkullBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 314, 6494) { }

        public SkeletonSkullBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 314, state) {
            if(state == 6494) {
                Rotation = 0;
            } else if(state == 6495) {
                Rotation = 1;
            } else if(state == 6496) {
                Rotation = 2;
            } else if(state == 6497) {
                Rotation = 3;
            } else if(state == 6498) {
                Rotation = 4;
            } else if(state == 6499) {
                Rotation = 5;
            } else if(state == 6500) {
                Rotation = 6;
            } else if(state == 6501) {
                Rotation = 7;
            } else if(state == 6502) {
                Rotation = 8;
            } else if(state == 6503) {
                Rotation = 9;
            } else if(state == 6504) {
                Rotation = 10;
            } else if(state == 6505) {
                Rotation = 11;
            } else if(state == 6506) {
                Rotation = 12;
            } else if(state == 6507) {
                Rotation = 13;
            } else if(state == 6508) {
                Rotation = 14;
            } else if(state == 6509) {
                Rotation = 15;
            }
        }

        public SkeletonSkullBlock(Chunk chunk, int x, int y, int z, int rotation) : base(chunk, x, y, z, 314, 6494) {
if(rotation == 0) {
                State = 6494;
            } else if(rotation == 1) {
                State = 6495;
            } else if(rotation == 2) {
                State = 6496;
            } else if(rotation == 3) {
                State = 6497;
            } else if(rotation == 4) {
                State = 6498;
            } else if(rotation == 5) {
                State = 6499;
            } else if(rotation == 6) {
                State = 6500;
            } else if(rotation == 7) {
                State = 6501;
            } else if(rotation == 8) {
                State = 6502;
            } else if(rotation == 9) {
                State = 6503;
            } else if(rotation == 10) {
                State = 6504;
            } else if(rotation == 11) {
                State = 6505;
            } else if(rotation == 12) {
                State = 6506;
            } else if(rotation == 13) {
                State = 6507;
            } else if(rotation == 14) {
                State = 6508;
            } else if(rotation == 15) {
                State = 6509;
            }
        }
    }
}
