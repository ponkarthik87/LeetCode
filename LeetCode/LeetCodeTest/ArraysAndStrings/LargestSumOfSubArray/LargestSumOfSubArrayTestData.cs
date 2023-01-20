using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.LargestSumOfSubArray
{
    internal class LargestSumOfSubArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 3, -1, 4, 12, -8, 5, 6 }, 4, 18 };
            yield return new object[] { new[] { 3, -1 }, 2, 2 };
            yield return new object[] { new[] { 0 }, 1, 0 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
