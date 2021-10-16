using System.Linq;

namespace Lab4
{
    public static class DijkstraAlgorithm
    {
        private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            var min = int.MaxValue;
            var minIndex = 0;

            for (var v = 0; v < verticesCount; ++v)
                if (!shortestPathTreeSet[v] && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }

            return minIndex;
        }

        public static double Dijkstra(int[,] graph, int source, int verticesCount)
        {
            var distance = new int[verticesCount];
            var shortestPathTreeSet = new bool[verticesCount];

            for (var i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (var count = 0; count < verticesCount; ++count)
            {
                var u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for (var v = 0; v < verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && graph[u, v] > 0 && distance[u] != int.MaxValue &&
                        distance[u] + graph[u, v] < distance[v])
                        distance[v] = distance[u] + graph[u, v];
            }

            var distances = distance
                .Where(x => x != int.MaxValue && x > 0)
                .Select(x => (double)x);
            
            return distances.Sum() / distances.Count();
        }
    }
}