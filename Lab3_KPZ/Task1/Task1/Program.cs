using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

class Program
{
    static void Main()
    {
        Logger consoleLogger = new Logger();
        consoleLogger.Log("This is a log message.");
        consoleLogger.Error("This is an error message.");
        consoleLogger.Warn("This is a warning message.");

        string filePath = "log.txt";
        FileWriter fileWriter = new FileWriter(filePath);
        FileLoggerAdapter fileLogger = new FileLoggerAdapter(fileWriter);

        fileLogger.Log("This is a log message in the file.");
        fileLogger.Error("This is an error message in the file.");
        fileLogger.Warn("This is a warning message in the file.");

        Console.WriteLine("Log messages written to file.");
    }
}