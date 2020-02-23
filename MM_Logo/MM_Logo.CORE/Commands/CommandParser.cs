using MM_Logo.CORE.Commands;
using MM_Logo.CORE.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM_Logo.CORE
{
    public class CommandParser : ICommandParser
    {
        public ICommand ParseCommand(string commandLine)
        {
            var lineParameters = commandLine
                .Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (int.TryParse(lineParameters[0], out int size))
                return new DisplayLogoCommand(lineParameters);
            else
                throw new ArgumentException("N must be number");
        }
    }
}
