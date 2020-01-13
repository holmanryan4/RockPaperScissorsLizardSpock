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

        
         public virtual void chooseMove()
        {
            Console.WriteLine()
        }
            

        //member methods (Can Do)

        

    }
}
