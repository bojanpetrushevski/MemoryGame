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
    /// <summary>
    /// Play again form that appears when the game ends.
    /// </summary>
    public partial class PlayAgain : Form
    {
        public Scene Scene { set; get; }
        public Form1 MainMenu { set; get; }
        public PlayAgain(Scene scene, Form1 mainMenu, string message, Player winner)
        {
            InitializeComponent();
            Scene = scene;
            MainMenu = mainMenu;
            SetStatus(message);
            SetAwards(winner);
        }
        public PlayAgain(Scene scene, Form1 mainMenu, string message)
        {
            InitializeComponent();
            Scene = scene;
            MainMenu = mainMenu;
            SetStatus(message);
        }
        public void SetStatus(string message)
        {
            lbStatusMessage.Text = message;
            lbStatusMessage.Location = new Point((this.Width - lbStatusMessage.Width) / 2, 30);
        }
        public void SetAwards(Player winner)
        {
            if(winner != null)
            {
                pbTrophy.Image = Resources.trophy;
            }
            else
            {
                pbMedal1.Image = Resources.medal;
                pbMedal2.Image = Resources.medal;
            }
        }
        private void lbPlayAgain_Click(object sender, EventArgs e)
        {
            if (Scene is SingleplayerScene singleplayerScene)
            {
                this.Dispose();
                singleplayerScene.InitializeGame();
            }
            if (Scene is MultiplayerScene multiplayerScene)
            {
                this.Dispose();
                multiplayerScene.InitializeGame(multiplayerScene.Game.Player1.Name, multiplayerScene.Game.Player2.Name);
            }
        }

        private void lbPlayAgain_MouseEnter(object sender, EventArgs e)
        {
            lbPlayAgain.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lbPlayAgain_MouseLeave(object sender, EventArgs e)
        {
            lbPlayAgain.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lbBackToMainMenu_MouseEnter(object sender, EventArgs e)
        {
            lbBackToMainMenu.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lbBackToMainMenu_MouseLeave(object sender, EventArgs e)
        {
            lbBackToMainMenu.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lbBackToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            Scene.Dispose();
            this.Dispose();
        }
    }
}
