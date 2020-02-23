using MM_Logo.CORE.Contracts;
using System;

namespace MM_Logo.CORE
{
    public class Engine : IEngine
    {
        private readonly IWriter writer;
        private readonly IReader reader;
        private readonly ICommandParser parser;

        public Engine(IReader reader, IWriter writer, ICommandParser parser)
        {
            this.reader = reader;
            this.writer = writer;
            this.parser = parser;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    // REPL
                    string input = this.reader.Read();

                    if (input == "end")
                        break;

                    var command = this.parser.ParseCommand(input);
                    string result = command.Execute();
                    this.writer.Write(result);
                }
                catch (Exception ex)
                {
                    this.writer.Write(ex.Message);
                }
            }
        }
    }
}
