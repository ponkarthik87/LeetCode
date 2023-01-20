using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.LengthOfLongestSubArray
{
    internal class LengthOfLongestSubArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 3, 1, 2, 7, 4, 2, 1, 1, 5 }, 8, 4 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
