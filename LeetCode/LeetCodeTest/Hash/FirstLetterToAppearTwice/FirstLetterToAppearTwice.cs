namespace LeetCodeTest.Hash.FirstLetterToAppearTwice
{
    internal class FirstLetterToAppearTwice
    {
        internal char FirstLetterToAppearTwiceFn(string s)
        {
            Dictionary<char, int> collection = new();
            foreach (var key in s)
            {
                if (collection.ContainsKey(key))
                {
                    collection[key] += 1;
                    if (collection[key] == 2) return key;
                }
                else
                {
                    collection.Add(key, 1);
                }
            }

            return default;
        }
    }
}
