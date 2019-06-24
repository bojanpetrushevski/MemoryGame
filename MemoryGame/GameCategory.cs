using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class GameCategory
    {
        public int NumberOfCards { set; get; }
        public int Rows { set; get; }
        public int Columns { set; get; }
        public int CardWidth { set; get; }
        public int CardHeight { set; get; }
        public GameCategory(int numberOfCards, int rows, int columns, int cardWidth, int cardHeight)
        {
            this.NumberOfCards = numberOfCards;
            this.Rows = rows;
            this.Columns = columns;
            this.CardWidth = cardWidth;
            this.CardHeight = cardHeight;
        }
    }
}