﻿using System;
// See notes 1 and 2 below.


namespace NumberGuesser
{
    class Program
    {
        static void Main(String[] args)
        {
            

            while (true)
            {
                Random random = new Random();

                int CorrectNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != CorrectNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an an actual number");

                        continue;
                    }

                    guess = Int32.Parse(input);
                    
                    if (guess != CorrectNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }

                }
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");

                Console.WriteLine("play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

       
        static void PrintColorMessage(ConsoleColor color, string message)
        {

            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
