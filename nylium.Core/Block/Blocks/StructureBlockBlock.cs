// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class StructureBlockBlock : BaseBlock {

        public BlockMode Mode { get; }

        public StructureBlockBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 726, 15743) { }

        public StructureBlockBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 726, state) {if(state == 15743) {
                Mode = BlockMode.Save;
            } else if(state == 15744) {
                Mode = BlockMode.Load;
            } else if(state == 15745) {
                Mode = BlockMode.Corner;
            } else if(state == 15746) {
                Mode = BlockMode.Data;
            }
        }

        public StructureBlockBlock(Chunk chunk, int x, int y, int z, BlockMode mode) : base(chunk, x, y, z, 726, 15743) {
if(mode == BlockMode.Save) {
                State = 15743;
            } else if(mode == BlockMode.Load) {
                State = 15744;
            } else if(mode == BlockMode.Corner) {
                State = 15745;
            } else if(mode == BlockMode.Data) {
                State = 15746;
            }
        }

        public enum BlockMode {

            Save,
            Load,
            Corner,
            Data
        }
    }
}
