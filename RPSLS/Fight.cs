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
            while(playerOne.numberOfWins < 3 && playerTwo.numberOfWins < 3) 
            {
                Console.WriteLine(playerOne.numberOfWins);
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
                    }
                    else if (playerTwoChoice == "scissors")
                    {
                        Console.WriteLine("Rock smashes scissors! Player one wins");
                        playerOne.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "lizard")
                    {
                        Console.WriteLine("Rock smashes lizard! Player one wins");
                        playerOne.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "spock")
                    {
                        Console.WriteLine("Spock vaporizes rock! Player two wins");
                        playerTwo.numberOfWins += 1;
                    }
                }
                else if(playerOneChoice == "paper")
                {
                    if (playerTwoChoice == "rock")
                    {
                        Console.WriteLine("Paper covers rock! Player one wins");
                        playerOne.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "paper")
                    {
                        Console.WriteLine("Paper ties with paper!");
                    }
                    else if (playerTwoChoice == "scissors")
                    {
                        Console.WriteLine("scissors cuts paper! player two wins");
                        playerTwo.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "lizard")
                    {
                        Console.WriteLine("Lizard eats paper! Player two wins");
                        playerTwo.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "spock")
                    {
                        Console.WriteLine("Paper disproves spock! player one wins");
                        playerOne.numberOfWins += 1;
                    }
                }
                else if (playerOneChoice == "scissors")
                {
                    if (playerTwoChoice == "rock")
                    {
                        Console.WriteLine("Rock crushed paper! Player two wins");
                        playerTwo.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "paper")
                    {
                        Console.WriteLine("Scissors cuts paper! Player one wins");
                        playerOne.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "scissors")
                    {
                        Console.WriteLine("Scissors ties with scissors!");
                    }
                    else if (playerTwoChoice == "lizard")
                    {
                        Console.WriteLine("scissors decapitates lizard, player 1 wins!");
                        playerOne.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "spock")
                    {
                        Console.WriteLine("spock smashes scissors, player 2 wins.");
                        playerTwo.numberOfWins += 1;
                    }
                }
                else if (playerOneChoice == "lizard")
                {
                    if (playerTwoChoice == "rock")
                    {
                        Console.WriteLine("Rock crushed lizard! Player two wins");
                        playerTwo.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "paper")
                    {
                        Console.WriteLine("Lizard eats paper! Player one wins");
                        playerOne.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "scissors")
                    {
                        Console.WriteLine("scissors decapitates lizard, player 2 wins.");
                        playerTwo.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "lizard")
                    {
                        Console.WriteLine("Lizard ties lizard!");
                    }
                    else if (playerTwoChoice == "spock")
                    {
                        Console.WriteLine("lizard poisons spock, player 1 wins!");
                        playerOne.numberOfWins += 1;
                    }
                }
                else if (playerOneChoice == "spock")
                {
                    if (playerTwoChoice == "rock")
                    {
                        Console.WriteLine("spock vaporizes rock, player 2 wins.");
                        playerTwo.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "paper")
                    {
                        Console.WriteLine("paper disproves spock, player 2 wins.");
                        playerTwo.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "scissors")
                    {
                        Console.WriteLine("spock smashes scissors, player 1 wins!");
                        playerOne.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "lizard")
                    {
                        Console.WriteLine("lizard poisons spock, player 2 wins.");
                        playerTwo.numberOfWins += 1;
                    }
                    else if (playerTwoChoice == "spock")
                    {
                        Console.WriteLine("Spock ties spock!");
                    }
                }
            }
        }
    }
}
