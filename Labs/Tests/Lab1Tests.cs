using System;
using System.Linq;
using Lab1;
using Xunit;

namespace Tests
{
    public class Lab1Tests
    {
        // n ⌈lg n⌉ − 2^⌈lg n⌉ + 1
        
        [Fact]
        public void SortByAsc_RandomInputArray_ReturnsSortedByAscArray()
        {
            //Arrange
            var order = OrderBy.ASC;
            var array = new IComparable[] { 88, 9, 3, 44, 5, 0, 78 };

            var expected = new IComparable[] { 0, 3, 5, 9, 44, 78, 88 };

            //Act
            var actual = MergeSort.Sort(array, order);

            //Assert
            Assert.Equal(expected, actual.Result);
        }
        
        [Fact]
        public void SortByDesc_RandomInputArray_ReturnsSortedByDescArray()
        {
            //Arrange
            var order = OrderBy.DESC;
            var array = new IComparable[] { 87,25,6,95,14,7 };

            var expected = new IComparable[] { 95,87,25,14,7,6 };

            //Act
            var actual = MergeSort.Sort(array, order).Result;

            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void SortByAsc_SortedByAscInputArray_ReturnsSameArray()
        {
            //Arrange
            var order = OrderBy.ASC;
            var array = new IComparable[] { 1,2,3,4,5,6,7,8,9 };

            //Act
            var actual = MergeSort.Sort(array, order).Result;

            //Assert
            Assert.Equal(array, actual);
        }
        
        [Fact]
        public void SortByDesc_SortedByDescInputArray_ReturnsSameArray()
        {
            //Arrange
            var order = OrderBy.ASC;
            var array = new IComparable[] { 9,8,7,6,5,4,3,2,1 };

            //Act
            var actual = MergeSort.Sort(array, order).Result;

            //Assert
            Assert.Equal(array, actual);
        }
        
        [Fact]
        public void SortByAsc_SortedByDescInputArray_ReturnsReversedArray()
        {
            //Arrange
            var order = OrderBy.ASC;
            var array = new IComparable[] { 9,8,7,6,5,4,3,2,1 };
            var expected = array.Reverse().ToArray();

            //Act
            var actual = MergeSort.Sort(array, order).Result;

            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void SortByDesc_SortedByAscInputArray_ReturnsReversedArray()
        {
            //Arrange
            var order = OrderBy.DESC;
            var array = new IComparable[] { 1,2,3,4,5,6,7,8,9 };
            var expected = array.Reverse().ToArray();

            //Act
            var actual = MergeSort.Sort(array, order).Result;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
