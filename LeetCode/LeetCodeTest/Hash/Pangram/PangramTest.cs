using FluentAssertions;
using LeetCodeTest.ArraysAndStrings;

namespace LeetCodeTest.Hash.Pangram
{
    public class PangramTest
    {
        [Theory]
        [ClassData(typeof(PangramTestData))]
        public void PangramInitialTest(string s, bool expected)
        {
            Pangram Pangram = new();
            var result = Pangram.PangramFn(s);
            result.Should().Be(expected);
        }
    }
}
