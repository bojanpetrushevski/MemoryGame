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
    public partial class Exit : Form
    {
        public Form Caller { set; get; }
        public Exit(Form caller)
        {
            InitializeComponent();
            Caller = caller;
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
            lbNo.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lbYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            Application.Exit();
        }

        private void lbNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tesdsdt");
            Caller.Show();
            this.Dispose();
        }
    }
}
