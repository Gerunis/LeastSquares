using System;
using System.Collections.Generic;
using System.Text;

namespace LeastSquares
{
    public class Function
    {
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }

        public Function(double[] x)
        {
            A = x[0];
            B = x[1];
            C = x[2];
        }

        public double Count(double x)
        {
            return A * x * x + B * x + C;
        }

        public override string ToString()
        {
            return String.Format("F(x) = {0:0.00;- 0.00}*x^2 {1:+ 0.00;- 0.00}*x {2:+ 0.00;- 0.00}", A,B,C);
        }

    }
}
