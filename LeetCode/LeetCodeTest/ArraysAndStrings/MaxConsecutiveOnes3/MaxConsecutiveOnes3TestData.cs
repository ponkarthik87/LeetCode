using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.MaxConsecutiveOnes3
{
    internal class MaxConsecutiveOnes3TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2, 6 };
            yield return new object[] { new[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3, 10 };
            yield return new object[] { new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 2, 16 };
            yield return new object[] { new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, 1, 11 };
            yield return new object[] { new[] { 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1 }, 1, 11 };
            yield return new object[] { new[] { 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0 }, 2, 11 };
            // yield return new object[] { new[] { 1, 1 }, 4, 0 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
