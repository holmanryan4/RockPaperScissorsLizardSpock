using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //Member variables (Has A)
        public string name;
        public int score;
        public string choice;

        
        public List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock"};

        //Constructor
        
        


        //member methods (Can Do)
        public abstract void ChooseGesture();







    }
}
