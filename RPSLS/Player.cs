using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        //Member variables (Has A)
        public string name;
        //public string moves;

        Move rock = new Move("rock");
        Move paper = new Move("paper");
        Move scissor = new Move("scissor");
        Move lizard = new Move("lizard");
        Move spock = new Move("spock");
        public List<Move> moves = new List<Move>();

        //Constructor
        public Player()
        {
            moves.Add(rock);
            moves.Add(paper);
            moves.Add(scissor);
            moves.Add(lizard);
            moves.Add(spock);

        }

        //member methods (Can Do)
        public virtual int chooseMove()
        {
            Console.WriteLine(name + " Please pick a move");
            Console.WriteLine("0 for rock, 1 for paper, 2 for scissor, 3 for lizard, 4 for spock");
            int choice =Int32.Parse(Console.ReadLine());
            Console.ReadLine();
            return choice;
        }
            

       

        

    }
}
