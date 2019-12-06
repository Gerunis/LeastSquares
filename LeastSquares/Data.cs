using System;
using System.Collections.Generic;
using System.Text;

namespace LeastSquares
{
    public class Data
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double X2 { get; set; }
        public double X3 { get; set; }
        public double X4 { get; set; }
        public double YX2 { get; set; }
        public double YX { get; set; }

        public Data(double x, double y)
        {
            X = x;
            Y = y;
            X2 = X * x;
            YX = y * x;
            YX2 = X2 * y;
            X3 = X2 * x;
            X4 = X3 * x;
        }

        public Data() { }

    }
}
