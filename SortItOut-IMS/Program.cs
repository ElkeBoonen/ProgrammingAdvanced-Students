using System;
using System.Collections.Generic;
using System.Linq;
using TM.ProgrammingAdvanced;

namespace SortItOut_IMS
{
    class Program
    {

        static int Mapping(int s, int a1, int a2)
        {
            return (int)(1 + (((s - a1) * 49) / (a2 - a1)));
        }

        static void Print(int[] array)
        {
            foreach (int i in array) Console.Write(i + " ");
            Console.WriteLine();
        }

        static void Print(KeyValuePair<string, int>[] array)
        {
            foreach (KeyValuePair<string, int> pair in array)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
        }

        static void YannickSort(int[] array) //bubble
        {
            for (int i = 0; i < array.Length; i++)
            {
               
                for (int j = 0; j < array.Length-i-1; j++)
                {
                    if (array[j+1] < array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("BUBBLE");
            Print(array);
        }

        static void YorickSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                var smallest = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[smallest]) smallest = j;
                }

                int temp = array[i];
                array[i] = array[smallest];
                array[smallest] = temp;
            }

            Console.WriteLine("SELECTION");
            Print(array);
        }

        static void KevinSort(int[] array) 
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;
                for (int j = i+1; j < array.Length; j++)
                {
                    Print(array);
                    if (array[i] > array[j])
                    {
                        for (int k = j+1; k > 0; k--)
                        {
                            if (array[k] > array[j - count])
                            {
                                temp = array[k];
                                array[k] = array[j - count];
                                array[j - count] = temp;
                            }
                            if (count < j) count++;
                        }

                    }

                }
            }
        }

        static void SelectionSort(KeyValuePair<string, int>[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var smallest = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].Value < array[smallest].Value) smallest = j;
                }

                KeyValuePair<string,int> temp = array[i];
                array[i] = array[smallest];
                array[smallest] = temp;
            }

            Console.WriteLine("SELECTION");
            Print(array);
        }

        static void BubbleSort(KeyValuePair<string, int>[] array) //bubble met key value
        {
            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j + 1].Value < array[j].Value)
                    {
                        KeyValuePair<string,int> temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("GESORTEERD");
            Print(array);
        }

        static int[] GetElements()
        {
            //eerste 10 elementen eruit halen
            int[] array1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array1[i] = Data.Songs.ElementAt(i).Value;
            }

            //10 elementen omvormen naar range tussen 1 en 50
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Mapping(array1[i], array1.Min(), array1.Max());
            }
            return array;

        }


        static void Main(string[] args)
        {
            //key-value pair--> key = string, value = int
            Dictionary<string, int> songs = Data.Songs;
            /*foreach (string key in songs.Keys)
     
            {
                Console.WriteLine(key + " -> " + songs[key]);
            }

            foreach (KeyValuePair<string, int> pair in songs)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }*/


            //bubble sort met yannick
            YannickSort(GetElements());
            //selection sort met Yorick
            YorickSort(GetElements());
            KevinSort(GetElements());

            //omzetten van dictionary (opgebouwd uit keyvalue-pairs) naar array van keyvalue-pairs
            //KeyValuePair<string, int>[] songs_array = Data.Songs.ToArray();
            //BubbleSort(songs_array);



        }
    }
}
