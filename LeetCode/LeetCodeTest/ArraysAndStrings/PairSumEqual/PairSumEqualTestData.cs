using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.PairSumEqual
{
    internal class PairSumEqualTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 2, 7, 11, 15 }, 26, new[] { 11, 15 } };
            yield return new object[] { new[] { 2, 3, 4 }, 6, new[] { 2, 4 } };
            yield return new object[] { new[] { 1, 5, 7, 25, 39, 85, 89, 97, 99, 110 }, 138, new[] { 39, 99 } };
            yield return new object[] { new[] { 1, 3, 7, 9, 11, 15 }, 14, new[] { 3, 11 } };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
