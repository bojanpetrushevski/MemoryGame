using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class Pair
    {
        public Card Card1 { set; get; }
        public Card Card2 { set; get; }
        public bool ValidPair { set; get; }
        public Pair(Card card1, Card card2, bool validPair)
        {
            Card1 = card1;
            Card2 = card2;
            ValidPair = validPair;
        }
    }
}
