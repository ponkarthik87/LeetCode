using FluentAssertions;

namespace LeetCodeTest.ArraysAndStrings.IsSequence
{
    public class IsSequenceTest
    {
        [Theory]
        [ClassData(typeof(IsSequenceTestData))]
        public void IsSequenceTestInitialTest(string input1, string input2, bool expected)
        {
            IsSequence isSequence = new();
            var actual = isSequence.IsSubsequenceFn(input1, input2);
            actual.Should().Be(expected);
        }
    }
}
