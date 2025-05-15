using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4;

public class SmartTextReader
{
    public virtual char[][] ReadFile(string path)
    {
        var lines = File.ReadAllLines(path);
        return lines.Select(line => line.ToCharArray()).ToArray();
    }
}