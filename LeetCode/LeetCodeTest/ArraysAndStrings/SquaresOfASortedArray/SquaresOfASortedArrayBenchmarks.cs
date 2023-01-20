using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace LeetCodeTest.ArraysAndStrings.SquaresOfASortedArray
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class SquaresOfASortedArrayBenchmarks
    {
        private static readonly int[] Input = { -4,-1,0,3,10 };
        private static readonly SquaresOfASortedArray SquaresOfASortedArray = new();

        [Benchmark]
        public void SquaresOfASortedArrayFn()
        {
            SquaresOfASortedArray.SquaresOfASortedArrayFn(Input);
        }

        // [Benchmark]
        // public void SquaresOfASortedArrayNewFn()
        // {
        //     SquaresOfASortedArray.SquaresOfASortedArrayNewFn(Input);
        // }
    }
}
