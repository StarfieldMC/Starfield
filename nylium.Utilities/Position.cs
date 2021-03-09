using System;

namespace nylium.Utilities {

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
        }
    }
}
