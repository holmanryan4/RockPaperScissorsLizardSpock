using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        public string start;
        public Player player1;
        public Player player2;
        public string 
        //Member Variables (HAS A)

        //Constructor
        //public Game()
        //{
        //    player1 = new Human("john");

        //}
        //Member Methods (CAN DO)
        //player1.chooseMove;

            //display welcome message
            public void Rungame()
        {
            Console.WriteLine("Hello and Welcome to the game Rock Paper Scissor Lizard Spock!");
            Console.WriteLine("Would you like to play?  Y for yes, N for no");
            Console.ReadLine();
            string input;
            do
            {
                Console.WriteLine("GREAT!");
                Console.WriteLine("The rules of the game are simple! Best of 3, and you pick one of the following:  Rock, Paper, Scissor, Lizard, or Spock each round. ");
                Console.WriteLine("Listed below are the ways you can win the game.");
                Console.WriteLine("/n Rock -crushes Scissors \n Scissors cuts Paper \n");
                input = Console.ReadLine();
            }
            while (input = Y);
        }
        
    }
}
