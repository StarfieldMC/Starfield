using System;

namespace Starfield.Utilities {

    public class Position {

        public class Int {

            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

            public Int(int x, int y, int z) {
                X = x;
                Y = y;
                Z = z;
            }

            public Int(Int pos) {
                X = pos.X;
                Y = pos.Y;
                Z = pos.Z;
            }

            public override bool Equals(object obj) {
                if(obj is not Int item) return false;

                return item.X == X && item.Y == Y && item.Z == Z;
            }
        }

        public class Float {

            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }

            public Float(float x, float y, float z) {
                X = x;
                Y = y;
                Z = z;
            }

            public Float(Float pos) {
                X = pos.X;
                Y = pos.Y;
                Z = pos.Z;
            }

            public override bool Equals(object obj) {
                if(obj is not Float item) return false;

                return item.X == X && item.Y == Y && item.Z == Z;
            }
        }

        public class Double {

            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }

            public Double(double x, double y, double z) {
                X = x;
                Y = y;
                Z = z;
            }

            public Double(Double pos) {
                X = pos.X;
                Y = pos.Y;
                Z = pos.Z;
            }

            public override bool Equals(object obj) {
                if(obj is not Double item) return false;

                return item.X == X && item.Y == Y && item.Z == Z;
            }
        }
    }
}
