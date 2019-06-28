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
    public class CardsCreator
    {
        public GameSettings Settings { set; get; }
        public static Random Random = new Random(Guid.NewGuid().GetHashCode());
        public PictureBox[] ImageFrames { set; get; }
        public Bitmap[] Images { set; get; }
        public CardsCreator(GameSettings gameSettings, PictureBox[] imageFrames)
        {
            Settings = gameSettings;
            ImageFrames = imageFrames;
            Images = GetImages();
        }
        public List<Card> CreateCards()
        {
            List<Card> cards = new List<Card>();
            for (int i = 0; i < Settings.SelectedCategory.NumberOfCards; i++)
            {
                SetImageFrame(ImageFrames[i], i);
                int index = Random.Next(Settings.SelectedCategory.NumberOfCards - i);
                Card c = new Card(Images[index], ImageFrames[i], ImageFrames[i].Width, ImageFrames[i].Height);
                cards.Add(c);
                Swap(index, i);
            }
            return cards;
        }
        public Bitmap[] GetImages()
        {
            Bitmap[] images = new Bitmap[Settings.SelectedCategory.NumberOfCards];
            for(int i = 0; i < Settings.SelectedCategory.NumberOfCards; i++)
            {
                images[i] = CardImages.Images[i];
            }
            return images;
        }
        public void SetImageFrame(PictureBox ImageFrame, int position)
        {
            int column = position % Settings.SelectedCategory.Columns;
            int row = position / Settings.SelectedCategory.Columns;
            ImageFrame.Width = Settings.SelectedCategory.CardWidth;
            ImageFrame.Height = Settings.SelectedCategory.CardHeight;
            ImageFrame.Location = new Point(column * (Settings.SelectedCategory.CardWidth + GameSettings.CardDistance) + GameSettings.HorizontalOffset, row * (Settings.SelectedCategory.CardHeight + GameSettings.CardDistance) + (GameSettings.VerticalOffset / 2));
            ImageFrame.Image = Resources.question_mark;
            ImageFrame.SizeMode = PictureBoxSizeMode.CenterImage;
            ImageFrame.BackColor = Settings.CardColor;
        }
        public void Swap(int position, int offset)
        {
            Bitmap temp = Images[position];
            Images[position] = Images[Settings.SelectedCategory.NumberOfCards - offset - 1];
            Images[Settings.SelectedCategory.NumberOfCards - offset - 1] = temp;
        }
    }
}
