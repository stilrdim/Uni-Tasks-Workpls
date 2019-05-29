using System;
using System.Linq;


namespace Arrays
{
    class Task7
    {
        static void Main(string[] args)
        {
            string[] inputArray1 = Console.ReadLine().Split(" ");
            string[] inputArray2 = Console.ReadLine().Split(" ");

            // Hold values that help us recognise where the difference occurs
            bool identicalArrays = true;
            int differentIndex = 0;

            // Hold the value for the total sum in case of identical arrays
            int totalSum = 0;

            // Loop over each element
            for (int i = 0; i < inputArray1.Length; i++)
            {
                int elementToInt32 = int.Parse(inputArray1[i]);
                totalSum += elementToInt32;

                // Check if both arrays are identical at the current index
                if (inputArray1[i] != inputArray2[i])
                { // If they aren't, set the appropriate values and break out of the for loop since it's now pointless to continue
                    identicalArrays = false;
                    differentIndex = i;
                    break;
                }
            }

            // If not identical ...
            if (identicalArrays == false)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {differentIndex} index");
            }
            else // if identical ...
            {
                Console.WriteLine($"Arrays are identical. Sum: {totalSum}");
            }
        }
    }
}
