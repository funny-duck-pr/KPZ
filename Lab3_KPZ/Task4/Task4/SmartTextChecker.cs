using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4;

public class SmartTextChecker : SmartTextReader
{
    private readonly SmartTextReader _reader;

    public SmartTextChecker(SmartTextReader reader)
    {
        _reader = reader;
    }

    public override char[][] ReadFile(string path)
    {
        Console.WriteLine($"Opening file: {path}");
        var content = _reader.ReadFile(path);
        Console.WriteLine($"Successfully read {content.Length} lines");

        int charCount = content.Sum(line => line.Length);
        Console.WriteLine($"Total characters: {charCount}");
        Console.WriteLine("Closing file...");

        return content;
    }
}