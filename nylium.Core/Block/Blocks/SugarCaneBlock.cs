// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class SugarCaneBlock : BaseBlock {

        public int Age { get; }

        public SugarCaneBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 189, 3948) { }

        public SugarCaneBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 189, state) {
            if(state == 3948) {
                Age = 0;
            } else if(state == 3949) {
                Age = 1;
            } else if(state == 3950) {
                Age = 2;
            } else if(state == 3951) {
                Age = 3;
            } else if(state == 3952) {
                Age = 4;
            } else if(state == 3953) {
                Age = 5;
            } else if(state == 3954) {
                Age = 6;
            } else if(state == 3955) {
                Age = 7;
            } else if(state == 3956) {
                Age = 8;
            } else if(state == 3957) {
                Age = 9;
            } else if(state == 3958) {
                Age = 10;
            } else if(state == 3959) {
                Age = 11;
            } else if(state == 3960) {
                Age = 12;
            } else if(state == 3961) {
                Age = 13;
            } else if(state == 3962) {
                Age = 14;
            } else if(state == 3963) {
                Age = 15;
            }
        }

        public SugarCaneBlock(Chunk chunk, int x, int y, int z, int age) : base(chunk, x, y, z, 189, 3948) {
if(age == 0) {
                State = 3948;
            } else if(age == 1) {
                State = 3949;
            } else if(age == 2) {
                State = 3950;
            } else if(age == 3) {
                State = 3951;
            } else if(age == 4) {
                State = 3952;
            } else if(age == 5) {
                State = 3953;
            } else if(age == 6) {
                State = 3954;
            } else if(age == 7) {
                State = 3955;
            } else if(age == 8) {
                State = 3956;
            } else if(age == 9) {
                State = 3957;
            } else if(age == 10) {
                State = 3958;
            } else if(age == 11) {
                State = 3959;
            } else if(age == 12) {
                State = 3960;
            } else if(age == 13) {
                State = 3961;
            } else if(age == 14) {
                State = 3962;
            } else if(age == 15) {
                State = 3963;
            }
        }
    }
}
