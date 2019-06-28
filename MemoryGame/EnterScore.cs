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
    public partial class EnterScore : Form
    {
        public SortedSet<Score> Scores { set; get; }
        public int FinishedTime { set; get; }
        public EnterScore(SortedSet<Score> scores, int finishedTime)
        {
            InitializeComponent();
            Scores = scores;
            FinishedTime = finishedTime;
            SetTime();
        }
        public void SetTime()
        {
            tbTime.Text = TimeFormat();
        }
        public string TimeFormat()
        {
            return String.Format("{0:00}:{1:00}", InMinutes(), InSeconds());
        }
        public int InMinutes()
        {
            return FinishedTime / 60;
        }
        public int InSeconds()
        {
            return FinishedTime % 60;
        }
        private void lbOK_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            int time = ParseTime(tbTime.Text);
            Score s = new Score(new Player(name, 0, 0), time);
            AddScore(s);
            this.Close();
        }
        public void AddScore(Score s)
        {
            Scores.Add(s);
        }
        public int ParseTime(string time)
        {
            string[] parts = time.Split(':');
            int minutes = int.Parse(parts[0]);
            int seconds = int.Parse(parts[1]);
            return minutes * 60 + seconds;
        }

        private void lbOK_MouseEnter(object sender, EventArgs e)
        {
            lbOK.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lbOK_MouseLeave(object sender, EventArgs e)
        {
            lbOK.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }
    }
}
