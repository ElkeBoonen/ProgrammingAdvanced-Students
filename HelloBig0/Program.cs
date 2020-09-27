using System;
using TM.ProgrammingAdvanced;

namespace HelloBig0
{
    class Program
    {
        static int[] array = Data.Numbers;
        static int count = 0;

        static int Simple(int number)
        {
            count = 0;
            int index = 0;
            foreach (int element in array)
            {
                count++;
                if (element == number)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }


        static int Stupid(int number)
        {
            Random rd = new Random();
            count = 0;

            while (count < array.Length)
            {
                int index = rd.Next(0, 1000);
                if (array[index] == number) return index;
                count++;
            }
            return -1;
        }

        static int Rik(int number)
        {
            int index = array.Length / 2;
            int range = array.Length / 2;

            count = 0;
            while (count < 50)
            {
                count++;

                range = range / 2;
                if (range < 1) range = 1;

                if (array[index] > number) index = index - range;
                else if (array[index] < number) index = index + range;
                else return index;
                Console.WriteLine(index);
            }

            return -1;
        }

        static int Hicham(int number)
        {
            int min = 0;
            int max = array.Length - 1;
            count = 0;
            while (min <= max)
            {
                count++;
                int mid = (min + max) / 2;
                if (array[mid] == number) return mid;
                else if (number < array[mid])
                {
                    max = mid - 1;
                }
                else min = mid + 1;

            }
            return -1;
        }


        static void Main(string[] args)
        {

            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SIMPLE " + Simple(number) + " count " + count);
            Console.WriteLine("STUPID " + Stupid(number) + " count " + count);
            Console.WriteLine("RIK " + Rik(number) + " count " + count);
            Console.WriteLine("HICHAM " + Hicham(number) + " count " + count);

        }
    }
}
