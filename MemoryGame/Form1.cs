using MemoryGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        public Options Options { set; get; }
        public Form1()
        {
            InitializeComponent();
            Options = new Options(this);
        }

        private void lbPlay_MouseEnter(object sender, EventArgs e)
        {
            lbPlay.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lbPlay_MouseLeave(object sender, EventArgs e)
        {
            lbPlay.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void rbSinglePlayer_MouseEnter(object sender, EventArgs e)
        {
            rbSinglePlayer.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void rbSinglePlayer_MouseLeave(object sender, EventArgs e)
        {
            rbSinglePlayer.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void rbMultiPlayer_MouseEnter(object sender, EventArgs e)
        {
            rbMultiPlayer.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void rbMultiPlayer_MouseLeave(object sender, EventArgs e)
        {
            rbMultiPlayer.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void rb4x4_MouseEnter(object sender, EventArgs e)
        {
            rb4x4.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void rb4x4_MouseLeave(object sender, EventArgs e)
        {
            rb4x4.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void rb4x5_MouseEnter(object sender, EventArgs e)
        {
            rb4x5.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void rb4x5_MouseLeave(object sender, EventArgs e)
        {
            rb4x5.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void rb4x6_MouseEnter(object sender, EventArgs e)
        {
            rb4x6.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void rb4x6_MouseLeave(object sender, EventArgs e)
        {
            rb4x6.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lbBestScores_MouseEnter(object sender, EventArgs e)
        {
            lbBestScores.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lbBestScores_MouseLeave(object sender, EventArgs e)
        {
            lbBestScores.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lbOptions_MouseEnter(object sender, EventArgs e)
        {
            lbOptions.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lbOptions_MouseLeave(object sender, EventArgs e)
        {
            lbOptions.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lbAbout_MouseEnter(object sender, EventArgs e)
        {
            lbAbout.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lbAbout_MouseLeave(object sender, EventArgs e)
        {
            lbAbout.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lbExit_MouseEnter(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lbExit_MouseLeave(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exit exitForm = new Exit(this);
            exitForm.ShowDialog();
        }

        private void lbOptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options.ShowDialog();
        }

        private void lbPlay_Click(object sender, EventArgs e)
        {
            GameMode.PlayingMode selectedMode = GetSelectedMode();
            GameCategory selectedCateogry = GetSelectedCategory();
            bool sound = GetSound();
            Color selectedColor = GetColor();
            GameSettings gameSettings = new GameSettings(selectedMode, selectedCateogry, sound, selectedColor);
        }
        private GameMode.PlayingMode GetSelectedMode()
        {
            if (rbSinglePlayer.Checked)
                return GameMode.PlayingMode.SinglePlayer;
            else
                return GameMode.PlayingMode.MultiPlayer;
        }
        private GameCategory GetSelectedCategory()
        {
            if (rb4x4.Checked)
                return new GameCategory4x4();
            else if (rb4x5.Checked)
                return new GameCategory4x5();
            else
                return new GameCategory4x6();
        }
        private bool GetSound()
        {
            if (Options.ButtonText == "ON")
                return true;
            else
                return false;
        }
        private Color GetColor()
        {
            if (Options.DropDownSelectedItem == "Blue")
                return Color.Blue;
            else
                return Color.White;
        }
    }
}
