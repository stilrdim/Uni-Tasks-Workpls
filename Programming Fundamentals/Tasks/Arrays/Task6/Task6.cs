using System;
using System.Linq;


namespace Arrays
{
    class Task6
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // An array from the input, separating each element by the space
            string[] inputToArray = input.Split(" ");

            // An array for storing the even numbers
            int[] evenNumbers = new int[inputToArray.Length];

            // An array for storing the odd numbers
            int[] oddNumbers = new int[inputToArray.Length];

            // Hold the value of the total sum of the even numbers array
            int totalSumEven = 0;

            // Hold the value of the total sum of the even numbers array
            int totalSumOdd = 0;

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
                else
                {
                    oddNumbers[i] = numberToInt32;
                }
            }

            // The total sum of all even numbers
            foreach (int number in evenNumbers)
            {
                totalSumEven += number;
            }

            // The total sum of all odd numbers
            foreach (int number in oddNumbers)
            {
                totalSumOdd += number;
            }

            // Store the difference
            int difference = totalSumEven - totalSumOdd;

            Console.WriteLine(difference);
        }
    }
}

/*
 ⦁	Even and Odd Subtraction
Write a program that calculates the difference between the sum of the even and the sum of the odd numbers in an array.
*/
