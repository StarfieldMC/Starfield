// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class JungleSignBlock : BaseBlock {

        public int Rotation { get; }
        public bool Waterlogged { get; }

        public JungleSignBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 159, 3510) { }

        public JungleSignBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 159, state) {
            if(state == 3509) {
                Rotation = 0;
                Waterlogged = true;
            } else if(state == 3510) {
                Rotation = 0;
                Waterlogged = false;
            } else if(state == 3511) {
                Rotation = 1;
                Waterlogged = true;
            } else if(state == 3512) {
                Rotation = 1;
                Waterlogged = false;
            } else if(state == 3513) {
                Rotation = 2;
                Waterlogged = true;
            } else if(state == 3514) {
                Rotation = 2;
                Waterlogged = false;
            } else if(state == 3515) {
                Rotation = 3;
                Waterlogged = true;
            } else if(state == 3516) {
                Rotation = 3;
                Waterlogged = false;
            } else if(state == 3517) {
                Rotation = 4;
                Waterlogged = true;
            } else if(state == 3518) {
                Rotation = 4;
                Waterlogged = false;
            } else if(state == 3519) {
                Rotation = 5;
                Waterlogged = true;
            } else if(state == 3520) {
                Rotation = 5;
                Waterlogged = false;
            } else if(state == 3521) {
                Rotation = 6;
                Waterlogged = true;
            } else if(state == 3522) {
                Rotation = 6;
                Waterlogged = false;
            } else if(state == 3523) {
                Rotation = 7;
                Waterlogged = true;
            } else if(state == 3524) {
                Rotation = 7;
                Waterlogged = false;
            } else if(state == 3525) {
                Rotation = 8;
                Waterlogged = true;
            } else if(state == 3526) {
                Rotation = 8;
                Waterlogged = false;
            } else if(state == 3527) {
                Rotation = 9;
                Waterlogged = true;
            } else if(state == 3528) {
                Rotation = 9;
                Waterlogged = false;
            } else if(state == 3529) {
                Rotation = 10;
                Waterlogged = true;
            } else if(state == 3530) {
                Rotation = 10;
                Waterlogged = false;
            } else if(state == 3531) {
                Rotation = 11;
                Waterlogged = true;
            } else if(state == 3532) {
                Rotation = 11;
                Waterlogged = false;
            } else if(state == 3533) {
                Rotation = 12;
                Waterlogged = true;
            } else if(state == 3534) {
                Rotation = 12;
                Waterlogged = false;
            } else if(state == 3535) {
                Rotation = 13;
                Waterlogged = true;
            } else if(state == 3536) {
                Rotation = 13;
                Waterlogged = false;
            } else if(state == 3537) {
                Rotation = 14;
                Waterlogged = true;
            } else if(state == 3538) {
                Rotation = 14;
                Waterlogged = false;
            } else if(state == 3539) {
                Rotation = 15;
                Waterlogged = true;
            } else if(state == 3540) {
                Rotation = 15;
                Waterlogged = false;
            }
        }

        public JungleSignBlock(Chunk chunk, int x, int y, int z, int rotation, bool waterlogged) : base(chunk, x, y, z, 159, 3510) {
if(rotation == 0 && waterlogged == true) {
                State = 3509;
            } else if(rotation == 0 && waterlogged == false) {
                State = 3510;
            } else if(rotation == 1 && waterlogged == true) {
                State = 3511;
            } else if(rotation == 1 && waterlogged == false) {
                State = 3512;
            } else if(rotation == 2 && waterlogged == true) {
                State = 3513;
            } else if(rotation == 2 && waterlogged == false) {
                State = 3514;
            } else if(rotation == 3 && waterlogged == true) {
                State = 3515;
            } else if(rotation == 3 && waterlogged == false) {
                State = 3516;
            } else if(rotation == 4 && waterlogged == true) {
                State = 3517;
            } else if(rotation == 4 && waterlogged == false) {
                State = 3518;
            } else if(rotation == 5 && waterlogged == true) {
                State = 3519;
            } else if(rotation == 5 && waterlogged == false) {
                State = 3520;
            } else if(rotation == 6 && waterlogged == true) {
                State = 3521;
            } else if(rotation == 6 && waterlogged == false) {
                State = 3522;
            } else if(rotation == 7 && waterlogged == true) {
                State = 3523;
            } else if(rotation == 7 && waterlogged == false) {
                State = 3524;
            } else if(rotation == 8 && waterlogged == true) {
                State = 3525;
            } else if(rotation == 8 && waterlogged == false) {
                State = 3526;
            } else if(rotation == 9 && waterlogged == true) {
                State = 3527;
            } else if(rotation == 9 && waterlogged == false) {
                State = 3528;
            } else if(rotation == 10 && waterlogged == true) {
                State = 3529;
            } else if(rotation == 10 && waterlogged == false) {
                State = 3530;
            } else if(rotation == 11 && waterlogged == true) {
                State = 3531;
            } else if(rotation == 11 && waterlogged == false) {
                State = 3532;
            } else if(rotation == 12 && waterlogged == true) {
                State = 3533;
            } else if(rotation == 12 && waterlogged == false) {
                State = 3534;
            } else if(rotation == 13 && waterlogged == true) {
                State = 3535;
            } else if(rotation == 13 && waterlogged == false) {
                State = 3536;
            } else if(rotation == 14 && waterlogged == true) {
                State = 3537;
            } else if(rotation == 14 && waterlogged == false) {
                State = 3538;
            } else if(rotation == 15 && waterlogged == true) {
                State = 3539;
            } else if(rotation == 15 && waterlogged == false) {
                State = 3540;
            }
        }
    }
}
