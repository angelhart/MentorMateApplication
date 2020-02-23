using MM_Logo.CORE.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MM_Logo.CORE.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
