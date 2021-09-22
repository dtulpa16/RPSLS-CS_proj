using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Fight
    {
        public static void fight()
        {
            Human playerOne = new Human(0);
            Human playerTwo = new Human(0);
            string playerOneChoice = playerOne.GetChoice();
            string playerTwoChoice = playerTwo.GetChoice();
            if (playerOneChoice == "rock")
            {
                if (playerTwoChoice == "rock")
                {
                    Console.WriteLine("Rock ties with rock!");
                }
                else if (playerTwoChoice == "paper")
                {
                    Console.WriteLine("Paper covers rock! Player two wins");
                    playerTwo.numberOfWins += 1;
                    Console.WriteLine(playerTwo.numberOfWins);

                }
                else if (playerTwoChoice == "scissors")
                {
                    Console.WriteLine("Rock smashes scissors! Player one wins");
                }
                else if (playerTwoChoice == "lizard")
                {
                    Console.WriteLine("Rock smashes lizard! Player one wins");
                }
                else if (playerTwoChoice == "spock")
                {
                    Console.WriteLine("Spock vaporizes rock! Player two wins");
                }
            }

        }
    }
}
