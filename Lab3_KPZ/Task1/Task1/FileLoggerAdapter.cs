using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FileLoggerAdapter : Logger
    {
        private readonly FileWriter fileWriter;

        public FileLoggerAdapter(FileWriter fileWriter)
        {
            this.fileWriter = fileWriter;
        }

        public override void Log(string message)
        {
            fileWriter.WriteLine($"[LOG] {message}");
        }

        public override void Error(string message)
        {
            fileWriter.WriteLine($"[ERROR] {message}");
        }

        public override void Warn(string message)
        {
            fileWriter.WriteLine($"[WARN] {message}");
        }
    }
}