namespace LeetCodeTest.SquaresOfASortedArray
{
    internal class SquaresOfASortedArray
    {
        // public int[] SquaresOfASortedArrayFn(int[] nums)
        // {
        //     var left = 0;
        //     var right = nums.Length - 1;
        //     nums[left] *= nums[left];
        //     nums[right] *= nums[right];
        //     while (left < right)
        //     {
        //         if (nums[left] > nums[right])
        //         {
        //             (nums[left], nums[right]) = (nums[right], nums[left]);
        //             left++;
        //             if (left < right)
        //             {
        //                 nums[left] *= nums[left];
        //             }
        //         }
        //         else
        //         {
        //             right--;
        //             if (left < right)
        //             {
        //                 nums[right] *= nums[right];
        //             }
        //         }
        //     }
        //
        //     return nums;
        // }

        public int[] SquaresOfASortedArrayFn(int[] nums)
        {
            if (nums.Length == 1)
            {
                nums[0] *= nums[0];
                return nums;
            }

            int[] result = new int[nums.Length];
            var left = 0;
            var right = nums.Length - 1;
            var resultIndex = nums.Length - 1;
            nums[left] *= nums[left];
            nums[right] *= nums[right];
            while (left < right)
            {
                if (nums[left] > nums[right])
                {
                    result[resultIndex] = nums[left];
                    left++;
                    resultIndex--;
                    if (left == right)
                    {
                        result[resultIndex] = nums[right];
                        break;
                    }

                    nums[left] *= nums[left];
                }
                else
                {
                    result[resultIndex] = nums[right];
                    right--;
                    resultIndex--;
                    if (left == right)
                    {
                        result[resultIndex] = nums[right];
                        break;
                    }

                    nums[right] *= nums[right];
                }
            }

            return result;
        }
    }
}
