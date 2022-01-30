using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadderGm
    {
        const int NOPLAY = 0, LADDER= 1, SNAKE= 2, WINNING_POSITION=100;
         int PlayerPosition = 0, Count=0;
         Random random = new Random();
        public int DiceRoll()
        {
            Count++;
            return random.Next(1, 7);
        }
        public void Play()
        {
            while(this.PlayerPosition < WINNING_POSITION)
            {
                int option=random.Next(0,3);
                switch(option)
                {
                    case NOPLAY:break;
                    case LADDER:
                        if (this.PlayerPosition + DiceRoll() <= 100)
                        {
                           this.PlayerPosition += DiceRoll();
                        }
                        break;
                        case SNAKE:
                        if (this.PlayerPosition - DiceRoll() >= 0)
                        {
                            this.PlayerPosition -= DiceRoll();
                        }
                        else
                        { 
                            this.PlayerPosition = 0;
                        }
                        break ;
                      }
                Console.WriteLine("position of player"+this.PlayerPosition);
            }
            Console.WriteLine("no. of time dice rolled"+Count);

        }
    }
}
