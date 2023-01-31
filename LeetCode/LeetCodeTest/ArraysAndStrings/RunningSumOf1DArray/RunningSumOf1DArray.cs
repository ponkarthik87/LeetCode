namespace LeetCodeTest.ArraysAndStrings.RunningSumOf1DArray
{
    internal class RunningSumOf1DArray
    {
        internal int[] RunningSumOf1DArrayFn(int[] nums)
        {
            for (var i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] + nums[i];
            }

            return nums;
        }
    }
}
