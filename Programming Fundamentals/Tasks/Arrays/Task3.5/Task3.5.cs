using System;
using System.Collections.Generic;
using System.Linq;


namespace ArraysMore
{
    class _Task5
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            // An array to store the length of the current longest sequence
            int[] len = new int[sequence.Length];
            int[] prev = new int[sequence.Length];

            int highestIndex = LEN(sequence, len, prev);

            PrintLIS(sequence, prev, highestIndex);
        }

        static void PrintLIS(int[] sequence, int[] prev, int index)
        {
            List<int> lis = new List<int>();

            while (index != -1)
            { 
                lis.Add(sequence[index]);
                index = prev[index];
            }
            lis.Reverse();
            Console.WriteLine($"subsequence = [{string.Join(", ", lis)}]");
        }
        private static int LEN(int[] sequence, int[] length, int[] prev)
        {
            // Store the current max index
            int maxIndex = 0;
            int maxLength = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                // Set value of all indexes to 1
                length[i] = 1;
                prev[i] = -1;

                // Find the highest current sequence length
                for (int j = 0; j < i; j++)
                {
                    if (sequence[i] > sequence[j] && length[i] < length[j] + 1)
                    {
                        length[i] = length[j] + 1;
                        prev[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
/*
 ⦁	Longest Increasing Subsequence (LIS)
Read a list of integers and find the longest increasing subsequence (LIS). If several such exist, print the leftmost.
*/
