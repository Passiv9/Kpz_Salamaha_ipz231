using System;
using System.IO;

namespace LabLogger
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[LOG]: {message}");
            Console.ResetColor();
        }

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERROR]: {message}");
            Console.ResetColor();
        }

        public void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[WARN]: {message}");
            Console.ResetColor();
        }
    }

    public class FileWriter
    {
        private string filePath;

        public FileWriter(string path)
        {
            filePath = path;
        }

        public void Write(string text)
        {
            File.AppendAllText(filePath, text);
        }

        public void WriteLine(string text)
        {
            File.AppendAllText(filePath, text + Environment.NewLine);
        }
    }

    public interface ILogger
    {
        void Log(string message);
        void Error(string message);
        void Warn(string message);
    }

    public class FileLoggerAdapter : ILogger
    {
        private FileWriter writer;

        public FileLoggerAdapter(FileWriter fileWriter)
        {
            writer = fileWriter;
        }

        public void Log(string message)
        {
            writer.WriteLine("[LOG]: " + message);
        }

        public void Error(string message)
        {
            writer.WriteLine("[ERROR]: " + message);
        }

        public void Warn(string message)
        {
            writer.WriteLine("[WARN]: " + message);
        }
    }
}
