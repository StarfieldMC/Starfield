// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class SandstoneSlabBlock : BaseBlock {

        public Type Type { get; }
        public bool Waterlogged { get; }

        public SandstoneSlabBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 460, 8355) { }

        public SandstoneSlabBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 460, state) {if(state == 8352) {
                Type = Type.Top;
                Waterlogged = true;
            } else if(state == 8353) {
                Type = Type.Top;
                Waterlogged = false;
            } else if(state == 8354) {
                Type = Type.Bottom;
                Waterlogged = true;
            } else if(state == 8355) {
                Type = Type.Bottom;
                Waterlogged = false;
            } else if(state == 8356) {
                Type = Type.Double;
                Waterlogged = true;
            } else if(state == 8357) {
                Type = Type.Double;
                Waterlogged = false;
            }
        }

        public SandstoneSlabBlock(Chunk chunk, int x, int y, int z, Type type, bool waterlogged) : base(chunk, x, y, z, 460, 8355) {
if(type == Type.Top && waterlogged == true) {
                State = 8352;
            } else if(type == Type.Top && waterlogged == false) {
                State = 8353;
            } else if(type == Type.Bottom && waterlogged == true) {
                State = 8354;
            } else if(type == Type.Bottom && waterlogged == false) {
                State = 8355;
            } else if(type == Type.Double && waterlogged == true) {
                State = 8356;
            } else if(type == Type.Double && waterlogged == false) {
                State = 8357;
            }
        }

        public enum Type {
            
            Top,
            Bottom,
            Double
        }
    }
}
