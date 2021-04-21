// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class LightBlueGlazedTerracottaBlock : BaseBlock {

        public Face Facing { get; }

        public LightBlueGlazedTerracottaBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 529, 9390) { }

        public LightBlueGlazedTerracottaBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 529, state) {
            if(state == 9390) {
                Facing = Face.North;
            } else if(state == 9391) {
                Facing = Face.South;
            } else if(state == 9392) {
                Facing = Face.West;
            } else if(state == 9393) {
                Facing = Face.East;
            }
        }

        public LightBlueGlazedTerracottaBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 529, 9390) {
if(facing == Face.North) {
                State = 9390;
            } else if(facing == Face.South) {
                State = 9391;
            } else if(facing == Face.West) {
                State = 9392;
            } else if(facing == Face.East) {
                State = 9393;
            }
        }
    }
}
