using System;
using System.Text;

namespace LeetCode.Helpers
{
    public static class PrintHelper
    {
        public static void Print(int[] nums)
        {
            var sb = new StringBuilder();
            sb.Append('[');
            foreach (var num in nums)
            {
                sb.Append($"{num}, ");
            }

            sb.Replace(", ", "", sb.Length - 2, 2);
            sb.Append(']');
            Console.WriteLine(sb);
        }
    }
}
