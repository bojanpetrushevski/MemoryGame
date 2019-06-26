using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public class Game
    {
        public List<Card> Cards { set; get; }
        public bool Blocked { set; get; }
        public int OpenCards { set; get; }
        public Game(List<Card> cards)
        {
            this.Cards = cards;
            Blocked = false;
            OpenCards = 0;
        }
        public void OpenCard(PictureBox clickedFrame)
        {
            foreach (Card c in Cards)
                if(!c.IsOpen)
                    if (c.ImageFrame == clickedFrame)
                        c.Toggle();   
        }
        public Pair CheckPair()
        {
            Card c1 = null;
            Card c2 = null;
            bool validPair = false;
            foreach (Card c in Cards)
                if (!c.Paired && c.IsOpen)
                    if (c1 == null)
                        c1 = c;
                    else
                        c2 = c;
            if (c1 == null || c2 == null)
                return null;
            if (CheckEqualCards(c1, c2))
                validPair = true;
            return new Pair(c1, c2, validPair);
        }
        public void Hit(Card c1, Card c2)
        {
            c1.MarkPaired();
            c2.MarkPaired();
        }
        public async void Miss(Card c1, Card c2)
        { 
            ToggleBlocked();
            await PutTaskDelay(1500);
            c1.Toggle();
            c2.Toggle();
            ToggleBlocked();
        }
        public void UpdateCardColor(PictureBox hoveredFrame)
        {
            foreach (Card c in Cards)
                if (c.ImageFrame == hoveredFrame)
                    c.ChangeColor();
        }
        public async Task PutTaskDelay(int miliseconds)
        {
            await Task.Delay(miliseconds);
        }
        public void ToggleBlocked()
        {
            Blocked = !Blocked;
        }
        public bool CheckEqualCards(Card c1, Card c2)
        {
            return BitmapComparator.CompareBitmaps(c1.Image, c2.Image);
        }
        public bool IsGameOver()
        {
            return OpenCards == Cards.Count;
        }
        public void UpdateOpenCards()
        {
            OpenCards += 2;
        }
    }
}
