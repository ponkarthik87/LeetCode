namespace LeetCodeTest.Hash.CountingElements
{
    internal class CountingElements
    {
        internal int CountingElementsFn(int[] arr)
        {
            var collection = arr.GroupBy(x => x).Select(x => new { x.Key, value = x.Count() }).ToDictionary(x => x.Key, x => x.value);
            return collection.Sum(x => collection.ContainsKey(x.Key + 1) ? collection[x.Key] : 0);
        }
    }
}
