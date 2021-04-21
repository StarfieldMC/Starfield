// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class PetrifiedOakSlabBlock : BaseBlock {

        public BlockType Type { get; }
        public bool Waterlogged { get; }

        public PetrifiedOakSlabBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 462, 8367) { }

        public PetrifiedOakSlabBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 462, state) {if(state == 8364) {
                Type = BlockType.Top;
                Waterlogged = true;
            } else if(state == 8365) {
                Type = BlockType.Top;
                Waterlogged = false;
            } else if(state == 8366) {
                Type = BlockType.Bottom;
                Waterlogged = true;
            } else if(state == 8367) {
                Type = BlockType.Bottom;
                Waterlogged = false;
            } else if(state == 8368) {
                Type = BlockType.Double;
                Waterlogged = true;
            } else if(state == 8369) {
                Type = BlockType.Double;
                Waterlogged = false;
            }
        }

        public PetrifiedOakSlabBlock(Chunk chunk, int x, int y, int z, BlockType type, bool waterlogged) : base(chunk, x, y, z, 462, 8367) {
if(type == BlockType.Top && waterlogged == true) {
                State = 8364;
            } else if(type == BlockType.Top && waterlogged == false) {
                State = 8365;
            } else if(type == BlockType.Bottom && waterlogged == true) {
                State = 8366;
            } else if(type == BlockType.Bottom && waterlogged == false) {
                State = 8367;
            } else if(type == BlockType.Double && waterlogged == true) {
                State = 8368;
            } else if(type == BlockType.Double && waterlogged == false) {
                State = 8369;
            }
        }

        public enum BlockType {
            
            Top,
            Bottom,
            Double
        }
    }
}
