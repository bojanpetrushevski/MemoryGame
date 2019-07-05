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
    public partial class ChooseGameCategory : Form
    {
        public Form1 MainMenu { set; get; }
        public ChooseGameCategory(Form1 mainMenu)
        {
            InitializeComponent();
            MainMenu = mainMenu;
        }
        private void lb4x4_MouseEnter(object sender, EventArgs e)
        {
            lb4x4.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lb4x4_MouseLeave(object sender, EventArgs e)
        {
            lb4x4.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lb4x5_MouseEnter(object sender, EventArgs e)
        {
            lb4x5.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lb4x5_MouseLeave(object sender, EventArgs e)
        {
            lb4x5.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lb4x6_MouseEnter(object sender, EventArgs e)
        {
            lb4x6.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lb4x6_MouseLeave(object sender, EventArgs e)
        {
            lb4x6.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lb4x4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestScores.CreateBestScores(MainMenu, "4 x 4");
            BestScores.ShowData(BestScoresData.Best4x4);
            BestScores.ShowBestScores();
        }

        private void lb4x5_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestScores.CreateBestScores(MainMenu, "4 x 5");
            BestScores.ShowData(BestScoresData.Best4x5);
            BestScores.ShowBestScores();
        }

        private void lb4x6_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestScores.CreateBestScores(MainMenu, "4 x 6");
            BestScores.ShowData(BestScoresData.Best4x6);
            BestScores.ShowBestScores();
        }

        private void pbBackArrow_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MainMenu.Show();
        }

        private void pbBackArrow_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbBackArrow_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
