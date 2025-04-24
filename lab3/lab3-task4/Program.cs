using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var smartTextReader = new SmartTextReader("test.txt");

            var smartTextChecker = new SmartTextChecker(smartTextReader);
            var content = smartTextChecker.ReadFile();

          
            var smartTextReaderLocker = new SmartTextReaderLocker(smartTextReader, @"restricted.*\.txt");
            var restrictedContent = smartTextReaderLocker.ReadFile(); 
        }
    }
}
