using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.LengthOfLongestSubString
{
    internal class LengthOfLongestSubStringTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "1101100111", 5 };
            yield return new object[] { "1101101110", 6 };
            yield return new object[] { "1111101110", 9 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
