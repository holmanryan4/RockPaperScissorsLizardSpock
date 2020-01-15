using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
     public class Human : Player
    {

        //Member Variables (HAS A)

        //Constructor
        public Human(string namepassedin)
        {

           

            this.name = namepassedin;
        }
        //Member Methods (CAN DO)
        public override void Move()
        {
            Console.WriteLine("Choose a move" + name);
            //startRound();
            //return startRound();
            //return base.Move();
        }

        
        //public override chooseMove()
        //{
        //    //return base.chooseMove();
            
        //        Console.WriteLine("Choose a move");
        //        //move = Console.ReadLine();
            
        //}
    }
}
