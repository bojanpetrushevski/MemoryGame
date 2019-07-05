using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    /// <summary>
    /// Class that represents a multiplayer game logic. Extends from Game class.
    /// </summary>
    public class SingleplayerGame : Game
    {
        public Player Player { set; get; }
        public SingleplayerGame(List<Card> cards) : base(cards)
        {
            Player = new Player("", 0, 0);
        }
        public void UpdateTime()
        {
            Player.ElapsedTime++;
        }
        public void UpdatePairs()
        {
            Player.Pairs++;
        }
    }
}
