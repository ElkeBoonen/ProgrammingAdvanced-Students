using System;
using System.Collections.Generic;
using System.Text;

namespace DP_IMS
{
    class Rod
    {
        private int[] _mem;
        public int Length { get; }
        public int[] Prices { get; set; }

        public Rod(int[] prices)
        {
            Prices = prices;
            Length = prices.Length;
            _mem = new int[Length + 1];
        }

        public int Ruben(int n)
        {
            if (n == 1) return Prices[n - 1]; //0 is ook ok!

            int max = 0;
            for (int i = 1; i <= n; i++)
            {
                max = Math.Max(max, Prices[i - 1] + Ruben(n-i));
            }
            return max;
        }

        public int Memoization(int n)
        {
            if (n == 1) return Prices[n - 1]; //0 is ook ok!
            if (_mem[n] > 0) return _mem[n];

            int max = 0;
            for (int i = 1; i <= n; i++)
            {
                max = Math.Max(max, Prices[i - 1] + Memoization(n - i));
                _mem[n] = max;
            }
            return _mem[n];
        }

        public int Tabulation(int n)
        {
            int[] tabulation = new int[n + 1];
            tabulation[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                int max = -1;
                for (int j = 1; j <= i; j++)
                {
                    max = Math.Max(max, Prices[j - 1] + tabulation[i - j]);
                    Console.Write(Prices[j - 1] + tabulation[i - j] + " " );
                    tabulation[i] = max;
                }
                Console.WriteLine();
            }
            return tabulation[n];
        }

    }
}
