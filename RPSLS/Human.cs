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

        //Member Methods (CAN DO)
        public override void Move()
        {
            Console.WriteLine("Choose a move" + name);
            startRound();
            //return startRound();
            //return base.Move();
        }

        public Human(string name)
        {

            Console.WriteLine("Player1 what is your name?");
            name = Console.ReadLine();

            this.name = name;
        }
        //public override chooseMove()
        //{
        //    //return base.chooseMove();
            
        //        Console.WriteLine("Choose a move");
        //        //move = Console.ReadLine();
            
        //}
    }
}
