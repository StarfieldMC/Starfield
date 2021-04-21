// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class JukeboxBlock : BaseBlock {

        public bool Has_Record { get; }

        public JukeboxBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 190, 3965) { }

        public JukeboxBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 190, state) {
            if(state == 3964) {
                Has_Record = true;
            } else if(state == 3965) {
                Has_Record = false;
            }
        }

        public JukeboxBlock(Chunk chunk, int x, int y, int z, bool has_record) : base(chunk, x, y, z, 190, 3965) {
if(has_record == true) {
                State = 3964;
            } else if(has_record == false) {
                State = 3965;
            }
        }
    }
}
