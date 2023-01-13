using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.LargestAvgOfSubArray
{
    public class LargestAvgOfSubArrayTest
    {
        [Theory]
        [ClassData(typeof(LargestAvgOfSubArrayTestData))]
        public void LargestAvgOfSubArrayInitialTest(int[] input, int target, double expected)
        {
            LargestAvgOfSubArray LargestAvgOfSubArray = new();
            var actual = LargestAvgOfSubArray.LargestAvgOfSubArrayFn(input, target);
            actual.Should().Be(expected);
        }
    }
}
