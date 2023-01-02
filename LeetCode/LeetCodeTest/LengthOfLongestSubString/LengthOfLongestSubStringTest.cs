using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.LengthOfLongestSubString
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
