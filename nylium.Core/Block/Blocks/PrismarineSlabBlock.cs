// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class PrismarineSlabBlock : BaseBlock {

        public BlockType Type { get; }
        public bool Waterlogged { get; }

        public PrismarineSlabBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 386, 7851) { }

        public PrismarineSlabBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 386, state) {if(state == 7848) {
                Type = BlockType.Top;
                Waterlogged = true;
            } else if(state == 7849) {
                Type = BlockType.Top;
                Waterlogged = false;
            } else if(state == 7850) {
                Type = BlockType.Bottom;
                Waterlogged = true;
            } else if(state == 7851) {
                Type = BlockType.Bottom;
                Waterlogged = false;
            } else if(state == 7852) {
                Type = BlockType.Double;
                Waterlogged = true;
            } else if(state == 7853) {
                Type = BlockType.Double;
                Waterlogged = false;
            }
        }

        public PrismarineSlabBlock(Chunk chunk, int x, int y, int z, BlockType type, bool waterlogged) : base(chunk, x, y, z, 386, 7851) {
if(type == BlockType.Top && waterlogged == true) {
                State = 7848;
            } else if(type == BlockType.Top && waterlogged == false) {
                State = 7849;
            } else if(type == BlockType.Bottom && waterlogged == true) {
                State = 7850;
            } else if(type == BlockType.Bottom && waterlogged == false) {
                State = 7851;
            } else if(type == BlockType.Double && waterlogged == true) {
                State = 7852;
            } else if(type == BlockType.Double && waterlogged == false) {
                State = 7853;
            }
        }

        public enum BlockType {
            
            Top,
            Bottom,
            Double
        }
    }
}
