using System;
using System.Collections.Generic;

namespace lab_5
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var graph = new List<int>[]
            {
                new (){0,1},
                new (){0},
                new (){1}
            };
            
            var components = new SccTarjan(graph).Scc();
            foreach (var component in components)
            {
                foreach (var tmp in component)
                {
                    Console.Write($"{tmp}\t");
                }

                Console.WriteLine();
            }
        }
    }
}