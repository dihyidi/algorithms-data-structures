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
                .Select(x => (int)x).AsEnumerable().Select(x => (double)x).ToArray();

            for (int i = prices.Count - 1, x = 0; x < third; x++, i--)
            {
                sortedPrices[i] *= discount * 0.01;
            }
            
            double sum = 0;
            foreach (var price in sortedPrices)
            {
                sum += price;
            }

            // var discountedPrices = sortedPrices
            //     .TakeLast(third)
            //     .Select(x => x * (0.01 * discount));
            //
            // var sum = sortedPrices
            //               .SkipLast(third).Sum(x => x)
            //           + discountedPrices.Sum();
            //
             return sum;
        }
    }
}