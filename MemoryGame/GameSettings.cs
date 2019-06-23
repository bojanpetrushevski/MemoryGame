﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class GameSettings
    {
        public int Width { set; get; }
        public int Height { set; get; }
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
        }
        public new string ToString()
        {
            return String.Format("GameMode: {0}\nGameCategory:{1}\nSound: {2}\nCardColor: {3}", GameMode, SelectedCategory, Sound, CardColor);
        }
    }
}