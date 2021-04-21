// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class SeaPickleBlock : BaseBlock {

        public int Pickles { get; }
        public bool Waterlogged { get; }

        public SeaPickleBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 618, 9644) { }

        public SeaPickleBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 618, state) {
            if(state == 9644) {
                Pickles = 1;
                Waterlogged = true;
            } else if(state == 9645) {
                Pickles = 1;
                Waterlogged = false;
            } else if(state == 9646) {
                Pickles = 2;
                Waterlogged = true;
            } else if(state == 9647) {
                Pickles = 2;
                Waterlogged = false;
            } else if(state == 9648) {
                Pickles = 3;
                Waterlogged = true;
            } else if(state == 9649) {
                Pickles = 3;
                Waterlogged = false;
            } else if(state == 9650) {
                Pickles = 4;
                Waterlogged = true;
            } else if(state == 9651) {
                Pickles = 4;
                Waterlogged = false;
            }
        }

        public SeaPickleBlock(Chunk chunk, int x, int y, int z, int pickles, bool waterlogged) : base(chunk, x, y, z, 618, 9644) {
if(pickles == 1 && waterlogged == true) {
                State = 9644;
            } else if(pickles == 1 && waterlogged == false) {
                State = 9645;
            } else if(pickles == 2 && waterlogged == true) {
                State = 9646;
            } else if(pickles == 2 && waterlogged == false) {
                State = 9647;
            } else if(pickles == 3 && waterlogged == true) {
                State = 9648;
            } else if(pickles == 3 && waterlogged == false) {
                State = 9649;
            } else if(pickles == 4 && waterlogged == true) {
                State = 9650;
            } else if(pickles == 4 && waterlogged == false) {
                State = 9651;
            }
        }
    }
}
