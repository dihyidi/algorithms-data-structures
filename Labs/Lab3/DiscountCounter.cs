using System;
using System.Collections.Generic;
using System.Linq;
using Lab1;

namespace Lab3
{
    public static class DiscountCounter
    {
        public static double Count(List<int> prices, int discount)
        {
            var third = prices.Count / 3;

            var sortedPrices = MergeSort.Sort(prices.Select(x => (IComparable)x), OrderBy.ASC).Result
                .Select(x => (int)x).ToArray();

            var discountedPrices = sortedPrices
                .TakeLast(third)
                .Select(x => x * (0.01 * discount));

            var sum = sortedPrices
                          .SkipLast(third).Sum(x => x)
                      + discountedPrices.Sum();

            return sum;
        }
    }
}