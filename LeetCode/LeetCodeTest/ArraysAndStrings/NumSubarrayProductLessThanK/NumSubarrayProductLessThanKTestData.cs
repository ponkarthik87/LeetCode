using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.NumSubarrayProductLessThanK
{
    internal class NumSubarrayProductLessThanKTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 10, 5, 2, 6 }, 100, 8 };
            yield return new object[] { new[] { 1, 2, 3 }, 0, 0 };
            yield return new object[] { new[] { 1, 2, 3 }, 1, 0 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
