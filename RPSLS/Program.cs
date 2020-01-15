using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Game rungame = new Game();
            rungame.Rungame();
            
            
            rungame.ChooseNumofplayer();

            //Human human = new Human(Console.ReadLine());
            ////human.chooseMove;
            Console.ReadLine();
             
            


        }
    }
}
