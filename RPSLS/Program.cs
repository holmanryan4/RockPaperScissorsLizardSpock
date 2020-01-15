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
            //Computer C3PO = new Computer("C3PO");
            //int choice.
            Game rungame = new Game();
            rungame.Rungame();
            //rungame.chooseNumofplayer();
            Console.ReadLine();
           
            Human human = new Human(Console.ReadLine());
            //human.chooseMove;
            Console.ReadLine();
             
            


        }
    }
}
