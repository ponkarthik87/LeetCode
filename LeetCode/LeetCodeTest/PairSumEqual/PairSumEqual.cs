using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.PairSumEqual
{
    internal class PairSumEqual
    {
        internal int[] PairSumEqualFn(int[] input, int target)
        {
            for (int left = 0, right = input.Length - 1; left < right;)
            {
                if (input[left] + input[right] == target)
                {
                    return new[] { input[left], input[right] };
                }
                if (input[left] + input[right] < target)
                {
                    left++;
                }

                if (input[left] + input[right] > target)
                {
                    right--;
                }
            }
            return Array.Empty<int>();
        }
    }
}
