namespace LeetCodeTest.ArraysAndStrings.MergeSortedArrayNoReturn88
{
    internal class MergeSortedArrayNoReturn88
    {
        internal int[] MergeSortedArrayFn(int[] nums1, int m, int[] nums2, int n)
        {
            var copyNums1 = new int[m];
            int left = 0, right = 0;
            if (m != 0)
            {
                copyNums1[left] = nums1[left];
            }

            while (left + right < m + n)
            {
                if (left == m)
                {
                    nums1[left + right] = nums2[right];
                    right++;
                }
                else if (right == n)
                {
                    nums1[left + right] = copyNums1[left];
                    left++;
                }

                else if (copyNums1[left] < nums2[right])
                {
                    nums1[left + right] = copyNums1[left];
                    left++;
                }
                else if (copyNums1[left] > nums2[right])
                {
                    nums1[left + right] = nums2[right];
                    right++;
                }
                else
                {
                    nums1[left + right] = copyNums1[left];
                    left++;
                    if (left + right < m)
                    {
                        copyNums1[left + right] = nums1[left + right];
                    }

                    nums1[left + right] = nums2[right];
                    right++;
                }

                if (left + right < m)
                {
                    copyNums1[left + right] = nums1[left + right];
                }
            }

            return nums1;
        }
    }
}
