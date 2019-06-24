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
        public Game(List<Card> cards)
        {
            this.Cards = cards;
            Blocked = false;
        }
        public void CheckClicked(PictureBox ClickedFrame)
        {
            if (!Blocked)
            {
                foreach (Card c in Cards)
                    if (c.ImageFrame == ClickedFrame)
                        c.Toggle();
                CheckState();
            }
        }
        public void CheckState()
        {
            if (NumberOfOpenCards() == 2)
                CheckPair();
            if (IsGameOver())
                MessageBox.Show("GAME OVER!");

        }
        public async void CheckPair()
        {
            Card c1 = null;
            Card c2 = null;
            foreach (Card c in Cards)
                if (!c.Paired && c.IsOpen)
                    if (c1 == null)
                        c1 = c;
                    else
                        c2 = c;
            if (CheckEqualCards(c1, c2))
            {
                c1.Paired = true;
                c2.Paired = true;
            }
            else
            {
                Blocked = true;
                await PutTaskDelay(2000);
                c1.Toggle();
                c2.Toggle();
                Blocked = false;
            }
        }
        public int NumberOfOpenCards()
        {
            int open = 0;
            foreach (Card c in Cards)
                if (!c.Paired && c.IsOpen)
                    open++;
            return open;
        }
        public bool CheckEqualCards(Card c1, Card c2)
        {
            return BitmapComparator.CompareBitmaps(c1.Image, c2.Image);
        }
        public bool IsGameOver()
        {
            foreach (Card c in Cards)
                if (!c.Paired)
                    return false;
            return true;
        }
        public async Task PutTaskDelay(int miliseconds)
        {
            await Task.Delay(miliseconds);
        }
    }
}
