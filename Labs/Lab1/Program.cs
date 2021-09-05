using System;
using System.Linq;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array =
                Array.ConvertAll(Console.ReadLine()?.Trim().Split(' ') ?? Array.Empty<string>(), Convert.ToInt32)
                    .Select(x => (IComparable)x);

            var sortResult = MergeSort.Sort(array);
            Console.WriteLine("Merging sort \n" +
                              $"result: {sortResult.Result.Aggregate("", (s, comparable) => s + " " + comparable)} \n" +
                              $"execution time: {sortResult.Time} \n" + 
                              $"comparisons: {sortResult.Comparisons} \n" +
                              $"swaps: {sortResult.Swaps}");
            
            Console.ReadKey();
        }
    }
}