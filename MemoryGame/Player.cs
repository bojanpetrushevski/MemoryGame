using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class Player
    {
        public string Name { set; get; }
        public Player(string name)
        {
            Name = name;
        }
    }
}
