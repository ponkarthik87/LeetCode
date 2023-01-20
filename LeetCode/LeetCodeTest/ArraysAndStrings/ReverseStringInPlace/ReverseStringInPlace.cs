namespace LeetCodeTest.ArraysAndStrings.ReverseStringInPlace
{
    internal class ReverseStringInPlace
    {
        public char[] ReverseStringInPlaceFn(char[] s)
        {
            for (int i = 0, j = s.Length - 1; i < s.Length; i++, j--)
            {
                if (i >= j) break;
                (s[i], s[j]) = (s[j], s[i]);
            }

            return s;
        }

        public char[] ReverseStringInPlaceNewFn(char[] s)
        {
            var i = 0;
            var j = s.Length - 1;
            while (i < j)
            {
                (s[i], s[j]) = (s[j], s[i]);
                i++;
                j--;
            }
            return s;
        }
    }
}
