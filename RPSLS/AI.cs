using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        public AI(string gestureChoice, int numberOfWins, string[] gestureChoices)
        {
            this.gestureChoice = gestureChoice;
            this.numberOfWins = numberOfWins;
            this.gestureChoices = gestureChoices;
        }
        public string getChoice()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 6);
            string aiChoice = "";
            if(number == 1)
            {
                aiChoice = "rock";
            }
            else if (number == 2)
            {
                aiChoice = "scissors";
            }
            else if (number == 3)
            {
                aiChoice = "paper";
            }
            else if (number == 4)
            {
                aiChoice = "lizard";
            }
            else
            {
                aiChoice = "spock";
            }
            return aiChoice;
            Console.WriteLine("The bot has chosen {0}",aiChoice);
        }
    }
}
