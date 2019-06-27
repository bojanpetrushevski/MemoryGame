using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MemoryGame
{
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
            ReadData(@"C:\Users\Bojan\source\repos\VP PROEKTNA ZADACHA\MemoryGame\MemoryGame\scores\best4x4.txt", Best4x4);
            ReadData(@"C:\Users\Bojan\source\repos\VP PROEKTNA ZADACHA\MemoryGame\MemoryGame\scores\best4x5.txt", Best4x5);
            ReadData(@"C:\Users\Bojan\source\repos\VP PROEKTNA ZADACHA\MemoryGame\MemoryGame\scores\best4x6.txt", Best4x6);
        }
        public void ReadData(string path, SortedSet<Score> scores)
        {
            scores.Clear();
            foreach(string line in File.ReadAllLines(path))
            {
                string[] parts = line.Split(' ');
                string name = parts[0];
                string date = parts[1];
                string time = parts[2];
                Player player = new Player(name);
                DateTime dateTime = ParseDate(date);
                int finishedTime = ParseFinishedTime(time);
                scores.Add(new Score(player, finishedTime, dateTime));
            }
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
            return new DateTime(year, month, day, hour, minute, second);
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
