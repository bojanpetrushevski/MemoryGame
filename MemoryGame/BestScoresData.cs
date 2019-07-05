using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MemoryGame
{
    /// <summary>
    /// Represents class for storing data for scores.
    /// </summary>
    public class BestScoresData
    {
        public static SortedSet<Score> Best4x4 { set; get; }
        public static SortedSet<Score> Best4x5 { set; get; }
        public static SortedSet<Score> Best4x6 { set; get; }
        public BestScoresData()
        {
            Best4x4 = new SortedSet<Score>();
            Best4x5 = new SortedSet<Score>();
            Best4x6 = new SortedSet<Score>();
        }
    }
}
