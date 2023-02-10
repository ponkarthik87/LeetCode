namespace LeetCodeTest.Hash.MissingNumber
{
    internal class MissingNumber
    {
        internal int MissingNumberFn(int[] nums)
        {
            var collection = nums.Select(x => x).ToHashSet();
            return Enumerable.Range(0, nums.Length + 1).FirstOrDefault(x => !collection.Contains(x));
        }
    }
}
