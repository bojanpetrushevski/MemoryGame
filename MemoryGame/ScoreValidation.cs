using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class ScoreValidation
    {
        public static bool ValidateScore(SortedSet<Score> scores, int finishedTime)
        {
            for(int i = 0; i  < scores.Count; i++)
            {
                if (i > 4)
                    return false;
                if (finishedTime < scores.ElementAt(i).FinishedTime)
                    return true;
            }
            return true;
        }
    }
}
