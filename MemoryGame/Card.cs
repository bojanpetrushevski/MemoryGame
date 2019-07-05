using MemoryGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    /// <summary>
    /// Represents simple matching card.
    /// </summary>
    public class Card
    {
        public Bitmap Image { set; get; }
        public PictureBox ImageFrame { set; get; }
        public static int Width { set; get; }
        public static int Height { set; get; }
        public bool IsOpen { set; get; }
        public bool Paired { set; get; }
        public Color PrimaryColor { set; get; }
        public Color CurrentColor { set; get; }
        public Card (Bitmap Image, PictureBox ImageFrame, int Width, int Height)
        {
            this.Image = Image;
            this.ImageFrame = ImageFrame;
            Card.Width = Width;
            Card.Height = Height;
            IsOpen = false;
            Paired = false;
            PrimaryColor = ImageFrame.BackColor;
            CurrentColor = PrimaryColor;
        }
        /// <summary>
        /// Toggles the card.
        /// If it is already paired (paired cards cannot be flipped), this method has no effect. 
        /// </summary>
        public bool Toggle()
        {
            if (!Paired)
            {
                if (BitmapComparator.CompareBitmaps((Bitmap)ImageFrame.Image, Resources.question_mark))
                {
                    ImageFrame.Image = Image;
                    ImageFrame.BackColor = PrimaryColor;
                }
                else
                {
                    ImageFrame.Image = Resources.question_mark;
                    ImageFrame.BackColor = CurrentColor;
                }
                IsOpen = !IsOpen;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Setting the Paired property to true and changing the background of card because it is paired.
        /// </summary>
        public void MarkPaired()
        {
            Paired = true;
            ImageFrame.BackColor = Color.FromArgb(91, 155, 142);
        }
        /// <summary>
        /// If the card wasn't open, it will set its color to opened card color, otherwise it will set its color to the closed card color.
        /// </summary>
        public void ChangeColor()
        {
            if (!Paired)
            {
                if (CurrentColor == PrimaryColor)
                    CurrentColor = Color.FromArgb(190, 210, 216);
                else
                    CurrentColor = PrimaryColor;
                if (!IsOpen)
                    ImageFrame.BackColor = CurrentColor;
            }
            
        }
    }
}
