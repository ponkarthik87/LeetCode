using FluentAssertions;
using LeetCodeTest.ArraysAndStrings;

namespace LeetCodeTest.Hash.FirstLetterToAppearTwice
{
    public class FirstLetterToAppearTwiceTest
    {
        [Theory]
        [ClassData(typeof(FirstLetterToAppearTwiceTestData))]
        public void FirstLetterToAppearTwiceInitialTest(string s, char expected)
        {
            FirstLetterToAppearTwice firstLetterToAppearTwice = new();
            var result = firstLetterToAppearTwice.FirstLetterToAppearTwiceFn(s);
            result.Should().Be(expected);
        }
    }
}
