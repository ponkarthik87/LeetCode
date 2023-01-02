using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.LengthOfLongestSubArray
{
    internal class LengthOfLongestSubArray
    {
        internal int LengthOfLongestSubArrayFn(int[] nums, int k)
        {
            var left = 0;
            var right = 0;
            var sum = 0;
            var length = 0;
            var finalLength = 0;
            while (right < nums.Length)
            {
                if (k >= sum)
                {
                    sum += nums[right];
                    right++;
                    length++;
                    finalLength = finalLength > length ? finalLength : length;
                }
                else
                {
                    length--;
                    sum -= nums[left];
                    left++;
                }
            }

            return finalLength - 1;
        }
        
        internal int LengthOfLongestSubArrayFn1(int[] nums, int k)
        {
            var left = 0;
            var curr = 0;
            var ans = 0;

            for (var right = 0; right < nums.Length; right++) {
                curr += nums[right];
                while (curr > k) {
                    curr -= nums[left];
                    left++;
                }

                ans = Math.Max(ans, right - left + 1);
            }

            return ans;
        }
    }
}
