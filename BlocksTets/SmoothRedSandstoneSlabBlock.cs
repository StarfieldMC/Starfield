// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class SmoothRedSandstoneSlabBlock : BaseBlock {

        public Type Type { get; }
        public bool Waterlogged { get; }

        public SmoothRedSandstoneSlabBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 642, 10802) { }

        public SmoothRedSandstoneSlabBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 642, state) {if(state == 10799) {
                Type = Type.Top;
                Waterlogged = true;
            } else if(state == 10800) {
                Type = Type.Top;
                Waterlogged = false;
            } else if(state == 10801) {
                Type = Type.Bottom;
                Waterlogged = true;
            } else if(state == 10802) {
                Type = Type.Bottom;
                Waterlogged = false;
            } else if(state == 10803) {
                Type = Type.Double;
                Waterlogged = true;
            } else if(state == 10804) {
                Type = Type.Double;
                Waterlogged = false;
            }
        }

        public SmoothRedSandstoneSlabBlock(Chunk chunk, int x, int y, int z, Type type, bool waterlogged) : base(chunk, x, y, z, 642, 10802) {
if(type == Type.Top && waterlogged == true) {
                State = 10799;
            } else if(type == Type.Top && waterlogged == false) {
                State = 10800;
            } else if(type == Type.Bottom && waterlogged == true) {
                State = 10801;
            } else if(type == Type.Bottom && waterlogged == false) {
                State = 10802;
            } else if(type == Type.Double && waterlogged == true) {
                State = 10803;
            } else if(type == Type.Double && waterlogged == false) {
                State = 10804;
            }
        }

        public enum Type {
            
            Top,
            Bottom,
            Double
        }
    }
}
