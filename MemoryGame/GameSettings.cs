using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    /// <summary>
    /// Class that has all the game settings selected by thr user.
    /// </summary>
    public class GameSettings
    {
        public int Width { set; get; }
        public int Height { set; get; }
        public static int CardDistance = 10;
        public static int HorizontalOffset = 150;
        public static int VerticalOffset = 150;
        public GameMode.PlayingMode GameMode { set; get; }
        public GameCategory SelectedCategory { set; get; }
        public bool Sound { set; get; }
        public Color CardColor { set; get; }
        public GameSettings(GameMode.PlayingMode gameMode, GameCategory selectedCategory, bool sound, Color cardColor)
        {
            GameMode = gameMode;
            SelectedCategory = selectedCategory;
            Sound = sound;
            CardColor = cardColor;
            CalculateWidth();
            CalculateHeight();
        }
        /// <summary>
        /// Calculates game screen width.
        /// </summary>
        public void CalculateWidth()
        {
            Width = (SelectedCategory.Columns * SelectedCategory.CardWidth) + ((SelectedCategory.Columns - 1) * CardDistance) + (2 * HorizontalOffset);
        }
        /// <summary>
        /// Calculates game screen height.
        /// </summary>
        public void CalculateHeight()
        {
            Height = (SelectedCategory.Rows * SelectedCategory.CardHeight) + ((SelectedCategory.Rows - 1) * CardDistance) + (VerticalOffset + VerticalOffset / 2);
        }
    }
}
