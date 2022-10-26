using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace LeetCodeTest.IsSequence
{
    public class IsSequenceTest
    {
        [Theory]
        [ClassData(typeof(IsSequenceTestData))]
        public void IsSequenceTestInitialTest(string input1, string input2, bool expected)
        {
            IsSequence isSequence = new();
            var actual = isSequence.IsSequenceFn(input1, input2);
            actual.Should().Be(expected);
        }
    }
}
