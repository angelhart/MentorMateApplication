using MM_Logo.CORE.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MM_Logo.CORE.Readers
{
    public class FileReader : IReader
    {
        private readonly string path;

        public FileReader(string path)
        {
            this.path = path;
        }
        public string Read()
        {
            var sb = new StringBuilder();
            foreach (var item in File.ReadAllLines(this.path))
            {
                sb.AppendLine(item);
            }
            return sb.ToString();
        }
    }
}
