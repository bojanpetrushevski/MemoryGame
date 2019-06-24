using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public class CardsCreator
    {
        public GameSettings Settings { set; get; }
        public static Random Random = new Random();
        public PictureBox[] ImageFrames { set; get; }
        public CardsCreator(GameSettings gameSettings, PictureBox[] imageFrames)
        {
            Settings = gameSettings;
            ImageFrames = imageFrames;
        }
    }
}
