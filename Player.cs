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
        //Construcor
        public Player()
        {
            gestures = new List<Gesture>();

            Rock rock = new Rock();
            Paper paper = new Paper();
            Scissor scissors = new Scissor();
            Lizard lizard = new Lizard();
            Spock spock = new Spock();

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
