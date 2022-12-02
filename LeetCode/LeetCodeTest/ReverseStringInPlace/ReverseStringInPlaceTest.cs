using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.ReverseStringInPlace
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
