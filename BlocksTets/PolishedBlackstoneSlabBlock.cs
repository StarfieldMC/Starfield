// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class PolishedBlackstoneSlabBlock : BaseBlock {

        public Type Type { get; }
        public bool Waterlogged { get; }

        public PolishedBlackstoneSlabBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 756, 16756) { }

        public PolishedBlackstoneSlabBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 756, state) {if(state == 16753) {
                Type = Type.Top;
                Waterlogged = true;
            } else if(state == 16754) {
                Type = Type.Top;
                Waterlogged = false;
            } else if(state == 16755) {
                Type = Type.Bottom;
                Waterlogged = true;
            } else if(state == 16756) {
                Type = Type.Bottom;
                Waterlogged = false;
            } else if(state == 16757) {
                Type = Type.Double;
                Waterlogged = true;
            } else if(state == 16758) {
                Type = Type.Double;
                Waterlogged = false;
            }
        }

        public PolishedBlackstoneSlabBlock(Chunk chunk, int x, int y, int z, Type type, bool waterlogged) : base(chunk, x, y, z, 756, 16756) {
if(type == Type.Top && waterlogged == true) {
                State = 16753;
            } else if(type == Type.Top && waterlogged == false) {
                State = 16754;
            } else if(type == Type.Bottom && waterlogged == true) {
                State = 16755;
            } else if(type == Type.Bottom && waterlogged == false) {
                State = 16756;
            } else if(type == Type.Double && waterlogged == true) {
                State = 16757;
            } else if(type == Type.Double && waterlogged == false) {
                State = 16758;
            }
        }

        public enum Type {
            
            Top,
            Bottom,
            Double
        }
    }
}
