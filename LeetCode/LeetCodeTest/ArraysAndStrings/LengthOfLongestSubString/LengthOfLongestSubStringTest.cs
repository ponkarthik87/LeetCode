using FluentAssertions;

namespace LeetCodeTest.ArraysAndStrings.LengthOfLongestSubString
{
    public class LengthOfLongestSubStringTest
    {
        [Theory]
        [ClassData(typeof(LengthOfLongestSubStringTestData))]
        public void LengthOfLongestSubArrayInitialTest(string input, int expected)
        {
            LengthOfLongestSubString lengthOfLongestSubString = new();
            var actual = lengthOfLongestSubString.LengthOfLongestSubStringFn(input);
            actual.Should().Be(expected);
        }
    }
}
