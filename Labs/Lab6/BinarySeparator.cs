using System;
using System.Collections.Generic;

namespace Lab6
{
    public static class BinarySeparator
    {

        public static int FindSolution(string binaryString, int number)
        {
            var res = FindSplits(binaryString, FindNumberPowers(binaryString, number));
            return res > 0 ? res : -1;
        }

        private static List<string> FindNumberPowers(string binaryString, int number)
        {
            var powers = new List<string>();

            if (number == 1)
            {
                powers.Add("1");
                return powers;
            }
            
            var pow = 0;
            var binNum = Convert.ToInt32(binaryString, 2);
            
            for (var i = 0; pow < binNum; i++)
            {
                pow = (int)Math.Pow(number, i);
                powers.Add(Convert.ToString(pow, 2));
            }
            return powers;
        }

        private static int FindSplits(string binaryString, List<string> powers)
        {
            var res = 0;
            
            if (string.IsNullOrEmpty(binaryString)) return -1;

            for (var i = binaryString.Length; i > 0; i--)
            {
                var element = binaryString[..i];
                if (!powers.Contains(element)) continue;
                
                if (i == binaryString.Length) return 1;
                
                var newBin = binaryString.Remove(0, i);
                var subRes = FindSplits(newBin, powers);
                if (subRes > 0 && res <= 0)
                {
                    res = subRes + 1;
                }
            }

            return res;
        }
    }
}