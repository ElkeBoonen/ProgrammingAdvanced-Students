using System;
using System.Collections.Generic;
using System.Linq;
using TM.ProgrammingAdvanced;

namespace SortItOut_DSPS
{
    class Program
    {
        static int Mapping(int s, int a1, int a2, int b1, int b2)
        {
            int t = b1 + (((s - a1) * (b2 - b1)) / (a2 - a1));
            return t;
        }

        static int[] GetNumbers(int count)
        {
            int[] array = new int[count];
            int counter = 0;
            foreach (string song in Data.Songs.Keys)
            {
                if (counter == count) break;
                array[counter] = Data.Songs[song];
                counter++;
            }

            int a1 = array.Min();
            int a2 = array.Max();

            for (int i = 0; i < count; i++)
                array[i] = Mapping(array[i], a1, a2, 1, 50);

            return array;
        }

        static void HugoSort(int[] array) //bubble sort
        {
            int c = 1;
            while (c < array.Length)
            {

                for (int i = 0; i < array.Length - c; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
                c++;
            }
            Console.Write("BUBBLE --> ");
            Print(array);
        }

        static void HugoSort(KeyValuePair<string, int>[] array) //bubble sort
        {
            int c = 1;
            while (c < array.Length)
            {

                for (int i = 0; i < array.Length - c; i++)
                {
                    if (array[i].Value > array[i + 1].Value)
                    {
                        KeyValuePair<string, int> temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
                c++;
            }
            Console.WriteLine("BUBBLE");
            Print(array);
        }

        static void NeilSort(int[] array) //selection
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int smallest = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                int temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }

            Print(array);
        }

        static void JulianSort(int[] array) //insertion
        {
            Print(array);
            for (int i = 1; i < array.Length; i++)
            {
                Console.WriteLine("i: " + "= " + array[i]);
                for (int j = i-1; j >=0 ; j--)
                {
                    Console.WriteLine("\tj: " + j + "= " +  array[j]);
                    if (array[i] < array[j])
                    {
                        Console.WriteLine("NEEDS A SHIFT");
                        array[j] = array[j + 1];
                    }
                    else break;
                    Print(array);
                }

            }
        }

        static void Print(int[] array)
        {
            foreach (int nr in array)
                Console.Write(nr + " ");
            Console.WriteLine();
        }

        static void Print(KeyValuePair<string, int>[] array)
        {
            foreach (KeyValuePair<string, int> pair in array)
                Console.WriteLine(pair.Value + " " + pair.Key);
        }

        static void Main(string[] args)
        {
            Print(GetNumbers(10));
            
            HugoSort(GetNumbers(10));

            KeyValuePair<string, int>[] songs = Data.Songs.ToArray();
            //HugoSort(songs);

            NeilSort(GetNumbers(10));

            JulianSort(GetNumbers(10));
        }
    }
}
