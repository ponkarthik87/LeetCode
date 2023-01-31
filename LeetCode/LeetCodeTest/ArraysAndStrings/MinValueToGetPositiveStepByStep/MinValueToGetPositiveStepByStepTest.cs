using FluentAssertions;

namespace LeetCodeTest.ArraysAndStrings.MinValueToGetPositiveStepByStep
{
    public class MinValueToGetPositiveStepByStepTest
    {
        [Theory]
        [ClassData(typeof(MinValueToGetPositiveStepByStepTestData))]
        public void MinValueToGetPositiveStepByStepInitialTest(int[] input, int expected)
        {
            MinValueToGetPositiveStepByStep minValueToGetPositiveStepByStep = new();
            var actual = minValueToGetPositiveStepByStep.MinValueToGetPositiveStepByStepFn(input);
            actual.Should().Be(expected);
        }
    }
}
