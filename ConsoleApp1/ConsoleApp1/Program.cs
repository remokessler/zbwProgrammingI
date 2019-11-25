using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 23;

            var text = val > 0 ? val % 2 == 0 ? "ist positiv und gerade" : "ist positiv und ungerade" : val % 2 == 0 ? "ist negativ und gerade" : "ist negativ und ungerade";

            Console.WriteLine(text.ToString());
            Console.ReadLine();
        }
    }
}
