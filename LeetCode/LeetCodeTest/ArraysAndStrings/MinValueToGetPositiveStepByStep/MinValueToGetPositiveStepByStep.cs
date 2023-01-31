namespace LeetCodeTest.ArraysAndStrings.MinValueToGetPositiveStepByStep
{
    internal class MinValueToGetPositiveStepByStep
    {
        internal int MinValueToGetPositiveStepByStepFn(int[] nums)
        {
            var minValue = nums[0];
            for (var i = 1; i < nums?.Length; i++)
            {
                nums[i] += nums[i - 1];
                minValue = Math.Min(minValue, nums[i]);
            }

            if (minValue >= 0) return 1;

            return (-minValue) + 1;
        }
    }
}
