using Autofac;
using Contract;
using System;
namespace DisplayConsole
{
    public class ConsoleDisplayService: IDisplayService
    {
        private IDataSource _source;
        private ILogger _logger;
        public ConsoleDisplayService(IDataSource source, ILogger logger)
        {
            _source = source;
            _logger = logger;
        }
        public bool DisplayString(){
            Console.WriteLine(_source.GetDisplayString());
            return true;
        }
    }
}