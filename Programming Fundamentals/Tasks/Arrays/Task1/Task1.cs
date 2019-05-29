using System;
using System.Linq;


namespace Arrays
{
    class Task1
    {
        static void Main(string[] args)
        {
            // Store all weekdays in an array
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            // Input for the desired day of the week
            int selectedDay = int.Parse(Console.ReadLine());

            // If the input is valid (1-7) - print out the day of the week responding to it
            try
            {
                Console.WriteLine(weekDays[selectedDay - 1]);
            }

            // If something goes wrong (invalid input) - print out "Invalid day!"
            catch
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}