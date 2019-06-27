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
    public partial class Options : Form
    {
        public Form1 MainMenu { set; get; }
        public static int AvailibleColors = 2;
        public static string ButtonText { set; get; }
        public static string DropDownSelectedItem { set; get; }
        public Options(Form1 mainMenu)
        {
            InitializeComponent();
            MainMenu = mainMenu;
            CreateDropDownList();
            SetDefaultValues();
        }
        public void SetDefaultValues()
        {
            ButtonText = btnOnOff.Text;
            DropDownSelectedItem = comboBox1.Text;
        }
        public void CreateDropDownList()
        {
            List<string> DropDownList = new List<string>();
            DropDownList.Add("White");
            DropDownList.Add("Blue");
            comboBox1.DataSource = DropDownList;
        }
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            ChangeButtonText();
        }
        public void ChangeButtonText()
        {
            if (btnOnOff.Text == "ON")
                btnOnOff.Text = "OFF";
            else
                btnOnOff.Text = "ON";
            ButtonText = btnOnOff.Text;
        }
        private void pbBackArrow_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownSelectedItem = comboBox1.Text;
        }
        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }
        public void CloseForm()
        {
            this.Close();
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
