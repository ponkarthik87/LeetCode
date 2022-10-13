using LeetCode.Helpers;



namespace LeetCode;

public class RunningSumOf1D
{
    public RunningSumOf1D()
    {
        var sum = RunningSumFn(new[] { 1, 2, 3, 4 });
        Helpers.PrintHelper.Print(sum);
    }


    int[]? RunningSumFn(int[]? nums)
    {
        for (var i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }

        return nums;
    }

   
}
