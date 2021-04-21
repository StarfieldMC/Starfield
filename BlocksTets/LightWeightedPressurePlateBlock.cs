// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class LightWeightedPressurePlateBlock : BaseBlock {

        public int Power { get; }

        public LightWeightedPressurePlateBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 330, 6650) { }

        public LightWeightedPressurePlateBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 330, state) {
            if(state == 6650) {
                Power = 0;
            } else if(state == 6651) {
                Power = 1;
            } else if(state == 6652) {
                Power = 2;
            } else if(state == 6653) {
                Power = 3;
            } else if(state == 6654) {
                Power = 4;
            } else if(state == 6655) {
                Power = 5;
            } else if(state == 6656) {
                Power = 6;
            } else if(state == 6657) {
                Power = 7;
            } else if(state == 6658) {
                Power = 8;
            } else if(state == 6659) {
                Power = 9;
            } else if(state == 6660) {
                Power = 10;
            } else if(state == 6661) {
                Power = 11;
            } else if(state == 6662) {
                Power = 12;
            } else if(state == 6663) {
                Power = 13;
            } else if(state == 6664) {
                Power = 14;
            } else if(state == 6665) {
                Power = 15;
            }
        }

        public LightWeightedPressurePlateBlock(Chunk chunk, int x, int y, int z, int power) : base(chunk, x, y, z, 330, 6650) {
if(power == 0) {
                State = 6650;
            } else if(power == 1) {
                State = 6651;
            } else if(power == 2) {
                State = 6652;
            } else if(power == 3) {
                State = 6653;
            } else if(power == 4) {
                State = 6654;
            } else if(power == 5) {
                State = 6655;
            } else if(power == 6) {
                State = 6656;
            } else if(power == 7) {
                State = 6657;
            } else if(power == 8) {
                State = 6658;
            } else if(power == 9) {
                State = 6659;
            } else if(power == 10) {
                State = 6660;
            } else if(power == 11) {
                State = 6661;
            } else if(power == 12) {
                State = 6662;
            } else if(power == 13) {
                State = 6663;
            } else if(power == 14) {
                State = 6664;
            } else if(power == 15) {
                State = 6665;
            }
        }
    }
}
