using MM_Logo.CORE.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MM_Logo.CORE.Commands
{
    abstract class Command : ICommand
    {
        public Command(IEnumerable<string> parameters)
        {
            this.CommandParameters = new List<string>(parameters);
        }

        protected IList<string> CommandParameters { get; }

        public abstract string Execute();
    }
}
