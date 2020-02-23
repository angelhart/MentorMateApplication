using System;
using System.Collections.Generic;
using System.Text;

namespace MM_Logo.CORE.Contracts
{
    public interface ICommandParser
    {
        ICommand ParseCommand(string commandLine);
    }
}
