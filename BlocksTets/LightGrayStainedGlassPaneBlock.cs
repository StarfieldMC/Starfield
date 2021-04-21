// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class LightGrayStainedGlassPaneBlock : BaseBlock {

        public bool East { get; }
        public bool North { get; }
        public bool South { get; }
        public bool Waterlogged { get; }
        public bool West { get; }

        public LightGrayStainedGlassPaneBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 367, 7154) { }

        public LightGrayStainedGlassPaneBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 367, state) {
            if(state == 7123) {
                East = true;
                North = true;
                South = true;
                Waterlogged = true;
                West = true;
            } else if(state == 7124) {
                East = true;
                North = true;
                South = true;
                Waterlogged = true;
                West = false;
            } else if(state == 7125) {
                East = true;
                North = true;
                South = true;
                Waterlogged = false;
                West = true;
            } else if(state == 7126) {
                East = true;
                North = true;
                South = true;
                Waterlogged = false;
                West = false;
            } else if(state == 7127) {
                East = true;
                North = true;
                South = false;
                Waterlogged = true;
                West = true;
            } else if(state == 7128) {
                East = true;
                North = true;
                South = false;
                Waterlogged = true;
                West = false;
            } else if(state == 7129) {
                East = true;
                North = true;
                South = false;
                Waterlogged = false;
                West = true;
            } else if(state == 7130) {
                East = true;
                North = true;
                South = false;
                Waterlogged = false;
                West = false;
            } else if(state == 7131) {
                East = true;
                North = false;
                South = true;
                Waterlogged = true;
                West = true;
            } else if(state == 7132) {
                East = true;
                North = false;
                South = true;
                Waterlogged = true;
                West = false;
            } else if(state == 7133) {
                East = true;
                North = false;
                South = true;
                Waterlogged = false;
                West = true;
            } else if(state == 7134) {
                East = true;
                North = false;
                South = true;
                Waterlogged = false;
                West = false;
            } else if(state == 7135) {
                East = true;
                North = false;
                South = false;
                Waterlogged = true;
                West = true;
            } else if(state == 7136) {
                East = true;
                North = false;
                South = false;
                Waterlogged = true;
                West = false;
            } else if(state == 7137) {
                East = true;
                North = false;
                South = false;
                Waterlogged = false;
                West = true;
            } else if(state == 7138) {
                East = true;
                North = false;
                South = false;
                Waterlogged = false;
                West = false;
            } else if(state == 7139) {
                East = false;
                North = true;
                South = true;
                Waterlogged = true;
                West = true;
            } else if(state == 7140) {
                East = false;
                North = true;
                South = true;
                Waterlogged = true;
                West = false;
            } else if(state == 7141) {
                East = false;
                North = true;
                South = true;
                Waterlogged = false;
                West = true;
            } else if(state == 7142) {
                East = false;
                North = true;
                South = true;
                Waterlogged = false;
                West = false;
            } else if(state == 7143) {
                East = false;
                North = true;
                South = false;
                Waterlogged = true;
                West = true;
            } else if(state == 7144) {
                East = false;
                North = true;
                South = false;
                Waterlogged = true;
                West = false;
            } else if(state == 7145) {
                East = false;
                North = true;
                South = false;
                Waterlogged = false;
                West = true;
            } else if(state == 7146) {
                East = false;
                North = true;
                South = false;
                Waterlogged = false;
                West = false;
            } else if(state == 7147) {
                East = false;
                North = false;
                South = true;
                Waterlogged = true;
                West = true;
            } else if(state == 7148) {
                East = false;
                North = false;
                South = true;
                Waterlogged = true;
                West = false;
            } else if(state == 7149) {
                East = false;
                North = false;
                South = true;
                Waterlogged = false;
                West = true;
            } else if(state == 7150) {
                East = false;
                North = false;
                South = true;
                Waterlogged = false;
                West = false;
            } else if(state == 7151) {
                East = false;
                North = false;
                South = false;
                Waterlogged = true;
                West = true;
            } else if(state == 7152) {
                East = false;
                North = false;
                South = false;
                Waterlogged = true;
                West = false;
            } else if(state == 7153) {
                East = false;
                North = false;
                South = false;
                Waterlogged = false;
                West = true;
            } else if(state == 7154) {
                East = false;
                North = false;
                South = false;
                Waterlogged = false;
                West = false;
            }
        }

        public LightGrayStainedGlassPaneBlock(Chunk chunk, int x, int y, int z, bool east, bool north, bool south, bool waterlogged, bool west) : base(chunk, x, y, z, 367, 7154) {
if(east == true && north == true && south == true && waterlogged == true && west == true) {
                State = 7123;
            } else if(east == true && north == true && south == true && waterlogged == true && west == false) {
                State = 7124;
            } else if(east == true && north == true && south == true && waterlogged == false && west == true) {
                State = 7125;
            } else if(east == true && north == true && south == true && waterlogged == false && west == false) {
                State = 7126;
            } else if(east == true && north == true && south == false && waterlogged == true && west == true) {
                State = 7127;
            } else if(east == true && north == true && south == false && waterlogged == true && west == false) {
                State = 7128;
            } else if(east == true && north == true && south == false && waterlogged == false && west == true) {
                State = 7129;
            } else if(east == true && north == true && south == false && waterlogged == false && west == false) {
                State = 7130;
            } else if(east == true && north == false && south == true && waterlogged == true && west == true) {
                State = 7131;
            } else if(east == true && north == false && south == true && waterlogged == true && west == false) {
                State = 7132;
            } else if(east == true && north == false && south == true && waterlogged == false && west == true) {
                State = 7133;
            } else if(east == true && north == false && south == true && waterlogged == false && west == false) {
                State = 7134;
            } else if(east == true && north == false && south == false && waterlogged == true && west == true) {
                State = 7135;
            } else if(east == true && north == false && south == false && waterlogged == true && west == false) {
                State = 7136;
            } else if(east == true && north == false && south == false && waterlogged == false && west == true) {
                State = 7137;
            } else if(east == true && north == false && south == false && waterlogged == false && west == false) {
                State = 7138;
            } else if(east == false && north == true && south == true && waterlogged == true && west == true) {
                State = 7139;
            } else if(east == false && north == true && south == true && waterlogged == true && west == false) {
                State = 7140;
            } else if(east == false && north == true && south == true && waterlogged == false && west == true) {
                State = 7141;
            } else if(east == false && north == true && south == true && waterlogged == false && west == false) {
                State = 7142;
            } else if(east == false && north == true && south == false && waterlogged == true && west == true) {
                State = 7143;
            } else if(east == false && north == true && south == false && waterlogged == true && west == false) {
                State = 7144;
            } else if(east == false && north == true && south == false && waterlogged == false && west == true) {
                State = 7145;
            } else if(east == false && north == true && south == false && waterlogged == false && west == false) {
                State = 7146;
            } else if(east == false && north == false && south == true && waterlogged == true && west == true) {
                State = 7147;
            } else if(east == false && north == false && south == true && waterlogged == true && west == false) {
                State = 7148;
            } else if(east == false && north == false && south == true && waterlogged == false && west == true) {
                State = 7149;
            } else if(east == false && north == false && south == true && waterlogged == false && west == false) {
                State = 7150;
            } else if(east == false && north == false && south == false && waterlogged == true && west == true) {
                State = 7151;
            } else if(east == false && north == false && south == false && waterlogged == true && west == false) {
                State = 7152;
            } else if(east == false && north == false && south == false && waterlogged == false && west == true) {
                State = 7153;
            } else if(east == false && north == false && south == false && waterlogged == false && west == false) {
                State = 7154;
            }
        }
    }
}
