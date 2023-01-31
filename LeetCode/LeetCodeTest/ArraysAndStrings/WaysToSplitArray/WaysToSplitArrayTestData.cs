using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.WaysToSplitArray
{
    internal class WaysToSplitArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 10, 4, -8, 7 }, 2 };
            yield return new object[] { new[] { 2, 3, 1, 0 }, 2 };
            yield return new object[] { new[] { 2, 1 }, 1 };
            yield return new object[] { new[] { 1, 1 }, 1 };
            yield return new object[] { new[] { -1, 1 }, 0 };            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
