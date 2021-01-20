using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //Member Variable
        Random rand;
        
        //Construcor
        public Computer()
        {
            rand = new Random();
        }
        
        //Member Methods
        public override void ShootGesture()
        {
            int randomNumber = rand.Next(0, 5);
            choice = gestures[randomNumber];
            Console.WriteLine("the computer chose " + choice);

        }

        
    }

}
