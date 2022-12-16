using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.SquaresOfASortedArray
{
    public class SquaresOfASortedArrayTest
    {
        [Theory]
        [ClassData(typeof(SquaresOfASortedArrayTestData))]
        public void SquaresOfASortedArrayInitialTest(int[] input, int[] expected)
        {
            SquaresOfASortedArray squaresOfASortedArray = new();
            var actual = squaresOfASortedArray.SquaresOfASortedArrayFn(input);
            actual.Should().Equal(expected);
        }

        // [Theory]
        // [ClassData(typeof(SquaresOfASortedArrayTestData))]
        // public void SquaresOfASortedArrayNewTest(char[] input, char[] expected)
        // {
        //     SquaresOfASortedArray SquaresOfASortedArray = new();
        //     var actual = SquaresOfASortedArray.SquaresOfASortedArrayNewFn(input);
        //     actual.Should().Equal(expected);
        // }
    }
}
