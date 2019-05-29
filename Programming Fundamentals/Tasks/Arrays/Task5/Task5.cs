using System;
using System.Linq;


namespace Arrays
{
    class Task5
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // Create an array from the input, separating each element by the space
            string[] inputToArray = input.Split(" ");

            // Create an array for storing the even numbers
            int[] evenNumbers = new int[inputToArray.Length];

            // Hold the value of the total sum of the even numbers array
            int totalSum = 0;

            // Go over each element from the input
            for (int i = 0; i < inputToArray.Length; i++)
            {
                // Convert the elements from String to Int32
                int numberToInt32 = int.Parse(inputToArray[i]);

                // If the current number is even, add it to the evenNumbers array
                if (numberToInt32 % 2 == 0)
                {
                    evenNumbers[i] = numberToInt32;
                }
            }

            // Calculate the total sum of all the elements in the evenNumbers array (The odd numbers from the input are now 0s)
            foreach (int number in evenNumbers)
            {
                totalSum += number;
            }

            Console.WriteLine(totalSum);
        }
    }
}

/*
 ⦁    Sum Even Numbers
Read an array from the console and sum only the even numbers.
*/
