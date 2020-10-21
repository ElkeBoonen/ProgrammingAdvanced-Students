using System;
using System.Collections.Generic;
using System.Text;

namespace DP_IMS
{
    class Fib
    {
        private int[] _mem;
        public int Number { get ; }

        public Fib(int nr)
        {
            Number = nr;
            _mem = new int[nr + 1];
        }

        //0 1 1 2 3 5 8 13 21 ...
        public int Ruben(int n)
        {
            if (n <= 1) return n;

            int oldnr = 0;
            int curnr = 1;
            int nr = 0;

            for (int i = 2; i <= n; i++)
            {
                nr = curnr + oldnr;
                oldnr = curnr;
                curnr = nr;
                //Console.WriteLine(nr);
            }
            return nr;
        }

        public int Recursief(int n) //RUben2
        {
            //Console.WriteLine("call met n = " + n);
            if (n <= 1) return n;
            return Recursief(n-1) + Recursief(n-2);
        }

        public int Memoization(int n) //Ruben2
        {
            if (n <= 1) return n;
            if (_mem[n] > 0) return _mem[n];
            _mem[n] = Memoization(n - 1) + Memoization(n - 2);
            return _mem[n];
        }

        public int Tabulation(int n)
        {
            if (n <= 1) return n;

            int[] _tab = new int[n + 1];
            _tab[0] = 0;
            _tab[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                _tab[i] = _tab[i - 1] + _tab[i - 2];
            }
            return _tab[n];
        }
    }
}
