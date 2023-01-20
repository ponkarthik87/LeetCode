using FluentAssertions;

namespace LeetCodeTest.ArraysAndStrings.LargestAvgOfSubArray
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
