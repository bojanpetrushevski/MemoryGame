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
    public partial class About : Form
    {
        public Form1 MainMenu { set; get; }
        public About(Form1 mainMenu)
        {
            InitializeComponent();
            MainMenu = mainMenu;
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
