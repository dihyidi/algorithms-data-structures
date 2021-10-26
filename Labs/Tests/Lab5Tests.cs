using System.Collections.Generic;
using lab_5;
using Xunit;

namespace Tests
{
    public class Lab5Tests
    {
        [Fact]
        public void TarjanAlgo_ReturnsStronglyConnectedComponents()
        {
            var graph = new List<int>[]
            {
                new() { 0, 1 },
                new() { 0 },
                new() { 1 }
            };
            var expected = new List<List<int>>
            {
                new() { 1, 0 },
                new() { 2 }
            };
            var actual = new SccTarjan(graph).Scc();

            Assert.Equal(expected, actual);
        }
    }
}