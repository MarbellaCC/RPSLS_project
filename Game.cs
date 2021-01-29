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
        public Player playerOne;
        public Player playerTwo;

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
        
        public void OneOrTwoPlayer()
        {
            Console.WriteLine("For single player press one, for multiplayer press two");
            string numberOfPlayers = Console.ReadLine();
            switch (numberOfPlayers)
            {
                case "1":
                    playerOne = new Human();
                    playerTwo = new Computer();
                    break;
                case "2":
                    playerOne = new Human();
                    playerTwo = new Human();
                    break;
                default:
                    Console.WriteLine("Input invalid try again");
                    OneOrTwoPlayer();
                    break;
            }
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
            if(playerOne.choice.name == "rock")
            {
                if (playerTwo.choice.name == "rock")
                {
                    Console.WriteLine("Player one chose rock and player two also chose rock. Noone receives a point");
                }
                else if(playerTwo.choice.name == "paper")
                {
                    Console.WriteLine("Player one chose rock and player two chose paper. Player two gets a point");
                    playerTwoScore++;
                }
                else if(playerTwo.choice.name == "scissors")
                {
                    Console.WriteLine("Player one chose rock and player two chose scissors. Player one gets a point");
                    playerOneScore++;
                }
                else if(playerTwo.choice.name == "lizard")
                {
                    Console.WriteLine("Player one chose rock and player two chose lizard. Player one gets a point");
                    playerOneScore++;
                }
                else
                {
                    Console.WriteLine("Player one chose rock and player two chose spock. Player two gets a point");
                    playerTwoScore++;
                }
            }
        }
        public void ComparePaperToOtherGestures()
        {
            if(playerOne.choice.name == "paper")
            {
                if(playerTwo.choice.name == "rock")
                {
                    Console.WriteLine("Player one chose paper and player two chose rock. Player one gets a point");
                    playerOneScore++;
                }
                else if(playerTwo.choice.name == "paper")
                {
                    Console.WriteLine("Player one chose paper and player two chose paper. Noone gets a point");
                }
                else if(playerTwo.choice.name == "scissors")
                {
                    Console.WriteLine("Player one chose paper and player two chose scissors. Player two gets a point");
                    playerTwoScore++;
                }
                else if(playerTwo.choice.name == "lizard")
                {
                    Console.WriteLine("Player one chose paper and player two chose lizard. Player two gets a point");
                    playerTwoScore++;
                }
                else
                {
                    Console.WriteLine("Player one chose paper and player two chose spock. Player one gets a point");
                    playerOneScore++;
                }
            }
        }

        public void CompareScissorsToOtherGestures()
        {
            if(playerOne.choice.name == "scissors")
            {
                if(playerTwo.choice.name == "rock")
                {
                    Console.WriteLine("Player one chose scissors and player two chose rock. Player two gets a point");
                    playerTwoScore++;
                }
                else if(playerTwo.choice.name == "paper")
                {
                    Console.WriteLine("Player one chose scissors and player two chose paper. Player one gets a point");
                    playerOneScore++;
                }
                else if(playerTwo.choice.name == "scissors")
                {
                    Console.WriteLine("Player one chose scissors and player two chose scissors. Noone gets a point");
                }
                else if(playerTwo.choice.name == "lizard")
                {
                    Console.WriteLine("Player one chose scissors and player two chose lizard. Player one gets a point");
                    playerOneScore++;
                }
                else
                {
                    Console.WriteLine("Player one chose scissors and player two chose spock. Player two gets a point");
                    playerTwoScore++;
                }
            }
        }

        public void CompareLizardToOtherGestures()
        {
            if (playerOne.choice.name == "lizard")
            {
                if (playerTwo.choice.name == "rock")
                {
                    Console.WriteLine("Player one chose lizard and player two chose rock. Player two gets a point");
                    playerTwoScore++;
                }
                else if(playerTwo.choice.name == "paper")
                {
                    Console.WriteLine("Player one chose lizard and player two chose paper. Player one gets a point");
                    playerOneScore++;
                }
                else if(playerTwo.choice.name == "scissors")
                {
                    Console.WriteLine("Player one chose lizard and player two chose scissors. Player two gets a point");
                    playerTwoScore++;
                }
                else if(playerTwo.choice.name == "lizard")
                {
                    Console.WriteLine("Player one chose lizard and player two chose lizard. Noone gets a point");
                }
                else if(playerTwo.choice.name == "spock")
                {
                    Console.WriteLine("Player one chose lizard and player two chose spock. Player one gets a point");
                    playerOneScore++;
                }
            }
        }

        public void CompareSpockToOtherGestures()
        {
            if (playerOne.choice.name == "spock")
            {
                if (playerTwo.choice.name == "rock")
                {
                    Console.WriteLine("Player one chose spock and player two chose rock. Player one gets a point");
                    playerOneScore++;
                }
                else if(playerTwo.choice.name == "paper")
                {
                    Console.WriteLine("Player one chose spock and player two chose paper. Player two gets a point");
                    playerTwoScore++;
                }
                else if(playerTwo.choice.name == "scissors")
                {
                    Console.WriteLine("Player one chose spock and player two chose scissors. Player one gets a point");
                    playerOneScore++;
                }
                else if(playerTwo.choice.name == "lizard")
                {
                    Console.WriteLine("Player one chose spock and player two chose lizard. Player two gets a point");
                    playerTwoScore++;
                }
                else
                {
                    Console.WriteLine("Player one chose spock and player two chose spock. Noone gets a point");
                }
            }
        }

        public void PlayGame()
        {
            DisplayRules();
            OneOrTwoPlayer();
            
            while (playerOneScore < 3 && playerTwoScore < 3)
            {
                playerOne.ShootGesture();
                playerTwo.ShootGesture();
                Compare(); 
            }
            
            DisplayWinner();
            Console.ReadLine();
        }
    }
}
