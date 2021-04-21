// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class MossyStoneBrickSlabBlock : BaseBlock {

        public BlockType Type { get; }
        public bool Waterlogged { get; }

        public MossyStoneBrickSlabBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 643, 10808) { }

        public MossyStoneBrickSlabBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 643, state) {if(state == 10805) {
                Type = BlockType.Top;
                Waterlogged = true;
            } else if(state == 10806) {
                Type = BlockType.Top;
                Waterlogged = false;
            } else if(state == 10807) {
                Type = BlockType.Bottom;
                Waterlogged = true;
            } else if(state == 10808) {
                Type = BlockType.Bottom;
                Waterlogged = false;
            } else if(state == 10809) {
                Type = BlockType.Double;
                Waterlogged = true;
            } else if(state == 10810) {
                Type = BlockType.Double;
                Waterlogged = false;
            }
        }

        public MossyStoneBrickSlabBlock(Chunk chunk, int x, int y, int z, BlockType type, bool waterlogged) : base(chunk, x, y, z, 643, 10808) {
if(type == BlockType.Top && waterlogged == true) {
                State = 10805;
            } else if(type == BlockType.Top && waterlogged == false) {
                State = 10806;
            } else if(type == BlockType.Bottom && waterlogged == true) {
                State = 10807;
            } else if(type == BlockType.Bottom && waterlogged == false) {
                State = 10808;
            } else if(type == BlockType.Double && waterlogged == true) {
                State = 10809;
            } else if(type == BlockType.Double && waterlogged == false) {
                State = 10810;
            }
        }

        public enum BlockType {
            
            Top,
            Bottom,
            Double
        }
    }
}
