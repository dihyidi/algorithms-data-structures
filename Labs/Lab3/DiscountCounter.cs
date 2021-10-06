using System;
using System.Linq;

namespace Lab3
{
    public static class DiscountCounter
    {
        public static double Count(int[] prices, int discount)
        {
            var third = prices.Length / 3;
            var tmp = prices.Select(x => (double)x).ToArray();
            
            FindKthLargest(tmp, third);

            for (int i = prices.Length - 1, x = 0; x < third; x++, i--)
            {
                tmp[i] *= discount*0.01;
            }

            return tmp.Sum();
        }

        private static double FindKthLargest(double[] nums, int k)
        {
            return QuickSelect(nums, 0, nums.Length - 1, nums.Length - k);
        }

        private static double QuickSelect(double[] nums, int left, int right, int k)
        {
            while (true)
            {
                var pivotIndex = Partition(nums, left, right);
                if (k == pivotIndex) return nums[pivotIndex];
                if (k < pivotIndex)
                {
                    right = pivotIndex - 1;
                    continue;
                }

                left = pivotIndex + 1;
            }
        }


        private static void Swap(ref double a, ref double b)
            => (a, b) = (b, a);

        private static int Partition(double[] arr, int left, int right)
        {
            var pivotIndex = new Random().Next(left, right);
            var pivotValue = arr[pivotIndex];
            
            Swap(ref arr[pivotIndex], ref arr[right]);

            var originalRight = right;
            
            while (left < right)
            {
                if (arr[left].CompareTo(pivotValue) > 0)
                {
                    Swap(ref arr[left], ref arr[--right]);
                }
                else left++;
            }

            Swap(ref arr[right], ref arr[originalRight]);

            return right;
        }
        
    }
}