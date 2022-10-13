// See https://aka.ms/new-console-template for more information


using LeetCode.Helpers;

//var returnValue = TwoSum1(new[] { 2, 7, 11, 15 }, 9);
// var returnValue = TwoSum1(new[] { 3, 2, 4 }, 6);
// var returnValue = TwoSum1(new[] { 3, 3 }, 6);
//var returnValue = TwoSum1(new[] { 1, 3, 4, 2 }, 6);
var returnValue = TwoSum1(new[] { 3,2,95,4,-3 }, 92);
PrintHelper.Print(returnValue);


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
        else if(!dict.ContainsKey(nums[first]))
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
