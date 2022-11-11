using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.IsSequence
{
    internal class IsSequence
    {
        internal bool IsSubsequenceFn(string s, string t)
        {
            if (s.Length == 0) return true;
            if (s.Length == t.Length) return t == s;
            if (s.Length > t.Length) return false;
            for (int i = 0, j = 0; i < t.Length; i++)
            {
                if (t[i] == s[j])
                {
                    j++;
                    if (s.Length == j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
