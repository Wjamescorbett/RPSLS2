using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HumanPlayer playerOne = new HumanPlayer();

            playerOne.playername = "playerOne";
            playerOne.score = 0;
            playerOne.gesture = "None";
            playerOne.tiecounter = 0;

            Console.WriteLine(playerOne.playername + " has " + playerOne.score + " points!");
            Console.ReadLine();
        }
    }
}
