using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.LengthOfLongestSubArray
{
    public class LengthOfLongestSubArrayTest
    {
        [Theory]
        [ClassData(typeof(LengthOfLongestSubArrayTestData))]
        public void PairSumEqualInitialTest(int[] input, int target, int expected)
        {
            LengthOfLongestSubArray pairSumEqual = new();
            var actual = pairSumEqual.LengthOfLongestSubArrayFn(input, target);
            actual.Should().Be(expected);
        }
    }
}
