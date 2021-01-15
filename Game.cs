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
        public List<Gesture> gestures;
        


        //Construcor
        public Game(int playerOneScore, int playerTwoScore, int numberOfPlayers)
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            if (numberOfPlayers == 1)
            {
                //playerOne = Human
                //playerTo = Computer
            }
            else if (numberOfPlayers == 2)
            {
                //playerOne & playerTwo = Human
            }
            
        }
        //Member Methods
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock Paper Scissor Lizard Spock");
            Console.WriteLine("You will be playing three rounds best of 3 wins!");
        }
        public int OneOrTwoPlayer()
        {
            Console.WriteLine("For single player type one, for multiplayer type two");
            
            string userInputNumberOfPlayers = Console.ReadLine();
            int numberOfPlayers = Convert.ToInt32(userInputNumberOfPlayers);
            return numberOfPlayers;
        }
      
        
        public void CompareGestures()
        {

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
        public void PlayGame()
        {
            DisplayRules();
            OneOrTwoPlayer();
            while (playerOneScore < 2 || playerTwoScore < 2)
            {
                

                CompareGestures();
            }


        }
    }
}
