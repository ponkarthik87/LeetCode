using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.MaxConsecutiveOnes3
{
    public class MaxConsecutiveOnes3Test
    {
        [Theory]
        [ClassData(typeof(MaxConsecutiveOnes3TestData))]
        public void MaxConsecutiveOnes3InitialTest(int[] input, int k, int expected)
        {
            MaxConsecutiveOnes3 MaxConsecutiveOnes3 = new();
            var actual = MaxConsecutiveOnes3.MaxConsecutiveOnes3Fn(input,k);
            actual.Should().Be(expected);
        }
    }
}
