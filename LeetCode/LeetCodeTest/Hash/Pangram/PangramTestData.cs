using System.Collections;

namespace LeetCodeTest.Hash.Pangram
{
    public class PangramTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "thequickbrownfoxjumpsoverthelazydog", true };
            yield return new object[] { "leetcode", false };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
