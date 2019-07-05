using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    /// <summary>
    /// Class that represents the game logic.
    /// </summary>
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
        /// <summary>
        /// Tries to open the card if it is not already opened.
        /// </summary>
        /// <param name="clickedFrame">The clicked PictureBox.</param>
        /// <returns>True if card was not paired and is successfully opened, otherwise false.</returns>
        public bool OpenCard(PictureBox clickedFrame)
        {
            foreach (Card c in Cards)
                if(!c.IsOpen)
                    if (c.ImageFrame == clickedFrame)
                        return c.Toggle();
            return false;
        }
        /// <summary>
        /// Checks if two cards are paired by their images.
        /// </summary>
        /// <returns>Returns null if there are less the 2 open cards, otherwise it return pair of cards. If cards images are equal the pair will be valid pair.</returns>
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
        /// <summary>
        /// Marks the cards as paired.
        /// </summary>
        /// <param name="c1">The first card.</param>
        /// <param name="c2">The second card.</param>
        public void Hit(Card c1, Card c2)
        {
            c1.MarkPaired();
            c2.MarkPaired();
        }
        /// <summary>
        /// Closes the cards, but it waits before it for half second for the user to see them. 
        /// </summary>
        /// <param name="c1">The first card.</param>
        /// <param name="c2">The second card.</param>
        public async void Miss(Card c1, Card c2)
        { 
            ToggleBlocked();
            await PutTaskDelay(500);
            c1.Toggle();
            c2.Toggle();
            ToggleBlocked();
        }
        /// <summary>
        /// Changes color of the card.
        /// </summary>
        /// <param name="hoveredFrame">The hovered PictureBox.</param>
        public void UpdateCardColor(PictureBox hoveredFrame)
        {
            foreach (Card c in Cards)
                if (c.ImageFrame == hoveredFrame)
                    c.ChangeColor();
        }
        /// <summary>
        /// Waits for <para>miliseconds</para> seconds.
        /// </summary>
        /// <param name="miliseconds">The milisecond for waiting.</param>
        /// <returns></returns>
        public async Task PutTaskDelay(int miliseconds)
        {
            await Task.Delay(miliseconds);
        }
        /// <summary>
        /// Blocks/unblocks the game.
        /// </summary>
        public void ToggleBlocked()
        {
            Blocked = !Blocked;
        }
        /// <summary>
        /// Checks if two cards are equal by their images.
        /// </summary>
        /// <param name="c1">The first card.</param>
        /// <param name="c2">The second card.</param>
        /// <returns></returns>
        public bool CheckEqualCards(Card c1, Card c2)
        {
            return BitmapComparator.CompareBitmaps(c1.Image, c2.Image);
        }
        /// <summary>
        /// Checks if the game is over.
        /// </summary>
        /// <returns>Returns true if game is over, otherwise false.</returns>
        public bool IsGameOver()
        {
            return OpenCards == Cards.Count;
        }
        /// <summary>
        /// When there is new pair, this method increases the number of open cards for 2.
        /// </summary>
        public void UpdateOpenCards()
        {
            OpenCards += 2;
        }
    }
}
