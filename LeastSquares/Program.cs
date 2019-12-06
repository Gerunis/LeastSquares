using System;
using System.Linq;

namespace LeastSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var data = new Data[n];
            Console.WriteLine(" X  Y");
            for (var i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var e = line.Split(' ').Select(x => int.Parse(x)).ToArray();
                data[i] = new Data(e[0], e[1]);
            }
            var f = Counter.A(data);

            Console.WriteLine(f);
        }
    }
}

/*
5
-2 5
-1 4
2 1
3 0
4 -1
     */
