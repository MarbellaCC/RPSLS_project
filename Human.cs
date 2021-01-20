using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        //Member Variable

        //Construcor

        //Member Methods
        public override void ShootGesture()
        {
            Console.WriteLine("What gesture would you like to use? Your options are rock, paper, scissors, lizard, or spock");
            string userInputChoice = Console.ReadLine();

            if (userInputChoice == "rock")
            {
                choice = gestures[0];
            }
            else if (userInputChoice == "paper")
            {
                choice = gestures[1];
            }
            else if (userInputChoice == "scissors")
            {
                choice = gestures[2];
            }
            else if (userInputChoice == "lizard")
            {
                choice = gestures[3];
            }
            else if (userInputChoice == "spock")
            {
                choice = gestures[4];
            }
            else
            {
                Console.WriteLine("Try again");
                ShootGesture();
            }
        }
        
        
    }
}
