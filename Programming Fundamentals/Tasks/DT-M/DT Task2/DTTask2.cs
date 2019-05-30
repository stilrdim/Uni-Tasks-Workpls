using System;
using System.Linq;


namespace DataTypes
{
    class DTTask2
    {
        static void Main(string[] args)
        {
            // Ask for amount of numbers to print
            int arraySize = int.Parse(Console.ReadLine());

            // An array with the pair of numbers
            long[] numbersArray = new long[2];

            // An array with the current pair
            string[] currentInput = new string[arraySize];


            // Ask for input until the desired amount of pairs is reached
            for (int i = 0; i < arraySize; i++)
            {
                // Prompt for the two numbers
                currentInput[i] = Console.ReadLine();

                // Convert the two numbers to Int64 (long)
                numbersArray[0] = Convert.ToInt64(currentInput[i].Split(" ")[0]);
                numbersArray[1] = Convert.ToInt64(currentInput[i].Split(" ")[1]);

                // An array with each digit of the left number, 18 is the max size (in chars) of a long number
                int[] leftSideDigits = new int[18];
                int leftSideSum = 0;

                // An array with each digit of the right number, 18 is the max size (in chars) of a long number
                int[] rightSideDigits = new int[18];
                int rightSideSum = 0;

                if (numbersArray[0] > numbersArray[1])
                {
                    for (int j = 0; j < numbersArray[0].ToString().Length; j++)
                    {
                        // Get each digit by converting the number to string and looping over it (current loop)
                        string leftNumberString = numbersArray[0].ToString();

                        // If the starting char is a "-", replace it with a 0
                        if (leftNumberString[j].ToString() == "-")
                        {
                            leftNumberString = "0";
                        }

                        // Add the current number to the Int32 array after converting it to string to avoid getting the ASCII values
                        leftSideDigits[j] = Convert.ToInt32(leftNumberString[j].ToString());

                        // Add the current number to the total sum of the left side
                        leftSideSum += leftSideDigits[j];
                    }
                    Console.WriteLine(leftSideSum);
                }
                else
                {
                    for (int j = 0; j < numbersArray[1].ToString().Length; j++)
                    {
                        string rightNumberString = numbersArray[1].ToString();
                        if (rightNumberString[j].ToString() == "-")
                        {
                            rightNumberString = "0";
                        }

                        rightSideDigits[j] = Convert.ToInt32(rightNumberString[j].ToString());
                        rightSideSum += rightSideDigits[j];
                    }
                    Console.WriteLine(rightSideSum);
                }
            }
        }
    }
}
