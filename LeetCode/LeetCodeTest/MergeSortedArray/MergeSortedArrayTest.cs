using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.MergeSortedArray
{
    public class MergeSortedArrayTest
    {
        [Theory]
        [ClassData(typeof(MergeSortedArrayTestData))]
        public void MergeSortedArrayInitialTest(int[] input1, int[] input2, int[] expeted)
        {
            MergeSortedArray mergeSortedArray = new();
            var actual = mergeSortedArray.MergeSortedArrayFn(input1, input2);
            actual.Should().Equal(expeted);
        }
    }
}
