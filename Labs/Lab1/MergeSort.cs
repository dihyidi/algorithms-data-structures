using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Lab1
{
    public class SortResult
    {
        public IComparable[] Result { get; set; }

        public int Swaps { get; set; } 
        
        public int Comparisons { get; set; }
        
        public TimeSpan Time { get; set; }
    }
    
    public static class MergeSort
    {
        public static SortResult Sort(IEnumerable<IComparable> array)
        {
            var comparables = array as IComparable[] ?? array.ToArray();
            var result = new SortResult
            {   
                Result = comparables
            };
            var timer = Stopwatch.StartNew();
            
            RecursiveMerge(result, 0, comparables.Length - 1);
            
            timer.Stop();
            result.Time = timer.Elapsed;
            return result;
        }
        
        private static void DoMerge(SortResult result, int left, int mid, int right)
        {
            var temp = new IComparable[result.Result.Length];
            int i;
            var array = result.Result;

            var leftEnd = mid - 1;
            var tmpPos = left;
            var numElements = right - left + 1;

            while (left <= leftEnd && mid <= right)
            {
                if (array[left].CompareTo(array[mid]) <= 0)
                {
                    temp[tmpPos++] = array[left++];
                }
                else
                {
                    temp[tmpPos++] = array[mid++];
                }
                result.Comparisons++;
            }

            while (left <= leftEnd)
            {
                temp[tmpPos++] = array[left++];
            }

            while (mid <= right)
            {
                temp[tmpPos++] = array[mid++];
            }

            for (i = 0; i < numElements; i++)
            {
                array[right] = temp[right];
                right--;
            }
        }

        private static void RecursiveMerge(SortResult result, int left, int right)
        {
            if (right <= left) return;

            var mid = (right + left) / 2;
            RecursiveMerge(result, left, mid);
            RecursiveMerge(result, mid + 1, right);

            DoMerge(result, left, mid + 1, right);
        }
    }
}