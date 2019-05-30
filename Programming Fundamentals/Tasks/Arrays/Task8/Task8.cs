using System;
using System.Linq;


namespace Arrays
{
    class Task8
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int[] inputToInt32Array = new int[input.Length];

            // Copy the string elements into the int array
            for (int i = 0; i < input.Length; i++)
            {
                inputToInt32Array[i] = int.Parse(input[i]);
            }

            // Use an indexer and increment it instead of nesting with a 'for' loop
            int indexer = 1;

            while (indexer < inputToInt32Array.Length)
            {
                // Take every element that isn't with index 0 and add it to the beginning (index 0).
                inputToInt32Array[0] += inputToInt32Array[indexer];

                // The element that was added now becomes 0
                inputToInt32Array[indexer] = 0;

                // Increment the indexer variable to move to the next element in the array
                indexer++;
            }

            // As an end result, our first element now has the total 'condensed' value
            Console.WriteLine(inputToInt32Array[0]);

            // TODO: finish :)? Currently only works 50% of the time
        }
    }
}
/*
⦁	Condense Array to Number
Write a program to read an array of integers and condense them by summing adjacent couples of elements until a single integer is obtained. 
For example, if we have 3 elements {2, 10, 3}, we sum the first two and the second two elements and obtain {2+10, 10+3} = {12, 13}, 
then we sum again all adjacent elements and obtain {12+13} = {25}. 
*/
