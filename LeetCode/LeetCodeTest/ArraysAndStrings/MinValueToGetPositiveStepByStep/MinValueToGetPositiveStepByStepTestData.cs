using System.Collections;

namespace LeetCodeTest.ArraysAndStrings.MinValueToGetPositiveStepByStep
{
    internal class MinValueToGetPositiveStepByStepTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { -3, 2, -3, 4, 2 }, 5 };
            yield return new object[] { new[] { 1, 2 }, 1 };
            yield return new object[] { new[] { 1, -2, -3 }, 5 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
