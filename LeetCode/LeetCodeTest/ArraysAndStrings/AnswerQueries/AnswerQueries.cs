namespace LeetCodeTest.ArraysAndStrings.AnswerQueries
{
    internal class AnswerQueries
    {
        internal bool[] AnswerQueriesFn(int[] nums, int[,] queries, int limit)
        {
            var sums = new int[nums.Length];
            sums[0] = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                sums[i] = sums[i - 1] + nums[i];
            }

            var result = new bool[queries.Length / 2];
            for (var i = 0; i < queries.Length / 2; i++)
            {
                var x = queries[i, 0];
                var y = queries[i, 1];
                result[i] = x <= y && sums[y] - (x == 0 ? x : sums[x - 1]) < limit;
            }

            return result;
        }
    }
}
