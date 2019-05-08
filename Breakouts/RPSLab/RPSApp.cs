using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab
{
    class RPSApp
    {
        Random rando = new Random();
        public void Run()
        {
            //User player should go here eventually 
            Rocky r = new Rocky("Billy");
            Player opponent = new Rocky("error");
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Please select an opponent type either rocky or randy");
                string input = Console.ReadLine();
               

                if (input == "rocky")
                {
                    opponent = new Rocky("The Rock");
                    run = false;
                }
                else if (input == "randy")
                {
                    opponent = new Randy("Randy Marsh", rando);
                    run = false;
                }
                else
                {
                    Console.WriteLine("Sorry I didn't understand that, please try again");
                }
            }

            string userRPS = r.GenerateRoShamBo();
            string opponentRPS = opponent.GenerateRoShamBo();

            Console.WriteLine($"You just threw {userRPS}");
            Console.WriteLine($"Opponent {opponent.Name} threw {opponentRPS}");
            if (userRPS == opponentRPS)
            {
                Console.WriteLine("Draw!");
            }
            else if (userRPS == RPS.Rock)
            {
                if(opponentRPS== RPS.Paper)
                {
                    Console.WriteLine("Opponent wins!");
                }
                else if (opponentRPS == RPS.Scissors)
                {
                    Console.WriteLine("You win!");
                }
            }
            else if(userRPS == RPS.Scissors)
            {
                if(opponentRPS == RPS.Paper)
                {
                    Console.WriteLine("You win!");
                }
                else if(opponentRPS == RPS.Rock)
                {
                    Console.WriteLine("Opponent wins!");
                }
            }
        }
    }
}
