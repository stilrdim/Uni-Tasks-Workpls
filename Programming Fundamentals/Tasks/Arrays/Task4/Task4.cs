using System;
using System.Linq;

namespace Arrays
{
    class Task4
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // Create an array from the input, separating each element by the space
            string[] inputToArray = input.Split(" ");

            // Reverse the elements in the array
            Array.Reverse(inputToArray, 0, inputToArray.Length);

            Console.WriteLine(string.Join(" ", inputToArray));
        }
    }
}