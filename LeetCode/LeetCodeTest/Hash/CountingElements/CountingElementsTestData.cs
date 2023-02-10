using System.Collections;

namespace LeetCodeTest.Hash.CountingElements
{
    public class CountingElementsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 1, 2, 3 }, 2 };
            yield return new object[] { new[] { 1, 1, 3, 3, 5, 5, 7, 7 }, 0 };
            yield return new object[] { new[] { 1, 3, 2, 3, 5, 0 }, 3 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
