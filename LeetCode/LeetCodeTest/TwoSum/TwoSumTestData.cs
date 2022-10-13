using System.Collections;

namespace LeetCodeTest;

public class TwoSumTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 } };
        yield return new object[] { new[] { 3, 2, 4 }, 6, new[] { 1, 2 } };
        yield return new object[] { new[] { 3, 3}, 6, new[] { 0, 1 } };
        yield return new object[] { new[] { 1, 3, 4, 2 }, 6, new[] { 2, 3 } };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
