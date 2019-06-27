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
        private static BestScores BestScoresInstance = new BestScores();
        private BestScores()
        {
            InitializeComponent();
        }
        public static void ShowBestScores()
        {
            BestScoresInstance.ShowDialog();
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


        private void pbBackArrow_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ChooseGameCategory chooseGameCategory = new ChooseGameCategory();
            chooseGameCategory.ShowDialog();
        }
    }
}
