﻿using System;
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
        public string input;
        //Member Variables (HAS A)

        //Constructor
        //public Game()
        //{
        //    player1 = new Human("john");

        //}
        //Member Methods (CAN DO)
        //player1.chooseMove;


        //Member Methods (CAN DO)
        //display welcome message
        public void Rungame()
        {
            Console.WriteLine("Hello and Welcome to the game Rock Paper Scissor Lizard Spock!");
            Console.WriteLine("Would you like to play?  Y for yes, N for no");
            //Console.ReadLine();
            string input;
            input = Console.ReadLine();

            if (input == "y")
            {
                Console.WriteLine("GREAT!");
                Console.WriteLine("The rules of the game are simple! Best of 3 and pick one of the following moves from the list each round: \n Rock, Paper, Scissor, Lizard, or Spock. ");
                Console.ReadLine();
                Console.WriteLine("Listed below are the ways you can win the game.");
                Console.WriteLine("Rock crushes Scissors \nScissors cuts Paper \nPaper covers Rock \nRock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock");
                Console.ReadLine();
            }
            else if (input == "n")
            {

                Console.WriteLine("Okay :( \n Maybe next time!");

            }
           
            
         

        }
        public void chooseNumofplayer()
        {
            Console.WriteLine("Now that you know how to play let pick how many players are playing. \nWill there be One or Two players?");
            string response = Console.ReadLine();
            switch(response)
            {
                case "1":
                    player1 = new Human("Bob");
                    player2 = new Computer("C3PO");
                    Console.WriteLine("Hello Bob and C3PO get ready to shoot!");
                    break;
                case "2":
                    player1 = new Human("Bob");
                    player2 = new Human("John");
                    Console.WriteLine("Hello Bob and John get ready to shoot!");
                    break;
                default:
                    Console.WriteLine("Not a valid option");

            }
            switch("1")
            {
                case "Rock":
                    break;
                case "Paper":
                    break;

                case "Scissors":
                    break;
                case "Lizard":
                    break;
                case "Spock":
                    break;
            }
        }
    }
}
