using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.NumSubarrayProductLessThanK
{
    internal class NumSubarrayProductLessThanK
    {
        internal int NumSubarrayProductLessThanKFn(int[] nums, int k)
        {
            var left = 0;
            var right = 0;
            var sum = 1;
            var length = 0;
            while (right < nums.Length && left < nums.Length)
            {
                sum *= nums[right];
                if (sum < k)
                {
                    length++;
                    right++;
                }
                else
                {
                    sum = 1;
                    left++;
                    right = left;
                }

                if (right == nums.Length && right != left)
                {
                    sum = 1;
                    left++;
                    right = left;
                }
            }

            return length;
        }

        internal int NumSubarrayProductLessThanKFn1(int[] nums, int k)
        {
            if (k <= 1)
            {
                return 0;
            }

            var ans = 0;
            var left = 0;
            var curr = 1;

            for (var right = 0; right < nums.Length; right++)
            {
                curr *= nums[right];
                while (left <= right && curr >= k)
                {
                    curr /= nums[left];
                    left++;
                }

                ans += right - left + 1;
            }

            return ans;
        }
    }
}
