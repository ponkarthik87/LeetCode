namespace LeetCodeTest.ArraysAndStrings.LargestSumOfSubArray
{
    internal class LargestSumOfSubArray
    {
        internal int LargestSumOfSubArrayFn(int[] nums, int k)
        {
            var left = 0;
            var right = 0;
            var sum = 0;
            var finalSum = 0;
            while (right < nums.Length)
            {
                sum += nums[right];
                if (right - left == k - 1)
                {
                    finalSum = Math.Max(finalSum, sum);
                    sum -= nums[left];
                    left++;
                }

                right++;
            }

            return finalSum;
        }
    }
}
