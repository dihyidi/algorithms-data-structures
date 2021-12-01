using System;

namespace Lab7
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const string txt = "AABAACAADAABAABA";
            const string pat = "AABA";
            Console.WriteLine("Found matches at index");
            foreach (var item in KmpSearcher.Search(pat, txt))
            {
                Console.WriteLine(item);
            }
        }
    }
}