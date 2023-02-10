using System.Collections;

namespace LeetCodeTest.Hash.NotOnePlusOrMinus
{
    public class NotOnePlusOrMinusTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 1, 0, 2, 6, 8, 9, 3 }, new List<int> { 6 } };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
