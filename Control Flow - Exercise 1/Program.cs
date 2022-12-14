using System;

namespace Control_Flow___Exercise_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1- Write a program and ask the user to enter a number.
            // The number should be between 1 to 10.
            // If the user enters a valid number, display "Valid" on the console.
            // Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
            {
                Console.WriteLine("Please enter a number between 1 & 10...");

                string userInput = Console.ReadLine();
                int userNumber = Convert.ToInt32(userInput);

                if (userNumber >=1 && userNumber <= 10)
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("Invalid");
            }
        }
    }
}
