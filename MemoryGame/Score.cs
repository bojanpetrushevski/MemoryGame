using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class Score
    {
        public Player Player { set; get; }
        public int FinishedTime { set; get; }
        public DateTime Date { set; get; }
        public Score(Player player, int finishedTime)
        {
            Player = player;
            FinishedTime = finishedTime;
            Date = DateTime.Now;
        }
    }
}
