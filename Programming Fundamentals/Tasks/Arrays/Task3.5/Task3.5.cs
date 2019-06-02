using System;
using System.Collections.Generic;
using System.Linq;


namespace ArraysMore
{
    class Task3_5
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            // An array to store the length of the current longest sequence
            int[] len = new int[sequence.Length];

            // An array to store the previous position
            int[] prev = new int[sequence.Length];

            // Get the highest index
            int highestIndex = LEN(sequence, len, prev);

            Console.WriteLine(LIS(sequence, prev, highestIndex));
        }


        /// <summary>
        /// Returns the Longest Increasing Subsequence
        /// </summary>
        /// <param name="sequence"></param>
        /// <param name="prev"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        static string LIS(int[] sequence, int[] prev, int index)
        {
            // Using list since making an array returns zeroes and gets detected as incorrect answer
            List<int> lis = new List<int>();

            // First and last elements are -1, loop over everything between them
            while (index != -1)
            { 
                lis.Add(sequence[index]);
                index = prev[index];
            }

            // Return the result reversed and formatted to string joined by spaces
            lis.Reverse();
            return string.Join(" ", lis);
        }


        /// <summary>
        /// Returns the highest index in a given sequence
        /// </summary>
        /// <param name="sequence"></param>
        /// <param name="sequenceLength"></param>
        /// <param name="prev"></param>
        /// <returns></returns>
        private static int LEN(int[] sequence, int[] sequenceLength, int[] prev)
        {
            // Store the current max index
            int maxIndex = 0;
            int maxLength = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                // Set value of all indexes to 1
                sequenceLength[i] = 1;
                prev[i] = -1;

                // Find the current highest sequence length and update the prev index' value
                for (int j = 0; j < i; j++)
                {
                    if (sequence[i] > sequence[j] && sequenceLength[i] < sequenceLength[j] + 1)
                    {
                        sequenceLength[i] = sequenceLength[j] + 1;
                        prev[i] = j;
                    }
                }

                /* If the current length is higher than the previous max length, set it as the new max length
                   and set the highest index to the current one */
                if (sequenceLength[i] > maxLength)
                {
                    maxLength = sequenceLength[i];
                    maxIndex = i;
                }
            }

            // Return the max index
            return maxIndex;
        }
    }
}
/*
 ⦁	Longest Increasing Subsequence (LIS)
Read a list of integers and find the longest increasing subsequence (LIS). If several such exist, print the leftmost.
*/
