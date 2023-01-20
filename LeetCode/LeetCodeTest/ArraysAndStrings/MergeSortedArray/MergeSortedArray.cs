namespace LeetCodeTest.ArraysAndStrings.MergeSortedArray
{
    internal class MergeSortedArray
    {
        internal int[] MergeSortedArrayFn(int[] input1, int[] input2)
        {
            int[] result = new int[input1.Length + input2.Length];
            int i = 0, j = 0;
            while (i < input1.Length || j < input2.Length)
            {
                if (j == input2.Length || (i < input1.Length && input1[i] < input2[j]))
                {
                    result[i + j] = input1[i];
                    i++;
                }
                else if (i == input1.Length || (j < input2.Length && input1[i] >= input2[j]))
                {
                    result[i + j] = input2[j];
                    j++;
                }
            }

            return result;
        }
    }
}
