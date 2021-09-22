using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetChoice();
            void GetChoice()
            {
                Console.WriteLine("Choose rock, paper, scissors, lizard or spock: ");
                string userChoice = Console.ReadLine();
                if (userChoice == "rock" || userChoice == "Rock")
                {
                    userChoice = "rock";
                }
                else if (userChoice == "paper" || userChoice == "Paper")
                {
                    userChoice = "paper";
                }
                else if (userChoice == "scissors" || userChoice == "Scissors")
                {
                    userChoice = "scissors";
                }
                else if (userChoice == "lizard" || userChoice == "Lizard")
                {
                    userChoice = "Lizard";
                }
                else if (userChoice == "spock" || userChoice == "Spock")
                {
                    userChoice = "spock";
                }
                else
                {
                    Console.WriteLine("not a valid choice, please choose rock, paper, scissors, lizard or spock: ");
                    GetChoice();
                }
                Console.WriteLine(userChoice);
            }
        }
    }
}
