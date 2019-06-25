using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class SingleplayerGame : Game
    {
        public int TimeElapsed { set; get; }
        public int Pairs { set; get; }
        public SingleplayerGame(List<Card> cards) : base(cards)
        {
            TimeElapsed = 0;
            Pairs = 0;
        }
        public void UpdateTime()
        {
            TimeElapsed++;
        }
        public void UpdatePairs()
        {
            Pairs++;
        }
    }
}
