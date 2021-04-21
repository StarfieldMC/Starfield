// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class DarkPrismarineSlabBlock : BaseBlock {

        public BlockType Type { get; }
        public bool Waterlogged { get; }

        public DarkPrismarineSlabBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 388, 7863) { }

        public DarkPrismarineSlabBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 388, state) {if(state == 7860) {
                Type = BlockType.Top;
                Waterlogged = true;
            } else if(state == 7861) {
                Type = BlockType.Top;
                Waterlogged = false;
            } else if(state == 7862) {
                Type = BlockType.Bottom;
                Waterlogged = true;
            } else if(state == 7863) {
                Type = BlockType.Bottom;
                Waterlogged = false;
            } else if(state == 7864) {
                Type = BlockType.Double;
                Waterlogged = true;
            } else if(state == 7865) {
                Type = BlockType.Double;
                Waterlogged = false;
            }
        }

        public DarkPrismarineSlabBlock(Chunk chunk, int x, int y, int z, BlockType type, bool waterlogged) : base(chunk, x, y, z, 388, 7863) {
if(type == BlockType.Top && waterlogged == true) {
                State = 7860;
            } else if(type == BlockType.Top && waterlogged == false) {
                State = 7861;
            } else if(type == BlockType.Bottom && waterlogged == true) {
                State = 7862;
            } else if(type == BlockType.Bottom && waterlogged == false) {
                State = 7863;
            } else if(type == BlockType.Double && waterlogged == true) {
                State = 7864;
            } else if(type == BlockType.Double && waterlogged == false) {
                State = 7865;
            }
        }

        public enum BlockType {
            
            Top,
            Bottom,
            Double
        }
    }
}
