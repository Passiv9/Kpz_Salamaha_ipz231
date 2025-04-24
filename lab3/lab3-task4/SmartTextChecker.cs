using System;

namespace ProxyPattern
{
    public class SmartTextChecker
    {
        private SmartTextReader _smartTextReader;

        public SmartTextChecker(SmartTextReader smartTextReader)
        {
            _smartTextReader = smartTextReader;
        }

        public char[,] ReadFile()
        {
            Console.WriteLine("Opening file...");

            var result = _smartTextReader.ReadFile();

            int lineCount = result.GetLength(0);
            int charCount = result.GetLength(1) * lineCount;

            Console.WriteLine($"File read successfully.");
            Console.WriteLine($"Total lines: {lineCount}, Total characters: {charCount}");

            return result;
        }
    }
}
