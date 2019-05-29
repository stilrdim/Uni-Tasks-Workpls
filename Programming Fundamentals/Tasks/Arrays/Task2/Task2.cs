using System;
using System.Linq;


namespace Arrays
{
    class Task2
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

            // Reverse all elements in the last array
            Array.Reverse(numbersArray, 0, arraySize);

            Console.WriteLine(string.Join(" ", numbersArray));
        }
    }
}