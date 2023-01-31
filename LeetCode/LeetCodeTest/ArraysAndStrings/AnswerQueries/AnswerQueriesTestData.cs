using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.AnswerQueries
{
    internal class AnswerQueriesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 1, 6, 3, 2, 7, 2 }, new[,] { { 0, 3 }, { 2, 5 }, { 2, 4 } }, 13, new[] { true, false, true } };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
