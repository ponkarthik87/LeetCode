using FluentAssertions;

namespace LeetCodeTest.ArraysAndStrings.AnswerQueries
{
    public class AnswerQueriesTest
    {
        [Theory]
        [ClassData(typeof(AnswerQueriesTestData))]
        public void AnswerQueriesInitialTest(int[] nums, int[,] queries, int limit, bool[] expected)
        {
            AnswerQueries answerQueries = new();
            var actual = answerQueries.AnswerQueriesFn(nums, queries, limit);
            actual.Should().Equal(expected);
        }
    }
}
