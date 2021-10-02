using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3
{
    internal static class Program
    {
        private static readonly string _basePath = "C:/Users/dnkov/tazasho/3/algo/Labs/Lab3/";
        private static async Task Main(string[] args)
        {
            var data = await ReadFileAsync($"{_basePath}discnt_in.txt");

            var prices = ConvertStringToInt(data[0]);
            var discount = ConvertStringToInt(data[1]);

            var res = DiscountCounter.Count(prices, discount.First());

            await WriteFileAsync($"{_basePath}discnt_out.txt", res.ToString());
        }

        private static Task<string[]> ReadFileAsync(string path)
        {
            return File.ReadAllLinesAsync(path);
        }

        private static Task WriteFileAsync(string path, string data)
        {
            return File.WriteAllTextAsync(path, data);
        }

        private static List<int> ConvertStringToInt(string str)
        {
            return str.Split(' ').Select(int.Parse).ToList();
        }
    }
}