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
    public partial class EnterNames : Form
    {
        public MultiplayerScene Scene { set; get; }
        public EnterNames(MultiplayerScene caller)
        {
            InitializeComponent();
            Scene = caller;
        }

        private void lbStart_Click(object sender, EventArgs e)
        {
            if(CheckError())
            {
                SetError();
            }
            else
            {
                string player1Name = tbPlayer1Name.Text;
                string player2Name = tbPlayer2Name.Text;
                Scene.InitializeGame(player1Name, player2Name);
                this.Dispose();
            }
        }
        public void SetError()
        {
            if (tbPlayer1Name.Text.Trim().Length == 0)
            {
                errorProvider.SetError(tbPlayer1Name, "Enter your name");
                return;
            }
            else
            {
                errorProvider.SetError(tbPlayer1Name, "");
            }
            if (tbPlayer2Name.Text.Trim().Length == 0)
            {
                errorProvider.SetError(tbPlayer2Name, "Enter your name");
            }
            else
            {
                errorProvider.SetError(tbPlayer2Name, "");
            }
        }
        public bool CheckError()
        {
            return tbPlayer1Name.Text.Trim().Length == 0 || tbPlayer2Name.Text.Trim().Length == 0;
        }
        private void lbStart_MouseEnter(object sender, EventArgs e)
        {
            lbStart.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lbStart_MouseLeave(object sender, EventArgs e)
        {
            lbStart.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }
    }
}
