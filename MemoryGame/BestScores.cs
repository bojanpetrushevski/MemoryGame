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
    public partial class BestScores : Form
    {
        private static BestScores BestScoresInstance { set; get; }
        public Form1 MainForm { set; get; } 
        private BestScores(Form1 mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }
        public static void CreateBestScores(Form1 mainForm)
        {
            BestScoresInstance = new BestScores(mainForm);
        }
        public static void ShowBestScores()
        {
            BestScoresInstance.Show();          
        }
        public static void ShowData(SortedSet<Score> scores)
        {
            Control[] controls = null;
            Label lb = null;
            int length = ((scores.Count < 5) ? scores.Count :  5);
            for(int i = 0; i < length; i++)
            {
                controls = BestScoresInstance.Controls.Find("lbName" + (i + 1), false);
                lb = (Label)controls[0];
                lb.Text = scores.ElementAt(i).Player.Name;
                controls = BestScoresInstance.Controls.Find("lbDate" + (i + 1), false);
                lb = (Label)controls[0];
                lb.Text = scores.ElementAt(i).DateFormat();
                controls = BestScoresInstance.Controls.Find("lbTime" + (i + 1), false);
                lb = (Label)controls[0];
                lb.Text = scores.ElementAt(i).FinishedTimeFormat();
            }
        }

        public void ClearData()
        {
            Control[] controls = null;
            Label lb = null;
            for (int i = 0; i < 5; i++)
            {
                controls = BestScoresInstance.Controls.Find("lbName" + (i + 1), false);
                lb = (Label)controls[0];
                lb.Text = "";
                controls = BestScoresInstance.Controls.Find("lbDate" + (i + 1), false);
                lb = (Label)controls[0];
                lb.Text = "";
                controls = BestScoresInstance.Controls.Find("lbTime" + (i + 1), false);
                lb = (Label)controls[0];
                lb.Text = "";
            }
        }
        private void pbBackArrow_Click(object sender, EventArgs e)
        {
            
            BestScoresInstance.Hide();
            ClearData();
            ChooseGameCategory chooseGameCategory = new ChooseGameCategory(MainForm);
            chooseGameCategory.ShowDialog();
        }
    }
}
