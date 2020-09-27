using System;
using TM.ProgrammingAdvanced;

namespace HelloBigO_DSPS
{
    class Program
    {
        static int[] nrs = Data.Numbers;
        static int count = 0;

        static int Dima(int number)
        {
            count = 0;
            for (int i = 0; i < nrs.Length; i++)
            {
                count++;
                if (nrs[i] == number) return i;
            }
            return -1;
        }
        static int Julian(int number)
        {
            Random rd = new Random();
            count = 0;
            while (count < nrs.Length)
            {
                count++;
                int pos = rd.Next(0, nrs.Length);
                if (nrs[pos] == number) return pos;
            }
            return -1;
        }

        static int Hugo(int number)
        {
            int min = 0;
            int max = nrs.Length - 1;
            count = 0;

            while (min <= max)
            {
                count++;
                int pos = (min + max) / 2;
                if (number == nrs[pos]) return pos;
                else if (number > nrs[pos]) min = pos + 1;
                else max = pos - 1;
            }
            return -1;
        }


        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dima: " + Dima(number) + "  count -> " + count);
            Console.WriteLine("Julian: " +  Julian(number) + "  count -> " + count);
            Console.WriteLine("Hugo: " + Hugo(number) + "  count -> " + count);
        }
    }
}
