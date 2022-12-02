using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.RunningSumOf1D
{
    internal class RunningSumOf1D
    {
        internal int[]? RunningSumFn(int[]? nums)
        {
            for (var i = 1; i < nums?.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}
