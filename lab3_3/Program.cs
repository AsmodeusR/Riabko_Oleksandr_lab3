using System;
using System.Linq;
using System.Collections.Generic;

namespace lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter D: ");
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter A with spaces: ");
            string str = Console.ReadLine();
            List<int> A = str.Split(" ").Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToList();
            var formated = A.Where(x => x % 10 == D & x > 0).Reverse().Distinct().Reverse();
            foreach (int x in formated) Console.WriteLine(x);
        }
    }
}
