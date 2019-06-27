using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class DataWriter
    {
        public void WriteToFile()
        {
            WriteData(@"C:\Users\Bojan\source\repos\VP PROEKTNA ZADACHA\MemoryGame\MemoryGame\scores\best4x4.txt", BestScoresData.Best4x4);
            WriteData(@"C:\Users\Bojan\source\repos\VP PROEKTNA ZADACHA\MemoryGame\MemoryGame\scores\best4x5.txt", BestScoresData.Best4x5);
            WriteData(@"C:\Users\Bojan\source\repos\VP PROEKTNA ZADACHA\MemoryGame\MemoryGame\scores\best4x6.txt", BestScoresData.Best4x6);
        }
        public void WriteData(string path, SortedSet<Score> scores)
        {
            File.WriteAllText(path, string.Empty);
            string[] data = ConvertData(scores);
            File.WriteAllLines(path, data, Encoding.ASCII);
        }
        public string[] ConvertData(SortedSet<Score> scores)
        {
            string[] data = new string[scores.Count];
            for (int i = 0; i < scores.Count; i++)
                data[i] = scores.ElementAt(i).ToString();
            return data;
        }
    }
}
