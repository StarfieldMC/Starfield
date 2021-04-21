// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class StoneBrickStairsBlock : BaseBlock {

        public Face Facing { get; }
        public Half Half { get; }
        public Shape Shape { get; }
        public bool Waterlogged { get; }

        public StoneBrickStairsBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 252, 4947) { }

        public StoneBrickStairsBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 252, state) {
            if(state == 4936) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 4937) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 4938) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 4939) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 4940) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 4941) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 4942) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 4943) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 4944) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 4945) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 4946) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 4947) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 4948) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 4949) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 4950) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 4951) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 4952) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 4953) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 4954) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 4955) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 4956) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 4957) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 4958) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 4959) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 4960) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 4961) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 4962) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 4963) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 4964) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 4965) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 4966) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 4967) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 4968) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 4969) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 4970) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 4971) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 4972) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 4973) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 4974) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 4975) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 4976) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 4977) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 4978) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 4979) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 4980) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 4981) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 4982) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 4983) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 4984) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 4985) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 4986) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 4987) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 4988) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 4989) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 4990) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 4991) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 4992) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 4993) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 4994) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 4995) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 4996) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 4997) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 4998) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 4999) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 5000) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 5001) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 5002) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 5003) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 5004) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 5005) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 5006) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 5007) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 5008) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 5009) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 5010) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 5011) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 5012) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 5013) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 5014) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 5015) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            }
        }

        public StoneBrickStairsBlock(Chunk chunk, int x, int y, int z, Face facing, Half half, Shape shape, bool waterlogged) : base(chunk, x, y, z, 252, 4947) {
if(facing == Face.North && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 4936;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 4937;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 4938;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 4939;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 4940;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 4941;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 4942;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 4943;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 4944;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 4945;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 4946;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 4947;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 4948;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 4949;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 4950;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 4951;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 4952;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 4953;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 4954;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 4955;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 4956;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 4957;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 4958;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 4959;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 4960;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 4961;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 4962;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 4963;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 4964;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 4965;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 4966;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 4967;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 4968;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 4969;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 4970;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 4971;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 4972;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 4973;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 4974;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 4975;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 4976;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 4977;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 4978;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 4979;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 4980;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 4981;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 4982;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 4983;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 4984;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 4985;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 4986;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 4987;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 4988;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 4989;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 4990;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 4991;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 4992;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 4993;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 4994;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 4995;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 4996;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 4997;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 4998;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 4999;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 5000;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 5001;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 5002;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 5003;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 5004;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 5005;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 5006;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 5007;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 5008;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 5009;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 5010;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 5011;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 5012;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 5013;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 5014;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 5015;
            }
        }
    }
}
