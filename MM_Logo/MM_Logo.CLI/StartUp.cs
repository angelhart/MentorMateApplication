using MM_Logo.CORE;
using MM_Logo.CORE.Contracts;
using MM_Logo.CORE.Readers;
using MM_Logo.CORE.Writers;
using System;

namespace MM_Logo.CLI
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            ICommandParser parser = new CommandParser();
            IEngine engine = new Engine(reader, writer, parser);
            engine.Run();
        }
    }
}
