namespace LeetCodeTest.ArraysAndStrings.MaxConsecutiveOnes3
{
    internal class MaxConsecutiveOnes3
    {
        internal int MaxConsecutiveOnes3Fn(int[] nums, int k)
        {
            var left = 0;
            var right = 0;
            var length = 0;
            var zeroCounter = 0;
            var currentPosition = 0;
            var isFirstRun = true;
            var zeroPositions = new List<int>();
            while (right < nums.Length)
            {
                if (nums[right] == 0)
                {
                    zeroPositions.Add(right);
                    zeroCounter++;
                    if (zeroCounter == k + 1 || right == nums.Length - 1)
                    {
                        var addValue = isFirstRun ? 0 : 1;
                        addValue = right == nums.Length - 1 && isFirstRun ? -1 : addValue;
                        length = Math.Max(length, (right - (left + (addValue))));
                        isFirstRun = false;
                        left = zeroPositions[currentPosition];
                        currentPosition++;
                        zeroCounter--;
                    }
                }
                else if (right == nums.Length - 1)
                {
                    length = Math.Max(length, (right - (left + (isFirstRun ? -1 : 0))));
                }

                right++;
            }

            return length;
        }
    }
}
