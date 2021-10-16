using System.Collections.Generic;
using Lab3;
using Xunit;

namespace Tests
{
    public class Lab3Tests
    {
        [Fact]
        public void DiscountCounterCount_ReturnsMinSum()
        {
            //arrange
            var prices = new int[] { 10, 9, 7, 8, 3, 2, 1, 4, 5, 6, 12, 13, 11, 14 };
            var discount = 40;

            var expected = 75;
            
            //act
            var actual = DiscountCounter.Count(prices, discount);
            
            //assert
            Assert.Equal(expected, actual);
        }
    }
}