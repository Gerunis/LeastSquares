using System;
using System.Collections.Generic;
using System.Text;

namespace LeastSquares
{
    class Counter
    {
        public static Function A(Data[] data)
        {
            var n = data.Length;
            var sums = new Data();
            for (var i = 0; i < n; i++)
            {
                sums.X += data[i].X;
                sums.Y += data[i].Y;
                sums.X2 += data[i].X2;
                sums.X3 += data[i].X3;
                sums.X4 += data[i].X4;
                sums.YX += data[i].YX;
                sums.YX2 += data[i].YX2;
            }

            var matrix = new double[,] {
                {sums.X4, sums.X3, sums.X2, sums.YX2 },
                {sums.X3, sums.X2, sums.X, sums.YX },
                {sums.X2, sums.X, n, sums.Y}, };

            var r = Count(matrix);
            return new Function(r);
        }

        public static double[] Count(double[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = i + 1; j < array.GetLength(0); j++)
                {                   
                    var k = array[j, i] / array[i, i];
                    for (var t = i; t < array.GetLength(1); t++)
                    {
                        array[j, t] -= array[i, t] * k;
                    }
                }                
            }
            

            for (var i = array.GetLength(0) - 1; i >= 0; i--)
            {
                for (var j = 0; j < i; j++)
                {
                    var k = array[j, i] / array[i, i];
                    for (var t = i; t < array.GetLength(1); t++)
                    {
                        array[j, t] -= k * array[i, t];
                    }
                }
            }

            var res = new double[array.GetLength(0)];

            for (var i = 0; i < array.GetLength(0); i++)
                res[i] = array[i, array.GetLength(1) - 1] / array[i, i];
            //    Console.WriteLine("x{0} = {1:N5}", i + 1, array[i, array.GetLength(1) - 1] / array[i, i]);

            return res;
        }
    }
}
