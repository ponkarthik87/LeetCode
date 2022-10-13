using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.RunningSumOf1D
{
    internal class RunningSumOf1DTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 } };
            yield return new object[] { new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 } };
            yield return new object[] { new[] { 3, 1, 2, 10, 1 }, new[] { 3, 4, 6, 16, 17 } };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
