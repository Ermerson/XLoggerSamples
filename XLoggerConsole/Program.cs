using System;
using XLogger.Adapters.Console;

namespace XLoggerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var logger = new ConsoleLogger();
            logger.Information("Mensagem de LOG");
        }
    }
}
