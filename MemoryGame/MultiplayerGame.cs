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
    public class MultiplayerGame : Game
    {
        public Player Player1 { set; get; }
        public Player Player2 { set; get; }
        //Player reference that will point to the player that is curreny on turn.
        public Player OnTurn { set; get; }
        public MultiplayerGame(List<Card> Cards) : base(Cards) { }
        public void CreatePlayers(string name1, string name2)
        {
            Player1 = new Player(name1, 0, 0);
            Player2 = new Player(name2, 0, 0);
            PlayerToStart();
        }
        /// <summary>
        /// Decides which player will have the first move with random generator.
        /// </summary>
        public void PlayerToStart()
        {
            Random random = new Random();
            if (random.Next(2) == 0)
                OnTurn = Player1;
            else
                OnTurn = Player2;
        }
        /// <summary>
        /// Updates the number of pairs for the player that is currently on turn.
        /// </summary>
        public void UpdatePairs()
        {
            OnTurn.Pairs++;
        }
        /// <summary>
        /// Gives the turn away to the other player.
        /// </summary>
        public void ChangeTurn()
        {
            if (OnTurn == Player1)
                OnTurn = Player2;
            else
                OnTurn = Player1;
        }
    }
}
