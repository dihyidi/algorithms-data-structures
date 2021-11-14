using Lab6;
using Xunit;

namespace Tests
{
    public class Lab6Tests
    {
        [Fact]
        public void BinarySeparator_ValidString_ReturnsNum()
        {
            var expected = 3;
            var actual = BinarySeparator.FindSolution("110011011", 5);
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void BinarySeparator_InvalidString_ReturnsNoRes()
        {
            var expected = -1;
            var actual = BinarySeparator.FindSolution("111011", 5);
            Assert.Equal(expected, actual);
        }
    }
}