using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {

        //Member Variables (HAS A)
        int randomInt;


        //Constructor

        public Computer(string name)
        {
            this.name = name;
        }
        //Member Methods (CAN DO)
        public override void Move()
        {
            do
            {

                int scorePlayer1 = 0;
                int scorePlayer2 = 0;

                while (scorePlayer1 < 3 && scorePlayer2 < 3)
                {
                    
                    //player1.Move();
                    //player2.Move();
                    //CompareGesture();
                    Random round = new Random();
                    randomInt = round.Next(1, 5);


                    
                }
                switch (randomInt)
                {

                }

            } while (PlayAgain);
            //Console.WriteLine("Choose a move" + name);
            //startRound();
            //return startRound();
            //return base.Move();
        }
    }
    
}
