using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4;

class Program
{
    static void Main()
    {
        var baseReader = new SmartTextReader();
        
        var checker = new SmartTextChecker(baseReader);
        var locker = new SmartTextReaderLocker(checker, ".*test\\.txt$");

        Console.WriteLine("Reading allowed file:");
        locker.ReadFile("D:\\KPZ\\Lab3_KPZ\\Task4\\Task4\\test.txt");

        Console.WriteLine("\nReading restricted file:");
        locker.ReadFile("secret_document.txt");
    }
}