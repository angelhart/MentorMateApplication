using MM_Logo.CORE.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MM_Logo.CORE.Writers
{
    public class FileWriter : IWriter
    {
        private readonly string pathToFile;

        public FileWriter(string pathToFile)
        {
            this.pathToFile = pathToFile;
        }
        public void Write(string text)
        {
            File.WriteAllText(this.pathToFile, text);
        }

        public void Write(string[] lines)
        {
            File.WriteAllLines(this.pathToFile, lines);
        }
    }
}
