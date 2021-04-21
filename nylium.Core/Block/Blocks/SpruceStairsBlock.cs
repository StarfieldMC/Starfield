// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class SpruceStairsBlock : BaseBlock {

        public Face Facing { get; }
        public Half Half { get; }
        public Shape Shape { get; }
        public bool Waterlogged { get; }

        public SpruceStairsBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 274, 5419) { }

        public SpruceStairsBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 274, state) {
            if(state == 5408) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 5409) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 5410) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 5411) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 5412) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 5413) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 5414) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 5415) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 5416) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 5417) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 5418) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 5419) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 5420) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 5421) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 5422) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 5423) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 5424) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 5425) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 5426) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 5427) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 5428) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 5429) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 5430) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 5431) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 5432) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 5433) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 5434) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 5435) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 5436) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 5437) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 5438) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 5439) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 5440) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 5441) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 5442) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 5443) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 5444) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 5445) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 5446) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 5447) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 5448) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 5449) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 5450) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 5451) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 5452) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 5453) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 5454) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 5455) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 5456) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 5457) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 5458) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 5459) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 5460) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 5461) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 5462) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 5463) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 5464) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 5465) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 5466) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 5467) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 5468) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 5469) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 5470) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 5471) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 5472) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 5473) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 5474) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 5475) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 5476) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 5477) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 5478) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 5479) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 5480) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 5481) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 5482) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 5483) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 5484) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 5485) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 5486) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 5487) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            }
        }

        public SpruceStairsBlock(Chunk chunk, int x, int y, int z, Face facing, Half half, Shape shape, bool waterlogged) : base(chunk, x, y, z, 274, 5419) {
if(facing == Face.North && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 5408;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 5409;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 5410;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 5411;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 5412;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 5413;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 5414;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 5415;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 5416;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 5417;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 5418;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 5419;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 5420;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 5421;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 5422;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 5423;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 5424;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 5425;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 5426;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 5427;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 5428;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 5429;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 5430;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 5431;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 5432;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 5433;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 5434;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 5435;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 5436;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 5437;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 5438;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 5439;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 5440;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 5441;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 5442;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 5443;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 5444;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 5445;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 5446;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 5447;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 5448;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 5449;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 5450;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 5451;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 5452;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 5453;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 5454;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 5455;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 5456;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 5457;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 5458;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 5459;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 5460;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 5461;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 5462;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 5463;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 5464;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 5465;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 5466;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 5467;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 5468;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 5469;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 5470;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 5471;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 5472;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 5473;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 5474;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 5475;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 5476;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 5477;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 5478;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 5479;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 5480;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 5481;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 5482;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 5483;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 5484;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 5485;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 5486;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 5487;
            }
        }
    }
}
