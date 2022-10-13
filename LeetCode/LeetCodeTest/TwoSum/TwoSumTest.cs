using FluentAssertions;

namespace LeetCodeTest;

public class TwoSumTest
{
    [Theory]
    [ClassData(typeof(TwoSumTestData))]
    public void TwoSumInitialTest(int[] nums, int target, int[] expected)
    {
        var result = TwoSum(nums, target);
        result.Should().Equal(expected);
    }

    [Theory]
    [ClassData(typeof(TwoSumTestData))]
    public void TwoSumSecondTest(int[] nums, int target, int[] expected)
    {
        var result = TwoSum1(nums, target);
        result.Should().Equal(expected);
    }

    int[]? TwoSum1(int[] nums, int target)
    {
        Dictionary<int, int> dict = new();
        for (var first = 0; first < nums.Length; first++)
        {
            var finder = target - nums[first];

            if (dict.ContainsKey(finder))
            {
                return new[] { dict[finder], first };
            }
            else if (!dict.ContainsKey(nums[first]))
            {
                dict.Add(nums[first], first);
            }
        }

        return null;
    }

    int[]? TwoSum(int[] nums, int target)
    {
        for (var first = 0; first < nums.Length; first++)
        {
            var secondback = 1;
            for (var second = first + 1; secondback <= (nums.Length - first) / 2; second++, secondback++)
            {
                if (nums[first] + nums[second] == target)
                {
                    return new[] { first, second };
                }

                if (nums.Length - secondback > second && nums[first] + nums[^secondback] == target)
                {
                    return new[] { first, nums.Length - secondback };
                }
            }
        }

        return null;
    }
}
