using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public Human(string gestureChoice, int numberOfWins, string[] gestureChoices)
        {
            this.gestureChoice = gestureChoice;
            this.numberOfWins = numberOfWins;
            this.gestureChoices = gestureChoices;
        }

        public void GetChoice()
        {
            Console.WriteLine("Choose rock, paper, scissors, lizard or spock: ");
            string userChoice = Console.ReadLine();
            if(userChoice == "rock" || userChoice == "Rock")
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
