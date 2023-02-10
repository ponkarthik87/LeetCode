namespace LeetCodeTest.Hash.Pangram
{
    internal class Pangram
    {
        internal bool PangramFn(string s)
        {
            return s.Select(x => x).ToHashSet().Count == 26;
        }
    }
}
