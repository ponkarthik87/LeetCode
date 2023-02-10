using FluentAssertions;

namespace LeetCodeTest.Hash.NotOnePlusOrMinus
{
    public class NotOnePlusOrMinusTest
    {
        [Theory]
        [ClassData(typeof(NotOnePlusOrMinusTestData))]
        public void NotOnePlusOrMinusInitialTest(int[] nums, List<int> expected)
        {
            NotOnePlusOrMinus notOnePlusOrMinus = new();
            var result = notOnePlusOrMinus.NotOnePlusOrMinusFn(nums);
            result.Should().Equal(expected);
        }
    }
}
