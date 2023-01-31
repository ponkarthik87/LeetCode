using FluentAssertions;

namespace LeetCodeTest.ArraysAndStrings.WaysToSplitArray
{
    public class WaysToSplitArrayTest
    {
        [Theory]
        [ClassData(typeof(WaysToSplitArrayTestData))]
        public void WaysToSplitArrayInitialTest(int[] nums, int expected)
        {
            WaysToSplitArray waysToSplitArray = new();
            var actual = waysToSplitArray.WaysToSplitArrayFn(nums);
            actual.Should().Be(expected);
        }
    }
}
