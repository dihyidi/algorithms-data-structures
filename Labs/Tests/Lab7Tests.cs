using System.Collections.Generic;
using Lab7;
using Xunit;

namespace Tests
{
    public class Lab7Tests
    {
        [Fact]
        public void KmpSearch_ValidData_ReturnsListOfIndexes()
        {
            const string txt = "AABAACAADAABAABA";
            const string pat = "AABA";
            var expected = new List<int>() { 0, 9, 12 };

            var actual = KmpSearcher.Search(pat, txt);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void KmpSearch_NoMatches_ReturnsEmptyList()
        {
            const string txt = "AABAACAADAABAABA";
            const string pat = "Z";

            var actual = KmpSearcher.Search(pat, txt);
            
            Assert.Empty(actual);
        }
    }
}