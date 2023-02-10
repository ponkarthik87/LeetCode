using System.Collections;

namespace LeetCodeTest.Hash.MissingNumber
{
    public class MissingNumberTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 3, 0, 1 }, 2 };
            yield return new object[] { new[] { 0, 1 }, 2 };
            yield return new object[] { new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
