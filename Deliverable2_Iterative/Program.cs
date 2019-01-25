/*
 Author: Eaman Iranmanesh
 Date: 1/24/2019
 Comments: This C# cinsole app demonstrates iterative statements. 
 */
using System;

namespace Deliverable2_Iterative
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input to perform operation
            Console.WriteLine("Hello. Please enter an Integar value between 1 and 100.");

            // try catch block used to validate user input, messages displayed
            try
            {
                // variable to gather user input
                string input = Console.ReadLine();
                // variable used to perform iterative statements
                int value_of_input = int.Parse(input);
                // variable used to count number of iterations
                int i = value_of_input;

                if (value_of_input > 0 && value_of_input <= 100)
                    {
                    

                    // do while loop to perform operation
                    Console.WriteLine("The Do While Loop will now iterate " + value_of_input.ToString() + " times.");

                    do
                    {
                        Console.WriteLine("You have entered: " + value_of_input.ToString() + ". " + "This is the current integer value in the loop: " + i.ToString());
                        i--;

                    } while (i > 0);
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);

                }
                else if (value_of_input > 100)
                {
                    Console.WriteLine("Warning: You have enetered an integer value over 100.");
                    Console.WriteLine("This may cause the program to run for an extended period of time.");
                    Console.WriteLine("To continue at own risk press Enter. Otherwise press any key twice to close the program.");


                    if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        // do while loop to perform operation
                        Console.WriteLine("The Do While Loop will now iterate " + value_of_input.ToString() + " times.");

                        do
                        {
                            Console.WriteLine("You have entered: " + value_of_input.ToString() + ". " + "This is the current integer value in the loop: " + i.ToString());
                            i--;

                        } while (i > 0);
                        Console.WriteLine("Press any key to exit the program");
                        Console.ReadKey(true);
                    }
                    
                        Console.ReadKey(true);

                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100.");
                    Console.WriteLine("Press any key to exit the program and try again");
                    Console.ReadKey(true);
                }
                
            } // end of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
        }
    }
}
