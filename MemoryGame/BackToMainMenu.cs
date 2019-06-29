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
    public partial class BackToMainMenu : Form
    {
        public Form1 MainMenu { set; get; }
        public Scene Scene { set; get; }
        public BackToMainMenu(Scene scene, Form1 mainMenu)
        {
            InitializeComponent();
            MainMenu = mainMenu;
            Scene = scene;
        }

        private void lbYes_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            Scene.Dispose();
            this.Dispose();
        }

        private void lbNo_Click(object sender, EventArgs e)
        {
            if(Scene is SingleplayerScene singleplayerScene)
            {
                singleplayerScene.StartTimer();
            }
            this.Dispose();
        }

        private void lbYes_MouseEnter(object sender, EventArgs e)
        {
            lbYes.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lbYes_MouseLeave(object sender, EventArgs e)
        {
            lbYes.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lbNo_MouseEnter(object sender, EventArgs e)
        {
            lbNo.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lbNo_MouseLeave(object sender, EventArgs e)
        {
            lbYes.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }
    }
}
