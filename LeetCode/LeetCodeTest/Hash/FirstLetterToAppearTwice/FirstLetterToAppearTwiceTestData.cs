using System.Collections;

namespace LeetCodeTest.Hash.FirstLetterToAppearTwice
{
    public class FirstLetterToAppearTwiceTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "abccbaacz", 'c' };
            yield return new object[] { "abcdd", 'd' };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
