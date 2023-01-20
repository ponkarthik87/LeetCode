using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.LargestAvgOfSubArray
{
    internal class LargestAvgOfSubArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75000 };
            yield return new object[] { new[] { 5 }, 1, 5.00000 };
            yield return new object[] { new[] { 0 }, 1, 0 };
            yield return new object[] { new[] { -1 }, 1, -1 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
