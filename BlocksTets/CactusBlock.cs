// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class CactusBlock : BaseBlock {

        public int Age { get; }

        public CactusBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 187, 3931) { }

        public CactusBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 187, state) {
            if(state == 3931) {
                Age = 0;
            } else if(state == 3932) {
                Age = 1;
            } else if(state == 3933) {
                Age = 2;
            } else if(state == 3934) {
                Age = 3;
            } else if(state == 3935) {
                Age = 4;
            } else if(state == 3936) {
                Age = 5;
            } else if(state == 3937) {
                Age = 6;
            } else if(state == 3938) {
                Age = 7;
            } else if(state == 3939) {
                Age = 8;
            } else if(state == 3940) {
                Age = 9;
            } else if(state == 3941) {
                Age = 10;
            } else if(state == 3942) {
                Age = 11;
            } else if(state == 3943) {
                Age = 12;
            } else if(state == 3944) {
                Age = 13;
            } else if(state == 3945) {
                Age = 14;
            } else if(state == 3946) {
                Age = 15;
            }
        }

        public CactusBlock(Chunk chunk, int x, int y, int z, int age) : base(chunk, x, y, z, 187, 3931) {
if(age == 0) {
                State = 3931;
            } else if(age == 1) {
                State = 3932;
            } else if(age == 2) {
                State = 3933;
            } else if(age == 3) {
                State = 3934;
            } else if(age == 4) {
                State = 3935;
            } else if(age == 5) {
                State = 3936;
            } else if(age == 6) {
                State = 3937;
            } else if(age == 7) {
                State = 3938;
            } else if(age == 8) {
                State = 3939;
            } else if(age == 9) {
                State = 3940;
            } else if(age == 10) {
                State = 3941;
            } else if(age == 11) {
                State = 3942;
            } else if(age == 12) {
                State = 3943;
            } else if(age == 13) {
                State = 3944;
            } else if(age == 14) {
                State = 3945;
            } else if(age == 15) {
                State = 3946;
            }
        }
    }
}
