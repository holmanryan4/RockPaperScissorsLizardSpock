using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {

        //Member Variables (HAS A)
        Random round = new Random();
       

        //Constructor

        public Computer(string name)
        {
            this.name = name;
        }
        //Member Methods (CAN DO)
        public override void ChooseGesture()
        {

            int randomNum = round.Next(1, 5);
            choice = gestures[randomNum];
            Console.WriteLine("C3PO you chose " + choice);
            

        }
    }
    
}
