using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6
{
    public static class BinarySeparator
    {
        public static int FindSolution(string binaryString, int number)
            => FindQuantityOfBinaryPows(binaryString, FindNumberSquares(binaryString, number));
        
        private static IEnumerable<string> FindNumberSquares(string binaryString, int number)
        {
            var squares = new List<string>();
            var binaryNum = string.Empty;

            for (var i = 0; binaryNum.Length < binaryString.Length; i++)
            {
                binaryNum = Convert.ToString((int) Math.Pow(number, i), 2);
                squares.Add(binaryNum);
            }
            return squares;
        }

        private static int FindQuantityOfBinaryPows(string binaryString, IEnumerable<string> squares)
        {
            var res = 0;
            var currentBinary = new StringBuilder();
            
            foreach (var ch in binaryString)
            {
                currentBinary.Append(ch);
                for (var j = 0; j < squares.Count(); j++)
                {
                    var currentBinaryStr = currentBinary.ToString();
                    if (!currentBinaryStr.Equals(squares.ElementAt(j)) || currentBinaryStr.Equals("1")) 
                        continue;
                    res++;
                    currentBinary.Clear();
                }
            }
            if (currentBinary.ToString().Equals("1"))
                res++;
            
            return res > 0 ? res : -1;
        }
        
    }
}