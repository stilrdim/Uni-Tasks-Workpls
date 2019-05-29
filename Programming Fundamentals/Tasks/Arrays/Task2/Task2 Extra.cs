using System;
using System.Linq;
using CustomFunctions;

namespace Arrays
{
    class Task2Extra
    {
        static void Main(string[] args)
        {
            // Ask for amount of numbers to print
            int arraySize = int.Parse(Console.ReadLine());

            // Create an array with the desired size
            int[] numbersArray = new int[arraySize];

            // Ask for input untill the desired amount of numbers is reached
            for (int i = 0; i < arraySize; i++)
            {
                numbersArray[i] = int.Parse(Console.ReadLine());
            }

            // Reverse all items and assign it to a new array 
            int[] reversedArray = ArrayRelated.Reverse(numbersArray, 0, arraySize);

            // Output the numbers in reversed order, separated by space
            Console.WriteLine(string.Join(" ", reversedArray));
        }
    }
}