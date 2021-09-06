using System;
using System.Linq;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Enum.TryParse(args[0].ToUpper(), out OrderBy order);
            
            var array =
                Array.ConvertAll(args[1].Trim().Split(','), Convert.ToInt32)
                    .Select(x => (IComparable)x);

            var sortResult = MergeSort.Sort(array, order);
            Console.WriteLine("Merging sort \n" +
                              $"result: {sortResult.Result.Aggregate("", (s, comparable) => s + " " + comparable)} \n" +
                              $"execution time: {sortResult.Time} \n" + 
                              $"comparisons: {sortResult.Comparisons} \n" +
                              $"swaps: {sortResult.Swaps}");
            
            Console.ReadKey();
        }
    }
}