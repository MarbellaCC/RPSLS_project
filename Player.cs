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
        public List<Gesture> gestures;


        //Construcor
        public Player()
        {
            gestures = new List<Gesture>();
            Gesture rock = new Gesture("rock");
            Gesture paper = new Gesture("paper");
            Gesture scissors = new Gesture("scissors");
            Gesture lizard = new Gesture("lizard");
            Gesture spock = new Gesture("spock");
            gestures.Add(rock);
            gestures.Add(paper);
            gestures.Add(scissors);
            gestures.Add(lizard);
            gestures.Add(spock);
        }
        //Member Methods
        public abstract void ShootGesture(Player player);

        
       


    }
}
