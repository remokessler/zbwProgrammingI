using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SongDecoder("WUBWUBIWUBWUBWUBWUBAMWUBROBOTWUBWUBWUB"));
            Console.WriteLine(SongDecoder("WUBWUBABCWUB"));
            Console.WriteLine(SongDecoder("RWUBWUBWUBLWUB"));
            Console.ReadLine();
        }
        public static string SongDecoder(string input)
        {
            return new Regex(@"(WUB)\1*").Replace(input, " ").Trim();
        }
    }
}
