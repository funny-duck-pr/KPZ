using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task4;

public class SmartTextReaderLocker : SmartTextReader
{
    private readonly SmartTextReader _reader;
    private readonly Regex _restriction;

    public SmartTextReaderLocker(SmartTextReader reader, string restrictionPattern)
    {
        _reader = reader;
        _restriction = new Regex(restrictionPattern);
    }

    public override char[][] ReadFile(string path)
    {
        if (_restriction.IsMatch(path))
        {
            Console.WriteLine("Access denied!");
            return Array.Empty<char[]>();
        }

        return _reader.ReadFile(path);
    }
}