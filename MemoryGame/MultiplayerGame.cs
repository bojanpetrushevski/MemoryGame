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
        public Player OnTurn { set; get; }
        public MultiplayerGame(List<Card> Cards) : base(Cards)
        {
            
        }
        public void CreatePlayers(string name1, string name2)
        {
            Player1 = new Player(name1, 0, 0);
            Player2 = new Player(name2, 0, 0);
            PlayerToStart();
        }
        public void PlayerToStart()
        {
            Random random = new Random();
            if (random.Next(2) == 0)
                OnTurn = Player1;
            else
                OnTurn = Player2;
        }
        public void UpdatePairs()
        {
            OnTurn.Pairs++;
        }
        public void ChangeTurn()
        {
            if (OnTurn == Player1)
                OnTurn = Player2;
            else
                OnTurn = Player1;
        }
    }
}
