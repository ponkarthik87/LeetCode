﻿using FluentAssertions;

namespace LeetCodeTest.ArraysAndStrings.RunningSumOf1D
{
    public class RunningSumOf1DTest
    {
        [Theory]
        [ClassData(typeof(RunningSumOf1DTestData))]
        public void RunningSumOf1DInitialTest(int[] input, int[] expected)
        {
            RunningSumOf1D runningSumOf1D = new();
            var actual = runningSumOf1D.RunningSumFn(input);
            actual.Should().Equal(expected);
        }
    }
}
