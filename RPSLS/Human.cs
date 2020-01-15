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
        //public override void Move()
        //{
        //    Console.WriteLine("Choose a move" + name);
        //    //startRound();
        //    //return startRound();
        //    //return base.Move();
        //}
        public override void Move()
        {
            Console.WriteLine(name + " choose between Rock, Paper, Scissors, Lizard, Spock");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "Rock":
                    Console.WriteLine(name + " you chose Rock!");

                    break;
                case "Paper":
                    Console.WriteLine(name + " you chose Paper!");
                    break;

                case "Scissors":
                    Console.WriteLine(name + " you chose Scissors!");
                    break;
                case "Lizard":
                    Console.WriteLine(name + " you chose Lizard!");
                    break;
                case "Spock":
                    Console.WriteLine(name + " you chose Spock!");
                    break;
                default:
                    Console.WriteLine(name + " Not a valid move choice");
                    break;
            }   


        }

             
                
             

           
        
    }   
}
