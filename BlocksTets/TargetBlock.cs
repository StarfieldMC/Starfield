// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class TargetBlock : BaseBlock {

        public int Power { get; }

        public TargetBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 729, 15768) { }

        public TargetBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 729, state) {
            if(state == 15768) {
                Power = 0;
            } else if(state == 15769) {
                Power = 1;
            } else if(state == 15770) {
                Power = 2;
            } else if(state == 15771) {
                Power = 3;
            } else if(state == 15772) {
                Power = 4;
            } else if(state == 15773) {
                Power = 5;
            } else if(state == 15774) {
                Power = 6;
            } else if(state == 15775) {
                Power = 7;
            } else if(state == 15776) {
                Power = 8;
            } else if(state == 15777) {
                Power = 9;
            } else if(state == 15778) {
                Power = 10;
            } else if(state == 15779) {
                Power = 11;
            } else if(state == 15780) {
                Power = 12;
            } else if(state == 15781) {
                Power = 13;
            } else if(state == 15782) {
                Power = 14;
            } else if(state == 15783) {
                Power = 15;
            }
        }

        public TargetBlock(Chunk chunk, int x, int y, int z, int power) : base(chunk, x, y, z, 729, 15768) {
if(power == 0) {
                State = 15768;
            } else if(power == 1) {
                State = 15769;
            } else if(power == 2) {
                State = 15770;
            } else if(power == 3) {
                State = 15771;
            } else if(power == 4) {
                State = 15772;
            } else if(power == 5) {
                State = 15773;
            } else if(power == 6) {
                State = 15774;
            } else if(power == 7) {
                State = 15775;
            } else if(power == 8) {
                State = 15776;
            } else if(power == 9) {
                State = 15777;
            } else if(power == 10) {
                State = 15778;
            } else if(power == 11) {
                State = 15779;
            } else if(power == 12) {
                State = 15780;
            } else if(power == 13) {
                State = 15781;
            } else if(power == 14) {
                State = 15782;
            } else if(power == 15) {
                State = 15783;
            }
        }
    }
}
