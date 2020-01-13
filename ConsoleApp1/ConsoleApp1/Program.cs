using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(2));
            Console.ReadLine();
        }

        public static bool IsPrime(int n)
        {
            return n == 2 ? true : n == 0 || n == 1 ? false : Enumerable.Range(2, n - 2).All(i => n % i != 0);
        }
    }
}
