using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.LengthOfLongestSubString
{
    internal class LengthOfLongestSubString
    {
        internal int LengthOfLongestSubStringFn(string input)
        {
            var left = 0;
            var right = 0;
            var length = 0;
            var finalLength = 0;
            var isFirstZero = true;
            while (right < input.Length)
            {
                if (input[right] == '0')
                {
                    if (isFirstZero)
                    {
                        left = right;
                        isFirstZero = false;
                    }
                    else
                    {
                        length = right - (left + 1);
                        left = right;
                    }
                }

                right++;
                length++;
                finalLength = finalLength > length ? finalLength : length;
            }

            return finalLength;
        }
    }
}
