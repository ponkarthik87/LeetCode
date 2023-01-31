namespace LeetCodeTest.ArraysAndStrings.WaysToSplitArray
{
    internal class WaysToSplitArray
    {
        internal int WaysToSplitArrayFn(int[] nums)
        {
            var sums = new long[nums.Length];
            sums[0] = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                sums[i] = sums[i - 1] + nums[i];
            }

            var length = sums.Length - 1;
            var result = 0;
            for (var i = 0; i < length; i++)
            {
                if (sums[i] >= sums[length] - sums[i])
                {
                    result++;
                }
            }

            return result;
        }
    }
}
