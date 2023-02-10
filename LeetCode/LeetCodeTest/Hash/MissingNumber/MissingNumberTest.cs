using FluentAssertions;

namespace LeetCodeTest.Hash.MissingNumber
{
    public class MissingNumberTest
    {
        [Theory]
        [ClassData(typeof(MissingNumberTestData))]
        public void MissingNumberInitialTest(int[] nums, int expected)
        {
            MissingNumber missingNumber = new();
            var result = missingNumber.MissingNumberFn(nums);
            result.Should().Be(expected);
        }
    }
}
