namespace LeetCodeTest.Hash.NotOnePlusOrMinus
{
    internal class NotOnePlusOrMinus
    {
        internal List<int> NotOnePlusOrMinusFn(int[] nums)
        {
            var collection = nums.Select(x => x).ToHashSet();
            return collection.Where(key => !collection.Contains(key - 1) && !collection.Contains(key + 1)).ToList();
        }
    }
}
