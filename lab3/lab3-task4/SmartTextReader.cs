using System;
using System.IO;

namespace ProxyPattern
{
    public class SmartTextReader
    {
        public string FilePath { get; private set; }

        public SmartTextReader(string filePath)
        {
            FilePath = filePath;
        }

        public char[,] ReadFile()
        {
            string[] lines = File.ReadAllLines(FilePath);
            char[,] result = new char[lines.Length, lines[0].Length];

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    result[i, j] = lines[i][j];
                }
            }

            return result;
        }
    }
}
