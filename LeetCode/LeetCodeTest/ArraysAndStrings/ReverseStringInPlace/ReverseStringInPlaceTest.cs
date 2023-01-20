using FluentAssertions;

namespace LeetCodeTest.ArraysAndStrings.ReverseStringInPlace
{
    public class ReverseStringInPlaceTest
    {
        [Theory]
        [ClassData(typeof(ReverseStringInPlaceTestData))]
        public void ReverseStringInPlaceInitialTest(char[] input, char[] expected)
        {
            ReverseStringInPlace reverseStringInPlace = new();
            var actual = reverseStringInPlace.ReverseStringInPlaceFn(input);
            actual.Should().Equal(expected);
        }

        [Theory]
        [ClassData(typeof(ReverseStringInPlaceTestData))]
        public void ReverseStringInPlaceNewTest(char[] input, char[] expected)
        {
            ReverseStringInPlace reverseStringInPlace = new();
            var actual = reverseStringInPlace.ReverseStringInPlaceNewFn(input);
            actual.Should().Equal(expected);
        }
    }
}
