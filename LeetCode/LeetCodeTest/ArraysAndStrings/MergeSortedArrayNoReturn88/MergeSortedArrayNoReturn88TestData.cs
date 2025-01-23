using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.MergeSortedArrayNoReturn88
{
    internal class MergeSortedArrayNoReturn88TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] { 2, 7, 11, 15, 0, 0, 0, 0 }, 4, new[] { 5, 9, 12, 21 }, 4,
                MergeAndSort(new[] { 2, 7, 11, 15 }, new[] { 5, 9, 12, 21 })
            };
            yield return new object[]
            {
                new[] { 1, 2, 3, 4, 0, 0, 0, 0 }, 4, new[] { 0, 3, 4, 7 }, 4,
                MergeAndSort(new[] { 1, 2, 3, 4 }, new[] { 0, 3, 4, 7 })
            };
            yield return new object[]
            {
                new[] { -11, -9, 5, 18, 99, 0, 0, 0, 0 }, 5, new[] { 5, 9, 12, 21 }, 4,
                MergeAndSort(new[] { -11, -9, 5, 18, 99 }, new[] { 5, 9, 12, 21 })
            };
            yield return new object[]
            {
                new[] { 1, 1, 1, 5, 7, 0, 0, 0, 0, 0, 0 }, 5, new[] { 2, 2, 6, 6, 7, 7 }, 6,
                MergeAndSort(new[] { 1, 1, 1, 5, 7 }, new[] { 2, 2, 6, 6, 7, 7 })
            };
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