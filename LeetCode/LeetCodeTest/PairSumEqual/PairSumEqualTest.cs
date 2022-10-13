using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.PairSumEqual
{
    public class PairSumEqualTest
    {
        [Theory]
        [ClassData(typeof(PairSumEqualTestData))]
        public void PairSumEqualInitialTest(int[] input, int target, int[] expeted)
        {
            PairSumEqual pairSumEqual = new();
            var actual = pairSumEqual.PairSumEqualFn(input, target);
            actual.Should().Equal(expeted);
        }
    }
}
