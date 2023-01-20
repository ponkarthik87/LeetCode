using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.IsSequence
{
    internal class IsSequenceTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "abc", "ahbgdc", true };
            yield return new object[] { "axc", "ahbgdc", false };
            yield return new object[] { "abc", "abc", true };
            yield return new object[] { "ahbgdc", "abc", false };
            yield return new object[] { "", "abc", true };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
