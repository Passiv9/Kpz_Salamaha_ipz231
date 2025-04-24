using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ProxyPattern
{
    public class SmartTextReaderLocker
    {
        private SmartTextReader _smartTextReader;
        private Regex _filePattern;

        public SmartTextReaderLocker(SmartTextReader smartTextReader, string filePattern)
        {
            _smartTextReader = smartTextReader;
            _filePattern = new Regex(filePattern);
        }

        public char[,] ReadFile()
        {
            if (_filePattern.IsMatch(_smartTextReader.FilePath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }

            return _smartTextReader.ReadFile();
        }
    }
}
