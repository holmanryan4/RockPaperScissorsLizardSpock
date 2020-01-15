using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //Member Variables (HAS A)
        public string start;
        public Player player1;
        public Player player2;
        public string input;

        public bool PlayAgain = false;

        //Constructor



        //Member Methods (CAN DO)


        //display welcome message
        public void Setup()
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
                Console.ReadLine();
                Console.WriteLine("Rock crushes Scissors \nScissors cuts Paper \nPaper covers Rock \nRock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock");
                Console.ReadLine();
            }
            else if (input == "n")
            {

                Console.WriteLine("Okay :( \n Maybe next time!");
                Console.ReadLine();

            }
            ///// next line still print after selecting no/////
        }
        public void ChooseNumofplayer()
        {
            Console.WriteLine("Now that you know how to play lets pick how many players will be playing. \nWill there be One or Two players?");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    player1 = new Human("Bob");
                    player2 = new Computer("C3PO");
                    Console.WriteLine("Hello Bob and C3PO get ready to play!");

                    break;
                case "2":
                    player1 = new Human("Bob");
                    player2 = new Human("John");
                    Console.WriteLine("Hello Bob and John get ready to play!");
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;

                    //////if player choices an invalid option they can repick/////
            }
        }
        public void RunGame()
        {
            Setup();
            ChooseNumofplayer();

            while (player1.score < 3 && player2.score < 3)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGesture();

                Console.WriteLine($"The current score:  {player1.name}: {player1.score} , {player2.name}: {player2.score}");

            }
        
        }

        public void CompareGesture()
        {
            if (player1.choice == player2.choice)
            {
                Console.WriteLine("Draw");
                //Console.ReadLine();
            }
            else if (player1.choice == "Rock" && player2.choice == "Scissors")
            {
                Console.WriteLine("Rock cruches Scissors!");
                Console.WriteLine(player1.name + " WINS!!");
                player1.score++;
                Console.ReadLine();
            }
            else if (player1.choice == "Rock" && player2.choice == "Lizard")
            {
                Console.WriteLine("Rock cruches Lizard");
                Console.WriteLine(player1.name + " WINS!!");
                player1.score++;
                Console.ReadLine();
            }
            else if (player1.choice == "Paper" && player2.choice == "Rock")
            {
                Console.WriteLine("Paper covers Rock");
                Console.WriteLine(player1.name + "  WINS!!");
                player1.score++;
               
                Console.ReadLine();
            }
            else if (player1.choice == "Paper" && player2.choice == "Spock")
            {
                Console.WriteLine("Paper dispoves Spock");
                Console.WriteLine(player1.name + "  WINS!!");
                player1.score++;
                Console.ReadLine();

            }
            else if (player1.choice == "Scissors" && player2.choice == "Paper")
            {
                Console.WriteLine("Scissors cuts Paper");
                Console.WriteLine(player1.name + "  WINS!!");
                player1.score++;
                Console.ReadLine();
            }
            else if (player1.choice == "Scissors" && player2.choice == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard");
                Console.WriteLine(player1.name + "  WINS!!");
                player1.score++;
                Console.ReadLine();
            }
            else if (player1.choice == "Lizard" && player2.choice == "Paper")
            {
                Console.WriteLine("Lizard eats Paper");
                Console.WriteLine(player1.name + "  WINS!!");
                player1.score++;
                Console.ReadLine();

            }
            else if (player1.choice == "Lizard" && player2.choice == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine(player1.name + "  WINS!!");
                player1.score++;
                Console.ReadLine();
            }
            else if (player1.choice == "Spock" && player2.choice == "Rock")
            {
                Console.WriteLine("Spock vaporizes Rock");
                Console.WriteLine(player1.name + "  WINS!!");
                player1.score++;
                Console.ReadLine();
            }
            else if (player1.choice == "Spock" && player2.choice == "Scissors")
            {
                Console.WriteLine("Spock smashes Scissors");
                Console.WriteLine(player1.name + "  WINS!!");
                player1.score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(player2.name + "  WINS!!");
                
                player2.score++;
                Console.ReadLine();
            }
        }
    }
}


