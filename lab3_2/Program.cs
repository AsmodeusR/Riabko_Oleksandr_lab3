using System;
using System.Collections.Generic;

namespace lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string>[] array = new Dictionary<int, string>[3];
            array[0] = new Dictionary<int, string>(5);
            array[0].Add(1, "russia");
            array[0].Add(2, "ukraine");
            array[0].Add(3, "england");
            array[0].Add(4, "usa");
            array[0].Add(5, "egypt");
            array[1] = new Dictionary<int, string>(5);
            array[1].Add(1, "россия");
            array[1].Add(2, "украина");
            array[1].Add(3, "англия");
            array[1].Add(4, "америка");
            array[1].Add(5, "египет");
            array[2] = new Dictionary<int, string>(5);
            array[2].Add(1, "росія");
            array[2].Add(2, "україна");
            array[2].Add(3, "англія");
            array[2].Add(4, "америка");
            array[2].Add(5, "єгипет");
            Console.WriteLine("enter the key: ");
            int key = int.Parse(Console.ReadLine());
            Search(key, array);
        }
        public static void Search(int key, Dictionary<int, string>[] arr)
        {
            int counter = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i].ContainsKey(key))
                {
                    counter++;
                    Console.WriteLine(arr[i][key]);
                }
            }
            Console.WriteLine($"Num of results: {counter}");
        }
    }
}
