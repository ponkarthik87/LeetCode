using FluentAssertions;

namespace LeetCodeTest.ArraysAndStrings.LengthOfLongestSubArray
{
    public class LengthOfLongestSubArrayTest
    {
        [Theory]
        [ClassData(typeof(LengthOfLongestSubArrayTestData))]
        public void LengthOfLongestSubArrayInitialTest(int[] input, int target, int expected)
        {
            LengthOfLongestSubArray lengthOfLongestSubArray = new();
            var actual = lengthOfLongestSubArray.LengthOfLongestSubArrayFn(input, target);
            actual.Should().Be(expected);
        }
    }
}
