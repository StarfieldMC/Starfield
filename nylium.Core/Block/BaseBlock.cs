using nylium.Core.Level;

namespace nylium.Core.Block {

    public class BaseBlock {

        public Chunk Chunk { get; }

        public int X { get; }
        public int Y { get; }
        public int Z { get; }
        public ushort Id { get; }
        public ushort State { get; set; }

        public BaseBlock(Chunk chunk, int x, int y, int z, ushort id, ushort state) {
            Chunk = chunk;

            X = x;
            Y = y;
            Z = z;
            Id = id;
            State = state;
        }

        public enum Axis {

            X,
            Y,
            Z
        }

        public enum Part {

            Head,
            Foot
        }

        public enum Shape {

            NorthEast,
            NorthSouth,
            NorthWest,
            EastNorth,
            EastSouth,
            EastWest,
            SouthNorth,
            SouthEast,
            SouthWest,
            WestNorth,
            WestEast,
            WestSouth,
            AscendingEast,
            AscendingWest,
            AscendingNorth,
            AscendingSouth,
            Straight,
            InnerLeft,
            InnerRight,
            OuterLeft,
            OuterRight
        }

        public enum Half {

            Lower,
            Upper,
            Top,
            Bottom
        }

        public enum Orientation {

            UpNorth,
            UpEast,
            UpSouth,
            UpWest,
            DownNorth,
            DownEast,
            DownSouth,
            DownWest,
            NorthUp,
            EastUp,
            SouthUp,
            WestUp
        }

        public enum North {

            None,
            Low,
            Tall,
            Up,
            Side
        }

        public enum East {

            None,
            Low,
            Tall,
            Up,
            Side
        }


        public enum South {

            None,
            Low,
            Tall,
            Up,
            Side
        }

        public enum West {

            None,
            Low,
            Tall,
            Up,
            Side
        }

        public enum Face : sbyte {

            Up,
            Down,
            Bottom,
            Top,
            North,
            South,
            West,
            East,
            Floor,
            Wall,
            Ceiling
        }
    }
}
