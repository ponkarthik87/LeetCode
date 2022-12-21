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
            var finallength = 0;
            while (right < nums.Length)
            {
                if (sum <= k)
                {
                    sum += nums[right];
                    right++;
                    length++;
                }
                else
                {
                    finallength = length;
                    
                }
            }


            return 1;
        }
    }
}
