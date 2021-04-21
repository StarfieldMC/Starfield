// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class QuartzSlabBlock : BaseBlock {

        public Type Type { get; }
        public bool Waterlogged { get; }

        public QuartzSlabBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 467, 8397) { }

        public QuartzSlabBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 467, state) {if(state == 8394) {
                Type = Type.Top;
                Waterlogged = true;
            } else if(state == 8395) {
                Type = Type.Top;
                Waterlogged = false;
            } else if(state == 8396) {
                Type = Type.Bottom;
                Waterlogged = true;
            } else if(state == 8397) {
                Type = Type.Bottom;
                Waterlogged = false;
            } else if(state == 8398) {
                Type = Type.Double;
                Waterlogged = true;
            } else if(state == 8399) {
                Type = Type.Double;
                Waterlogged = false;
            }
        }

        public QuartzSlabBlock(Chunk chunk, int x, int y, int z, Type type, bool waterlogged) : base(chunk, x, y, z, 467, 8397) {
if(type == Type.Top && waterlogged == true) {
                State = 8394;
            } else if(type == Type.Top && waterlogged == false) {
                State = 8395;
            } else if(type == Type.Bottom && waterlogged == true) {
                State = 8396;
            } else if(type == Type.Bottom && waterlogged == false) {
                State = 8397;
            } else if(type == Type.Double && waterlogged == true) {
                State = 8398;
            } else if(type == Type.Double && waterlogged == false) {
                State = 8399;
            }
        }

        public enum Type {
            
            Top,
            Bottom,
            Double
        }
    }
}
