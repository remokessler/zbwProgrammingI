using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte c = 121;
            c = (byte)~c;
            Console.WriteLine(c.ToString());
            Console.ReadLine();
        }
    }
}
