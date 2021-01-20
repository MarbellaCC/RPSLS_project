using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        //Member Variable
        public Gesture choice;
        public List<Gesture> gestures;
        public string playerTwo;
        //Construcor
        public Player()
        {
            gestures = new List<Gesture>();

            Rock rock = new Rock("rock");
            Paper paper = new Paper("paper");
            Scissor scissors = new Scissor("scissors");
            Lizard lizard = new Lizard("lizard");
            Spock spock = new Spock("spock");

            gestures.Add(rock);
            gestures.Add(paper);
            gestures.Add(scissors);
            gestures.Add(lizard);
            gestures.Add(spock);

        }
        //Member Methods
        public abstract void ShootGesture();
    }
}
