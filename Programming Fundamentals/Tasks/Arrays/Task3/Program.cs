using System;
using System.Linq;


namespace Arrays
{
    class Task3
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // Create an array from the input, separating each element by the space
            string[] inputToArray = input.Split(" ");

            // Loop over each element
            foreach (string number in inputToArray)
            {
                // Print out the raw input
                Console.Write($"{double.Parse(number)} =>");

                // Print out the rounded input
                Console.WriteLine($"{double.Parse(number):F0}");
            }
        }
    }
}
