using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    /// <summary>
    /// Class used for tracking score when user plays singleplayer mode.
    /// </summary>
    public class Score : IComparable<Score>
    {
        public Player Player { set; get; }
        public int FinishedTime { set; get; }
        public DateTime Date { set; get; }
        public Score(Player player, int finishedTime)
        {
            Player = player;
            FinishedTime = finishedTime;
            Date = DateTime.Now;
        }
        public Score(Player player, int finishedTime, DateTime date)
        {
            Player = player;
            FinishedTime = finishedTime;
            Date = date;
        }
        public int CompareTo(Score s)
        {
            if (FinishedTime < s.FinishedTime)
                return -1;
            else
                return 1;
        }
        public new string ToString()
        {
            return String.Format("{0},{1},{2}", Player.Name, DateFormat(), FinishedTimeFormat());
        }
        public int InMinutes()
        {
            return FinishedTime / 60;
        }
        public int InSeconds()
        {
            return FinishedTime % 60;
        }
        public string FinishedTimeFormat()
        {
            return String.Format("{0:00}:{1:00}", InMinutes(), InSeconds());
        }
        public string ClockFormat()
        {
            string timeOfDay = Date.TimeOfDay.ToString();
            int index = timeOfDay.IndexOf('.');
            return timeOfDay.Substring(0, index);
        }
        public string DateFormat()
        {
            return String.Format("{0:00}/{1:00}/{2}-{3}", Date.Day, Date.Month, Date.Year, ClockFormat());
        }
    }
}
