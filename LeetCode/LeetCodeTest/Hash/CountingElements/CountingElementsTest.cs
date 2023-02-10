using FluentAssertions;

namespace LeetCodeTest.Hash.CountingElements
{
    public class CountingElementsTest
    {
        [Theory]
        [ClassData(typeof(CountingElementsTestData))]
        public void CountingElementsInitialTest(int[] nums, int expected)
        {
            CountingElements countingElements = new();
            var result = countingElements.CountingElementsFn(nums);
            result.Should().Be(expected);
        }
    }
}
