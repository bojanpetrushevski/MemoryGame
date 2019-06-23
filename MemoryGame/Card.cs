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
    public class Card
    {
        public Bitmap Image { set; get; }
        public PictureBox ImageFrame { set; get; }
        public static int Width { set; get; }
        public static int Height { set; get; }
        public bool IsOpen { set; get; }
        public bool Paired { set; get; }
        public Card (Bitmap Image, PictureBox ImageFrame, int Width, int Height)
        {
            this.Image = Image;
            this.ImageFrame = ImageFrame;
            Card.Width = Width;
            Card.Height = Height;
            IsOpen = false;
            Paired = false;
        }
        public void Toggle()
        {
            if(!Paired)
            {
                if (BitmapComparator.CompareBitmaps((Bitmap)ImageFrame.Image, Resources.question_mark))
                    ImageFrame.Image = Image;
                else
                    ImageFrame.Image = Resources.question_mark;
            }
        }
      
    }
}
