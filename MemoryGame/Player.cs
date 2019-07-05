using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    /// <summary>
    /// Represents a player that plays the game. 
    /// If the game is singleplayer, this class is used for storing score. 
    /// If the game is multiplayer, this class is used for keeping evidence of players names.
    /// </summary>
    public class Player
    {
        public string Name { set; get; }
        public int Pairs { set; get; }
        public int ElapsedTime { set; get; }
        public Player(string name, int pairs, int elapsedTime)
        {
            Name = name;
            Pairs = pairs;
            ElapsedTime = elapsedTime;
        }
    }
}
