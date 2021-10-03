using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomnumber = new Random();

            //variables
            int guess;
            int guesses;
            int number;
            bool playAgain = true;
            string response;

            //loop
            while(playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = randomnumber.Next(1, 101);

                for (int i = 0; guess != number; i++)
                {
                    Console.WriteLine("Enter number (1 - 100):");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > number)
                    {
                        Console.WriteLine("Too high!");
                    }

                    else if (guess < number)
                    {
                        Console.WriteLine("Too Low!");
                    }

                    else if (guess == number)
                    {
                        Console.WriteLine("Correct!");
                    }

                    guesses = i;

                }

                Console.WriteLine("Number of guesses: " + guesses);

                // Play again
                Console.WriteLine("Would you like to play again? [Y/N]");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }

                else if (response == "N")
                {
                    playAgain = false;
                }

            }
            
        }
    }  
}
