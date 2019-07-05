using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    /// <summary>
    /// Class that contains one method used for validating score.
    /// </summary>
    public class ScoreValidation
    {
        /// <summary>
        /// Class used for checking if score is good enough to be in the best 5 scores. 
        /// If there are less than 5 scores, the score is automatically
        /// among best 5 scores for that category.
        /// </summary>
        /// <param name="scores">The SortedSet of scores to be compared with latest finishedTime.</param>
        /// <param name="finishedTime">The time user finished the game.</param>
        /// <returns></returns>
        public static bool ValidateScore(SortedSet<Score> scores, int finishedTime)
        {
            for(int i = 0; i < scores.Count; i++)
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
