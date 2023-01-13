using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.LargestAvgOfSubArray
{
    internal class LargestAvgOfSubArray
    {
        internal double LargestAvgOfSubArrayFn(int[] nums, int k)
        {
            var left = 0;
            var right = 0;
            var sum = 0;
            double finalSum = 0;
            while (right < nums.Length)
            {
                sum += nums[right];
                if (right - left == k - 1)
                {
                    finalSum = left == 0 ? sum : Math.Max(finalSum, sum);
                    sum -= nums[left];
                    left++;
                }

                right++;
            }

            return finalSum / k;
        }
    }
}
