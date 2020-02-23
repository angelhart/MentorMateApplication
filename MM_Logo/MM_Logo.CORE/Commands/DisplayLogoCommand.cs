using MM_Logo.CORE.Contracts;
using MM_Logo.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM_Logo.CORE.Commands
{
    internal class DisplayLogoCommand : Command, ICommand
    {
        public DisplayLogoCommand(IEnumerable<string> parameters) : base(parameters)
        {
        }

        public override string Execute()
        {
            Logo.Instance.Size = int.Parse(this.CommandParameters[0]);
            if (this.CommandParameters.Count == 1)
            {
                return Logo.Instance.ToString();
            }
            else
            {
                var repetitions = int.Parse(this.CommandParameters.Skip(1).First());
                return Logo.Instance.ToString(repetitions);
            }
        }
    }
}
