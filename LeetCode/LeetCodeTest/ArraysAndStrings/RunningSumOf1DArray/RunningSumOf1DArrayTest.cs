using FluentAssertions;

namespace LeetCodeTest.ArraysAndStrings.RunningSumOf1DArray
{
    public class RunningSumOf1DArrayTest
    {
        [Theory]
        [ClassData(typeof(RunningSumOf1DArrayTestData))]
        public void RunningSumOf1DArrayInitialTest(int[] nums, int[] expected)
        {
            RunningSumOf1DArray runningSumOf1DArray = new();
            var actual = runningSumOf1DArray.RunningSumOf1DArrayFn(nums);
            actual.Should().Equal(expected);
        }
    }
}
