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
        public MultiplayerScene Caller { set; get; }
        public EnterNames(MultiplayerScene caller)
        {
            InitializeComponent();
            Caller = caller;
        }

        private void lbStart_Click(object sender, EventArgs e)
        {
            if(tbPlayer1Name.Text.Trim().Length == 0 || tbPlayer2Name.Text.Trim().Length == 0)
            {
                ErrorMessage errorMessage = new ErrorMessage();
                errorMessage.ShowDialog();
            }
            else
            {
                string player1Name = tbPlayer1Name.Text;
                string player2Name = tbPlayer2Name.Text;
                Caller.InitializePlayers(player1Name, player2Name);
                this.Dispose();
            }
        }
    }
}
