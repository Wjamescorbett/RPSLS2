using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    public class HumanPlayer : Player
    {
        public int tiecounter;
        public string gesture;
        public HumanPlayer()
        {
        }

        public HumanPlayer(string playername, int score, string gesture, int tiecounter)
        {
            this.playername = playername;
            this.score = score;
            this.gesture = gesture;
            this.tiecounter = tiecounter;
        }
    }
}
