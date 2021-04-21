// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class StoneBrickSlabBlock : BaseBlock {

        public BlockType Type { get; }
        public bool Waterlogged { get; }

        public StoneBrickSlabBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 465, 8385) { }

        public StoneBrickSlabBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 465, state) {if(state == 8382) {
                Type = BlockType.Top;
                Waterlogged = true;
            } else if(state == 8383) {
                Type = BlockType.Top;
                Waterlogged = false;
            } else if(state == 8384) {
                Type = BlockType.Bottom;
                Waterlogged = true;
            } else if(state == 8385) {
                Type = BlockType.Bottom;
                Waterlogged = false;
            } else if(state == 8386) {
                Type = BlockType.Double;
                Waterlogged = true;
            } else if(state == 8387) {
                Type = BlockType.Double;
                Waterlogged = false;
            }
        }

        public StoneBrickSlabBlock(Chunk chunk, int x, int y, int z, BlockType type, bool waterlogged) : base(chunk, x, y, z, 465, 8385) {
if(type == BlockType.Top && waterlogged == true) {
                State = 8382;
            } else if(type == BlockType.Top && waterlogged == false) {
                State = 8383;
            } else if(type == BlockType.Bottom && waterlogged == true) {
                State = 8384;
            } else if(type == BlockType.Bottom && waterlogged == false) {
                State = 8385;
            } else if(type == BlockType.Double && waterlogged == true) {
                State = 8386;
            } else if(type == BlockType.Double && waterlogged == false) {
                State = 8387;
            }
        }

        public enum BlockType {
            
            Top,
            Bottom,
            Double
        }
    }
}
