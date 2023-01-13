using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.LargestSumOfSubArray
{
    public class LargestSumOfSubArrayTest
    {
        [Theory]
        [ClassData(typeof(LargestSumOfSubArrayTestData))]
        public void LargestSumOfSubArrayInitialTest(int[] input, int target, int expected)
        {
            LargestSumOfSubArray largestSumOfSubArray = new();
            var actual = largestSumOfSubArray.LargestSumOfSubArrayFn(input, target);
            actual.Should().Be(expected);
        }
    }
}
