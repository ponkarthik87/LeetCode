using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.MergeSortedArray
{
    internal class MergeSortedArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 2, 7, 11, 15 }, new[] { 5, 9, 12, 21 }, MergeAndSort(new[] { 2, 7, 11, 15 }, new[] { 5, 9, 12, 21 }) };
            yield return new object[] { new[] { 1, 2, 3, 4 }, new[] { 0, 3, 4, 7 }, MergeAndSort(new[] { 1, 2, 3, 4 }, new[] { 0, 3, 4, 7 }) };
            yield return new object[] { new[] { -11, -9, 5, 18, 99 }, new[] { 5, 9, 12, 21 }, MergeAndSort(new[] { -11, -9, 5, 18, 99 }, new[] { 5, 9, 12, 21 }) };
            yield return new object[] { new[] { 1, 1, 1, 5, 7 }, new[] { 2, 2, 6, 6, 7, 7 }, MergeAndSort(new[] { 1, 1, 1, 5, 7 }, new[] { 2, 2, 6, 6, 7, 7 }) };

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        int[] MergeAndSort(int[] input1, int[] input2)
        {
            var result = input1.Concat(input2).ToArray();
            Array.Sort(result);
            return result;

        }
    }
}
