using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace store_value_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // DO while loop, user can re enter values
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Array calculations");
                Console.WriteLine("When prompted, enter 5 numbers");

                // creating a new array that will hold 5 interger values for the user to enter
                int[] number = new int[5];

                // for loop with index from 1 - 5
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine();
                    // try to catch incorrect value
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        // getting users number, this will repeat 5 times
                        Console.Write("Please enter a number: ");
                        // converting the users value and adding the index number to the array
                        number[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine($"Error {error.Message}");
                    }
                }

                // ====== CALCULATIONS ======
                // using max method, this will find the max number (highest number)
                int highestVal = number.Max();
                // using min method, this will find the min number (lowest number)
                int lowestVal = number.Min();
                // using average method, this will calculate the average for all the values that the user inputted
                double avg = number.Average();
                // range is lowest - highest value
                double range = (lowestVal - highestVal);

                // displays the output results
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"The highest value is {highestVal} and the lowest value is {lowestVal}");
                Console.WriteLine($"The average is {avg}");
                Console.WriteLine($"The range is {range}");

                Console.Write("Press 'x' to exit or any key to try again");

                // if user presses x, the program closes
            } while (Console.ReadKey().KeyChar != 'x');
        }
    }
}