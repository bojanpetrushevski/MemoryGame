using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class MultiplayerGame : Game
    {
        public Player Player1 { set; get; }
        public Player Player2 { set; get; }
        public MultiplayerGame(List<Card> Cards) : base(Cards)
        {
            //Player1 = new Player()
        }
    }
}
