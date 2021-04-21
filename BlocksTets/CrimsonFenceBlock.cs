// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class CrimsonFenceBlock : BaseBlock {

        public bool East { get; }
        public bool North { get; }
        public bool South { get; }
        public bool Waterlogged { get; }
        public bool West { get; }

        public CrimsonFenceBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 710, 15102) { }

        public CrimsonFenceBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 710, state) {
            if(state == 15071) {
                East = true;
                North = true;
                South = true;
                Waterlogged = true;
                West = true;
            } else if(state == 15072) {
                East = true;
                North = true;
                South = true;
                Waterlogged = true;
                West = false;
            } else if(state == 15073) {
                East = true;
                North = true;
                South = true;
                Waterlogged = false;
                West = true;
            } else if(state == 15074) {
                East = true;
                North = true;
                South = true;
                Waterlogged = false;
                West = false;
            } else if(state == 15075) {
                East = true;
                North = true;
                South = false;
                Waterlogged = true;
                West = true;
            } else if(state == 15076) {
                East = true;
                North = true;
                South = false;
                Waterlogged = true;
                West = false;
            } else if(state == 15077) {
                East = true;
                North = true;
                South = false;
                Waterlogged = false;
                West = true;
            } else if(state == 15078) {
                East = true;
                North = true;
                South = false;
                Waterlogged = false;
                West = false;
            } else if(state == 15079) {
                East = true;
                North = false;
                South = true;
                Waterlogged = true;
                West = true;
            } else if(state == 15080) {
                East = true;
                North = false;
                South = true;
                Waterlogged = true;
                West = false;
            } else if(state == 15081) {
                East = true;
                North = false;
                South = true;
                Waterlogged = false;
                West = true;
            } else if(state == 15082) {
                East = true;
                North = false;
                South = true;
                Waterlogged = false;
                West = false;
            } else if(state == 15083) {
                East = true;
                North = false;
                South = false;
                Waterlogged = true;
                West = true;
            } else if(state == 15084) {
                East = true;
                North = false;
                South = false;
                Waterlogged = true;
                West = false;
            } else if(state == 15085) {
                East = true;
                North = false;
                South = false;
                Waterlogged = false;
                West = true;
            } else if(state == 15086) {
                East = true;
                North = false;
                South = false;
                Waterlogged = false;
                West = false;
            } else if(state == 15087) {
                East = false;
                North = true;
                South = true;
                Waterlogged = true;
                West = true;
            } else if(state == 15088) {
                East = false;
                North = true;
                South = true;
                Waterlogged = true;
                West = false;
            } else if(state == 15089) {
                East = false;
                North = true;
                South = true;
                Waterlogged = false;
                West = true;
            } else if(state == 15090) {
                East = false;
                North = true;
                South = true;
                Waterlogged = false;
                West = false;
            } else if(state == 15091) {
                East = false;
                North = true;
                South = false;
                Waterlogged = true;
                West = true;
            } else if(state == 15092) {
                East = false;
                North = true;
                South = false;
                Waterlogged = true;
                West = false;
            } else if(state == 15093) {
                East = false;
                North = true;
                South = false;
                Waterlogged = false;
                West = true;
            } else if(state == 15094) {
                East = false;
                North = true;
                South = false;
                Waterlogged = false;
                West = false;
            } else if(state == 15095) {
                East = false;
                North = false;
                South = true;
                Waterlogged = true;
                West = true;
            } else if(state == 15096) {
                East = false;
                North = false;
                South = true;
                Waterlogged = true;
                West = false;
            } else if(state == 15097) {
                East = false;
                North = false;
                South = true;
                Waterlogged = false;
                West = true;
            } else if(state == 15098) {
                East = false;
                North = false;
                South = true;
                Waterlogged = false;
                West = false;
            } else if(state == 15099) {
                East = false;
                North = false;
                South = false;
                Waterlogged = true;
                West = true;
            } else if(state == 15100) {
                East = false;
                North = false;
                South = false;
                Waterlogged = true;
                West = false;
            } else if(state == 15101) {
                East = false;
                North = false;
                South = false;
                Waterlogged = false;
                West = true;
            } else if(state == 15102) {
                East = false;
                North = false;
                South = false;
                Waterlogged = false;
                West = false;
            }
        }

        public CrimsonFenceBlock(Chunk chunk, int x, int y, int z, bool east, bool north, bool south, bool waterlogged, bool west) : base(chunk, x, y, z, 710, 15102) {
if(east == true && north == true && south == true && waterlogged == true && west == true) {
                State = 15071;
            } else if(east == true && north == true && south == true && waterlogged == true && west == false) {
                State = 15072;
            } else if(east == true && north == true && south == true && waterlogged == false && west == true) {
                State = 15073;
            } else if(east == true && north == true && south == true && waterlogged == false && west == false) {
                State = 15074;
            } else if(east == true && north == true && south == false && waterlogged == true && west == true) {
                State = 15075;
            } else if(east == true && north == true && south == false && waterlogged == true && west == false) {
                State = 15076;
            } else if(east == true && north == true && south == false && waterlogged == false && west == true) {
                State = 15077;
            } else if(east == true && north == true && south == false && waterlogged == false && west == false) {
                State = 15078;
            } else if(east == true && north == false && south == true && waterlogged == true && west == true) {
                State = 15079;
            } else if(east == true && north == false && south == true && waterlogged == true && west == false) {
                State = 15080;
            } else if(east == true && north == false && south == true && waterlogged == false && west == true) {
                State = 15081;
            } else if(east == true && north == false && south == true && waterlogged == false && west == false) {
                State = 15082;
            } else if(east == true && north == false && south == false && waterlogged == true && west == true) {
                State = 15083;
            } else if(east == true && north == false && south == false && waterlogged == true && west == false) {
                State = 15084;
            } else if(east == true && north == false && south == false && waterlogged == false && west == true) {
                State = 15085;
            } else if(east == true && north == false && south == false && waterlogged == false && west == false) {
                State = 15086;
            } else if(east == false && north == true && south == true && waterlogged == true && west == true) {
                State = 15087;
            } else if(east == false && north == true && south == true && waterlogged == true && west == false) {
                State = 15088;
            } else if(east == false && north == true && south == true && waterlogged == false && west == true) {
                State = 15089;
            } else if(east == false && north == true && south == true && waterlogged == false && west == false) {
                State = 15090;
            } else if(east == false && north == true && south == false && waterlogged == true && west == true) {
                State = 15091;
            } else if(east == false && north == true && south == false && waterlogged == true && west == false) {
                State = 15092;
            } else if(east == false && north == true && south == false && waterlogged == false && west == true) {
                State = 15093;
            } else if(east == false && north == true && south == false && waterlogged == false && west == false) {
                State = 15094;
            } else if(east == false && north == false && south == true && waterlogged == true && west == true) {
                State = 15095;
            } else if(east == false && north == false && south == true && waterlogged == true && west == false) {
                State = 15096;
            } else if(east == false && north == false && south == true && waterlogged == false && west == true) {
                State = 15097;
            } else if(east == false && north == false && south == true && waterlogged == false && west == false) {
                State = 15098;
            } else if(east == false && north == false && south == false && waterlogged == true && west == true) {
                State = 15099;
            } else if(east == false && north == false && south == false && waterlogged == true && west == false) {
                State = 15100;
            } else if(east == false && north == false && south == false && waterlogged == false && west == true) {
                State = 15101;
            } else if(east == false && north == false && south == false && waterlogged == false && west == false) {
                State = 15102;
            }
        }
    }
}
