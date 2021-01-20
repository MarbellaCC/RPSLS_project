using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //Member Variable
        public int playerOneScore;
        public int playerTwoScore;
        public Human playerOne = new Human();
        public Computer playerTwo = new Computer();
        public List<Gesture> gestures;

        //Construcor
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            
        }
    
        //Member Methods
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock Paper Scissor Lizard Spock");
            Console.WriteLine("You will be playing three rounds best of 3 wins!");
        }
        
        public string OneOrTwoPlayer()
        {
            Console.WriteLine("For single player press one, for multiplayer press two");
            string numberOfPlayers = Console.ReadLine();
            return numberOfPlayers;
        }

        public void Compare()
        {
            CompareRockToOtherGestures();
            ComparePaperToOtherGestures();
            CompareScissorsToOtherGestures();
            CompareLizardToOtherGestures();
            CompareSpockToOtherGestures();
        }

        public void DisplayWinner()
        {
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("Player one won!!");
            }
            else if(playerOneScore < playerTwoScore)
            {
                Console.WriteLine("Player two won!!");
            }
        }
        public void CompareRockToOtherGestures()
        {
            if (playerOne.choice.name == "rock" && playerOne.choice.name == "rock")
            {
                Console.WriteLine("Player one chose rock and player two also chose rock. Noone receives a point");
            }
            else if (playerOne.choice.name == "rock" && playerTwo.choice.name == "paper")
            {
                Console.WriteLine("Player one chose rock and player two chose paper. Player two gets a point");
                playerTwoScore++;
            }
            else if (playerOne.choice.name == "rock" && playerTwo.choice.name == "scissors")
            {
                Console.WriteLine("Player one chose rock and player two chose scissors. Player one gets a point");
                playerOneScore++;
            }
            else if (playerOne.choice.name == "rock" && playerTwo.choice.name == "lizard")
            {
                Console.WriteLine("Player one chose rock and player two chose lizard. Player one gets a point");
                playerOneScore++;
            }
            else if (playerOne.choice.name == "rock" && playerTwo.choice.name == "spock")
            {
                Console.WriteLine("Player one chose rock and player two chose spock. Player two gets a point");
                playerTwoScore++;
            }
        }
        public void ComparePaperToOtherGestures()
        {
            if (playerOne.choice.name == "paper" && playerTwo.choice.name == "rock")
            {
                Console.WriteLine("Player one chose paper and player two chose rock. Player one gets a point");
                playerOneScore++;
            }
            else if (playerOne.choice.name == "paper" && playerTwo.choice.name == "paper")
            {
                Console.WriteLine("Player one chose paper and player two chose paper. Noone gets a point");
            }
            else if (playerOne.choice.name == "paper" && playerTwo.choice.name == "scissors")
            {
                Console.WriteLine("Player one chose paper and player two chose scissors. Player two gets a point");
                playerTwoScore++;
            }
            else if (playerOne.choice.name == "paper" && playerTwo.choice.name == "lizard")
            {
                Console.WriteLine("Player one chose paper and player two chose lizard. Player two gets a point");
                playerTwoScore++;
            }
            else if (playerOne.choice.name == "paper" && playerTwo.choice.name == "spock")
            {
                Console.WriteLine("Player one chose paper and player two chose spock. Player one gets a point");
                playerOneScore++;
            }
        }

        public void CompareScissorsToOtherGestures()
        {
            if (playerOne.choice.name == "scissors" && playerTwo.choice.name == "rock")
            {
                Console.WriteLine("Player one chose scissors and player two chose rock. Player two gets a point");
                playerTwoScore++;
            }
            else if (playerOne.choice.name == "scissors" && playerTwo.choice.name == "paper")
            {
                Console.WriteLine("Player one chose scissors and player two chose paper. Player one gets a point");
                playerOneScore++;
            }
            else if (playerOne.choice.name == "scissors" && playerTwo.choice.name == "scissors")
            {
                Console.WriteLine("Player one chose scissors and player two chose scissors. Noone gets a point");
            }
            else if (playerOne.choice.name == "scissors" && playerTwo.choice.name == "lizard")
            {
                Console.WriteLine("Player one chose scissors and player two chose lizard. Player one gets a point");
                playerOneScore++;
            }
            else if (playerOne.choice.name == "scissors" && playerTwo.choice.name == "spock")
            {
                Console.WriteLine("Player one chose scissors and player two chose spock. Player two gets a point");
                playerTwoScore++;
            }
        }

        public void CompareLizardToOtherGestures()
        {
            if (playerOne.choice.name == "lizard" && playerTwo.choice.name == "rock")
            {
                Console.WriteLine("Player one chose lizard and player two chose rock. Player two gets a point");
                playerTwoScore++;
            }
            else if (playerOne.choice.name == "lizard" && playerTwo.choice.name == "paper")
            {
                Console.WriteLine("Player one chose lizard and player two chose paper. Player one gets a point");
                playerOneScore++;
            }
            else if (playerOne.choice.name == "lizard" && playerTwo.choice.name == "scissors")
            {
                Console.WriteLine("Player one chose lizard and player two chose scissors. Player two gets a point");
                playerTwoScore++;
            }
            else if (playerOne.choice.name == "lizard" && playerTwo.choice.name == "lizard")
            {
                Console.WriteLine("Player one chose lizard and player two chose lizard. Noone gets a point");
            }
            else if (playerOne.choice.name == "lizard" && playerTwo.choice.name == "spock")
            {
                Console.WriteLine("Player one chose lizard and player two chose spock. Player one gets a point");
                playerOneScore++;
            }
        }

        public void CompareSpockToOtherGestures()
        {
            if (playerOne.choice.name == "spock" && playerTwo.choice.name == "rock")
            {
                Console.WriteLine("Player one chose spock and player two chose rock. Player one gets a point");
                playerOneScore++;
            }
            else if (playerOne.choice.name == "spock" && playerTwo.choice.name == "paper")
            {
                Console.WriteLine("Player one chose spock and player two chose paper. Player two gets a point");
                playerTwoScore++;
            }
            else if (playerOne.choice.name == "spock" && playerTwo.choice.name == "scissors")
            {
                Console.WriteLine("Player one chose spock and player two chose scissors. Player one gets a point");
                playerOneScore++;
            }
            else if (playerOne.choice.name == "spock" && playerTwo.choice.name == "lizard")
            {
                Console.WriteLine("Player one chose spock and player two chose lizard. Player two gets a point");
                playerTwoScore++;
            }
            else if (playerOne.choice.name == "spock" && playerTwo.choice.name == "spock")
            {
                Console.WriteLine("Player one chose spock and player two chose spock. Noone gets a point");
            }
        }

        public void PlayGame()
        {
            DisplayRules();
            string playerAmount = OneOrTwoPlayer();
            
            while (playerOneScore < 2 || playerTwoScore < 2)
            {
                if (playerAmount == "2")
                {
                    playerOne.ShootGesture();
                    playerTwo.ShootGesture();
                    Compare();
                }
                else if (playerAmount == "1")
                {
                    playerOne.ShootGesture();
                    playerTwo.ShootGesture();
                    Compare();
                }
                
            }
            DisplayWinner();
            Console.ReadLine();

        }
    }
}
