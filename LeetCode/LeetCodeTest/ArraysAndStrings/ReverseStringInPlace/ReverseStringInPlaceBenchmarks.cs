using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace LeetCodeTest.ArraysAndStrings.ReverseStringInPlace
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class ReverseStringInPlaceBenchmarks
    {
        private static readonly char[] Input = { 'h', 'e', 'l', 'l', 'o' };
        private static readonly ReverseStringInPlace reverseStringInPlace = new ReverseStringInPlace();

        [Benchmark]
        public void ReverseStringInPlaceFn()
        {
            reverseStringInPlace.ReverseStringInPlaceFn(Input);
        }

        [Benchmark]
        public void ReverseStringInPlaceNewFn()
        {
            reverseStringInPlace.ReverseStringInPlaceNewFn(Input);
        }
    }
}
