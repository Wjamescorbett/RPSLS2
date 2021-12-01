using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    public class ClassAiPlayer : Player
    {
        public List<string> gestures;

        public ClassAiPlayer()
        {

        }

        public ClassAiPlayer(string playername, int score, string gestures)
        {
            this.playername = playername;
            this.score = score;
            this.gestures = new List<string>();
        }

        public void gestureList()
        {
            this.gestures.Add("rock");
            this.gestures.Add("paper");
            this.gestures.Add("scissors");
            this.gestures.Add("lizard");
            this.gestures.Add("spock");
        }

        public string randomGesture()
        {
            Random rnd = new Random();
            int index = rnd.Next(5);
            return this.gestures[index];
        }
    }
}
