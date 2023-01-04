using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.NumSubarrayProductLessThanK
{
    public class NumSubarrayProductLessThanKTest
    {
        [Theory]
        [ClassData(typeof(NumSubarrayProductLessThanKTestData))]
        public void NumSubarrayProductLessThanKInitialTest(int[] nums, int k, int expected)
        {
            NumSubarrayProductLessThanK numSubarrayProductLessThanK = new();
            var actual = numSubarrayProductLessThanK.NumSubarrayProductLessThanKFn(nums,k);
            actual.Should().Be(expected);
        }
        
        [Theory]
        [ClassData(typeof(NumSubarrayProductLessThanKTestData))]
        public void NumSubarrayProductLessThanKNewTest(int[] nums, int k, int expected)
        {
            NumSubarrayProductLessThanK numSubarrayProductLessThanK = new();
            var actual = numSubarrayProductLessThanK.NumSubarrayProductLessThanKFn1(nums,k);
            actual.Should().Be(expected);
        }
    }
}
