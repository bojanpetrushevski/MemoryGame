using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    /// <summary>
    /// Class used for reading data from files.
    /// </summary>
    public class DataReader
    {
        public void ReadFromFile()
        {
            DataReader dataReader = new DataReader();
            dataReader.ReadData(@"..\..\scores\best4x4.txt", BestScoresData.Best4x4);
            dataReader.ReadData(@"..\..\scores\best4x5.txt", BestScoresData.Best4x5);
            dataReader.ReadData(@"..\..\scores\best4x6.txt", BestScoresData.Best4x6);
        }
        /// <summary>
        /// Reads the scores from the file path. In the file are written all the scores.
        /// </summary>
        /// <param name="path">The file relative path.</param>
        /// <param name="scores">The SortedSet where the data will be stored.</param>
        /// <returns></returns>
        public SortedSet<Score> ReadData(string path, SortedSet<Score> scores)
        {
            scores.Clear();
            foreach (string line in File.ReadAllLines(path))
            {
                if (line.Length == 0)
                    continue;
                string[] parts = line.Split(' ');
                string name = parts[0];
                string date = parts[1];
                string time = parts[2];
                Player player = new Player(name, 0, 0);
                DateTime dateTime = ParseDate(date);
                int finishedTime = ParseFinishedTime(time);
                scores.Add(new Score(player, finishedTime, dateTime)).ToString();
            }
            return scores;
        }
        public DateTime ParseDate(string date)
        {
            string[] parts = date.Split('-');
            string[] dateInfo = parts[0].Split('/');
            string[] clockInfo = parts[1].Split(':');
            int day = int.Parse(dateInfo[0]);
            int month = int.Parse(dateInfo[1]);
            int year = int.Parse(dateInfo[2]);
            int hour = int.Parse(clockInfo[0]);
            int minute = int.Parse(clockInfo[1]);
            int second = int.Parse(clockInfo[2]);
            int milisecond = 500;
            return new DateTime(year, month, day, hour, minute, second, milisecond);
        }
        public int ParseFinishedTime(string finishedTime)
        {
            string[] parts = finishedTime.Split(':');
            int minutes = int.Parse(parts[0]);
            int seconds = int.Parse(parts[1]);
            return minutes * 60 + seconds;
        }
    }
}
