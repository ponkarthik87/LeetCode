using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.ReverseStringInPlace
{
    internal class ReverseStringInPlaceTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 'h','e','l','l','o' },  new[] { 'o','l','l','e','h' } };
            yield return new object[] { new[] { 'H','a','n','n','a','h' },  new[] { 'h','a','n','n','a','H' } };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
