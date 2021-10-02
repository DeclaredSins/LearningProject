using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String pag;

            while (playAgain)
            {

                player = "";
                computer = "";

                while (player != "ROCK" && player != "SCISSOR" && player != "PAPER")
                {
                    Console.WriteLine("ROCK, PAPER, SCISSOR: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "SCISSOR";
                        break;
                    case 3:
                        computer = "PAPER";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Computer Win!");
                        }
                        else if (computer == "SCISSOR")
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "SCISSOR":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Computer win!");
                        }
                        else if (computer == "SCISSOR")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "SCISSOR")
                        {
                            Console.WriteLine("Computer Win!");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                }

                Console.WriteLine("Would you like to play again? [Y/N]");
                pag = Console.ReadLine();
                pag = pag.ToUpper();

                if (pag == "Y")
                {
                    playAgain = true;
                }

                else if (pag == "N")
                {
                    playAgain = false;
                }

            }

        }
    }
}
