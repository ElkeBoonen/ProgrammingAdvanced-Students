using System;

namespace DP_IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 1 1 2 3 5 8 13 21 34
            /*Fib f = new Fib(40);
            Console.WriteLine("FIB("+ f.Number + ")=" + f.Ruben(f.Number));
            Console.WriteLine("FIB(" + f.Number + ")=" + f.Tabulation(f.Number));
            Console.WriteLine("FIB(" + f.Number + ")=" + f.Memoization(f.Number));
            Console.WriteLine("FIB(" + f.Number + ")=" + f.Recursief(f.Number));*/

            Rod r = new Rod(new int[] { 1, 5, 8, 9 });
            Console.WriteLine("Max = " + r.Ruben(r.Length));
            Console.WriteLine("Max = " + r.Memoization(r.Length));
            Console.WriteLine("Max = " + r.Tabulation(r.Length));

        }
    }
}
