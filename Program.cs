using System;

namespace RockScissorsPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - rock, 2 - scissors, 3 - paper
            int userScore = 0;
            int cpuScore = 0;
            Console.WriteLine("Rock, Scissors or Paper?");
            Console.WriteLine("Plays up to 3 points");
            Console.WriteLine("You choice:");

            while (userScore < 3 && cpuScore < 3)
            {
                Console.WriteLine("Rock, Scissors or Paper?");
                string userChoice = Console.ReadLine().ToLower();
                Console.WriteLine($"User choice: {userChoice}");
                Random rnd = new Random();
                int random = rnd.Next(1, 4);
                string cpuChoice = "";
                switch (random)
                {
                    case 1:
                        cpuChoice = "paper";
                        break;
                    case 2:
                        cpuChoice = "scissors";
                        break;
                    case 3:
                        cpuChoice = "rock";
                        break;
                }
                Console.WriteLine($"CPU choice {cpuChoice}");
                if ((cpuChoice == "paper" && userChoice == "rock") || (cpuChoice == "scissors" && userChoice == "paper") || (cpuChoice == "rock" && userChoice == "scissors"))
                {
                    cpuScore++;
                    Console.WriteLine("CPU win! USER lose!");
                }
                else if ((userChoice == "paper" && cpuChoice == "rock") || (userChoice == "scissors" && cpuChoice == "paper") || (userChoice == "rock" && cpuChoice == "scissors"))
                {
                    userScore++;
                    Console.WriteLine("USER win! CPU lose!");
                }
                else if (userChoice == cpuChoice)
                {
                    Console.WriteLine("This game was a draw!");
                }
                else
                {
                    cpuScore++;
                    Console.WriteLine("Invalid input from USER, CPU win!");
                }

                Console.WriteLine($"USER score: {userScore} CPU score: {cpuScore}");
                Console.WriteLine();
            }
            if (userScore == 3)
            {
                userScore++;
                Console.WriteLine("USER wins!");
            }
            else
            {
                cpuScore++;
                Console.WriteLine("CPU wins!");
            }
            Console.WriteLine("Have a nice day!");
        }
    }
}
