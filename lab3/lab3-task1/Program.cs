using System;
using LabLogger;

class Program
{
    static void Main(string[] args)
    {
        Logger consoleLogger = new Logger();
        consoleLogger.Log("Це інформаційне повідомлення");
        consoleLogger.Error("Це повідомлення про помилку");
        consoleLogger.Warn("Це попередження");

        FileWriter writer = new FileWriter("log.txt");
        ILogger fileLogger = new FileLoggerAdapter(writer);

        fileLogger.Log("Це лог в файл");
        fileLogger.Error("Це помилка в файл");
        fileLogger.Warn("Це попередження в файл");

        Console.WriteLine("Логування завершено.");
    }
}
