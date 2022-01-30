using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder");
            SnakeAndLadderGm snakeAndLadderGm = new SnakeAndLadderGm();
            snakeAndLadderGm.DiceRoll();
            snakeAndLadderGm.Play();
            Console.WriteLine("Ending to snake and ladder");
            
        }

    }
}
