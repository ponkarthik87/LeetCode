using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.MaxConsecutiveOnes3
{
    internal class MaxConsecutiveOnes3
    {
        internal int MaxConsecutiveOnes3Fn(int[] nums, int k)
        {
            var left = 0;
            var right = 0;
            var length = 0;
            var zeroCounter = 0;
            var currentPosition = 0;
            var zeroPositions = new List<int>();
            while (right < nums.Length)
            {
                if (nums[right] == 0)
                {
                    zeroPositions.Add(right);
                    zeroCounter++;
                    if (zeroCounter == k + 1)
                    {
                        length = Math.Max(length, (right - left));
                        left = zeroPositions[currentPosition];
                        currentPosition++;
                        zeroCounter--;
                    }
                }

                right++;
            }

            return length;
        }
    }
}
