// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class ChestBlock : BaseBlock {

        public Face Facing { get; }
        public Type Type { get; }
        public bool Waterlogged { get; }

        public ChestBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 147, 2035) { }

        public ChestBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 147, state) {
            if(state == 2034) {
                Facing = Face.North;
                Type = Type.Single;
                Waterlogged = true;
            } else if(state == 2035) {
                Facing = Face.North;
                Type = Type.Single;
                Waterlogged = false;
            } else if(state == 2036) {
                Facing = Face.North;
                Type = Type.Left;
                Waterlogged = true;
            } else if(state == 2037) {
                Facing = Face.North;
                Type = Type.Left;
                Waterlogged = false;
            } else if(state == 2038) {
                Facing = Face.North;
                Type = Type.Right;
                Waterlogged = true;
            } else if(state == 2039) {
                Facing = Face.North;
                Type = Type.Right;
                Waterlogged = false;
            } else if(state == 2040) {
                Facing = Face.South;
                Type = Type.Single;
                Waterlogged = true;
            } else if(state == 2041) {
                Facing = Face.South;
                Type = Type.Single;
                Waterlogged = false;
            } else if(state == 2042) {
                Facing = Face.South;
                Type = Type.Left;
                Waterlogged = true;
            } else if(state == 2043) {
                Facing = Face.South;
                Type = Type.Left;
                Waterlogged = false;
            } else if(state == 2044) {
                Facing = Face.South;
                Type = Type.Right;
                Waterlogged = true;
            } else if(state == 2045) {
                Facing = Face.South;
                Type = Type.Right;
                Waterlogged = false;
            } else if(state == 2046) {
                Facing = Face.West;
                Type = Type.Single;
                Waterlogged = true;
            } else if(state == 2047) {
                Facing = Face.West;
                Type = Type.Single;
                Waterlogged = false;
            } else if(state == 2048) {
                Facing = Face.West;
                Type = Type.Left;
                Waterlogged = true;
            } else if(state == 2049) {
                Facing = Face.West;
                Type = Type.Left;
                Waterlogged = false;
            } else if(state == 2050) {
                Facing = Face.West;
                Type = Type.Right;
                Waterlogged = true;
            } else if(state == 2051) {
                Facing = Face.West;
                Type = Type.Right;
                Waterlogged = false;
            } else if(state == 2052) {
                Facing = Face.East;
                Type = Type.Single;
                Waterlogged = true;
            } else if(state == 2053) {
                Facing = Face.East;
                Type = Type.Single;
                Waterlogged = false;
            } else if(state == 2054) {
                Facing = Face.East;
                Type = Type.Left;
                Waterlogged = true;
            } else if(state == 2055) {
                Facing = Face.East;
                Type = Type.Left;
                Waterlogged = false;
            } else if(state == 2056) {
                Facing = Face.East;
                Type = Type.Right;
                Waterlogged = true;
            } else if(state == 2057) {
                Facing = Face.East;
                Type = Type.Right;
                Waterlogged = false;
            }
        }

        public ChestBlock(Chunk chunk, int x, int y, int z, Face facing, Type type, bool waterlogged) : base(chunk, x, y, z, 147, 2035) {
if(facing == Face.North && type == Type.Single && waterlogged == true) {
                State = 2034;
            } else if(facing == Face.North && type == Type.Single && waterlogged == false) {
                State = 2035;
            } else if(facing == Face.North && type == Type.Left && waterlogged == true) {
                State = 2036;
            } else if(facing == Face.North && type == Type.Left && waterlogged == false) {
                State = 2037;
            } else if(facing == Face.North && type == Type.Right && waterlogged == true) {
                State = 2038;
            } else if(facing == Face.North && type == Type.Right && waterlogged == false) {
                State = 2039;
            } else if(facing == Face.South && type == Type.Single && waterlogged == true) {
                State = 2040;
            } else if(facing == Face.South && type == Type.Single && waterlogged == false) {
                State = 2041;
            } else if(facing == Face.South && type == Type.Left && waterlogged == true) {
                State = 2042;
            } else if(facing == Face.South && type == Type.Left && waterlogged == false) {
                State = 2043;
            } else if(facing == Face.South && type == Type.Right && waterlogged == true) {
                State = 2044;
            } else if(facing == Face.South && type == Type.Right && waterlogged == false) {
                State = 2045;
            } else if(facing == Face.West && type == Type.Single && waterlogged == true) {
                State = 2046;
            } else if(facing == Face.West && type == Type.Single && waterlogged == false) {
                State = 2047;
            } else if(facing == Face.West && type == Type.Left && waterlogged == true) {
                State = 2048;
            } else if(facing == Face.West && type == Type.Left && waterlogged == false) {
                State = 2049;
            } else if(facing == Face.West && type == Type.Right && waterlogged == true) {
                State = 2050;
            } else if(facing == Face.West && type == Type.Right && waterlogged == false) {
                State = 2051;
            } else if(facing == Face.East && type == Type.Single && waterlogged == true) {
                State = 2052;
            } else if(facing == Face.East && type == Type.Single && waterlogged == false) {
                State = 2053;
            } else if(facing == Face.East && type == Type.Left && waterlogged == true) {
                State = 2054;
            } else if(facing == Face.East && type == Type.Left && waterlogged == false) {
                State = 2055;
            } else if(facing == Face.East && type == Type.Right && waterlogged == true) {
                State = 2056;
            } else if(facing == Face.East && type == Type.Right && waterlogged == false) {
                State = 2057;
            }
        }
    }
}
