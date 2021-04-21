// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class CutSandstoneSlabBlock : BaseBlock {

        public BlockType Type { get; }
        public bool Waterlogged { get; }

        public CutSandstoneSlabBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 461, 8361) { }

        public CutSandstoneSlabBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 461, state) {if(state == 8358) {
                Type = BlockType.Top;
                Waterlogged = true;
            } else if(state == 8359) {
                Type = BlockType.Top;
                Waterlogged = false;
            } else if(state == 8360) {
                Type = BlockType.Bottom;
                Waterlogged = true;
            } else if(state == 8361) {
                Type = BlockType.Bottom;
                Waterlogged = false;
            } else if(state == 8362) {
                Type = BlockType.Double;
                Waterlogged = true;
            } else if(state == 8363) {
                Type = BlockType.Double;
                Waterlogged = false;
            }
        }

        public CutSandstoneSlabBlock(Chunk chunk, int x, int y, int z, BlockType type, bool waterlogged) : base(chunk, x, y, z, 461, 8361) {
if(type == BlockType.Top && waterlogged == true) {
                State = 8358;
            } else if(type == BlockType.Top && waterlogged == false) {
                State = 8359;
            } else if(type == BlockType.Bottom && waterlogged == true) {
                State = 8360;
            } else if(type == BlockType.Bottom && waterlogged == false) {
                State = 8361;
            } else if(type == BlockType.Double && waterlogged == true) {
                State = 8362;
            } else if(type == BlockType.Double && waterlogged == false) {
                State = 8363;
            }
        }

        public enum BlockType {
            
            Top,
            Bottom,
            Double
        }
    }
}
