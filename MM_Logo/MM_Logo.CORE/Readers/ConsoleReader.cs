using MM_Logo.CORE.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MM_Logo.CORE.Readers
{
    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
