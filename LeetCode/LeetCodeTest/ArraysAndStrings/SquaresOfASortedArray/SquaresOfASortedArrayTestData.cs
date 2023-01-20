using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.SquaresOfASortedArray
{
    internal class SquaresOfASortedArrayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { -4, -1, 0, 3, 10 }, new[] { 0, 1, 9, 16, 100 } };
            yield return new object[] { new[] { -5, -3, -2, -1 }, new[] { 1, 4, 9, 25 } };
            yield return new object[] { new[] { -7, -3, 2, 3, 11 }, new[] { 4, 9, 9, 49, 121 } };
            yield return new object[] { new[] { 2 }, new[] { 4 } };
            yield return new object[] { new[] { 2, 4 }, new[] { 4, 16 } };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
