using FluentAssertions;

namespace LeetCodeTest.ArraysAndStrings.MergeSortedArrayNoReturn88
{
    public class MergeSortedArrayNoReturn88Test
    {
        [Theory]
        [ClassData(typeof(MergeSortedArrayNoReturn88TestData))]
        public void MergeSortedArrayInitialTest(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            MergeSortedArrayNoReturn88 mergeSortedArray = new();
            var actual = mergeSortedArray.MergeSortedArrayFn(nums1,  m, nums2,  n);
            actual.Should().Equal(expected);
        }
    }
}
