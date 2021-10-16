using System;
using System.IO;
using System.Linq;

namespace Lab4
{
    internal static class Program
    {
        private const string BasePath = "C:/Users/dnkov/tazasho/3/algo/Labs/Lab4/";

        public static void Main(string[] args)
        {
            var data = ReadGraphMatrix($"{BasePath}dijkstra_in.txt");
            Console.WriteLine(DijkstraAlgorithm.Dijkstra(data.Item1, data.Item2, data.Item3));
        }

        private static (int[,], int, int) ReadGraphMatrix(string path)
        {
            var lines = File.ReadLines(path).ToArray();
            
            var firstLine = lines[0].Split(' ');
            var verticesCount = int.Parse(firstLine[0]);
            var source = int.Parse(firstLine[1]);

            var graph = new int[verticesCount, verticesCount];

            for (var i = 1; i < lines.Length; i++)
            {
                var elements = lines[i].Split(' ');
                var row = int.Parse(elements[0]);
                var column = int.Parse(elements[1]);
                var cost = int.Parse(elements[2]);

                graph[row, column] = cost;
            }

            return (graph, source, verticesCount);
        }
    }
}