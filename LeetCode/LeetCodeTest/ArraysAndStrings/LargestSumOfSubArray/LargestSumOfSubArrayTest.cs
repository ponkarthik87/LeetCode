using FluentAssertions;

namespace LeetCodeTest.ArraysAndStrings.LargestSumOfSubArray
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
