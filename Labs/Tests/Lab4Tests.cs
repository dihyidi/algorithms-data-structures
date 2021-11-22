using Lab4;
using Xunit;

namespace Tests
{
    public class Lab4Tests
    {
        [Fact]
        public void Dijkstra_ReturnsAvgPath()
        {
            var graph = new int[,]
            {
                {0, 1, 2, 0, 0, 0},
                {1, 0, 0, 5, 1, 0},
                {2, 0, 0, 2, 3, 0},
                {0, 5, 2, 0, 2, 2},
                {0, 1, 3, 2, 0, 1},
                {0, 0, 0, 2, 1, 0}
            };
            var source = 0;
            var verticesCount = 6;

            var expected = 2.4;

            var actual = DijkstraAlgorithm.Dijkstra(graph, source, verticesCount);
            
            Assert.Equal(expected, actual);
        }
    }
}