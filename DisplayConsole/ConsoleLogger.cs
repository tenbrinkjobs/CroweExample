using Contract;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DisplayConsole
{
    public class ConsoleLogger: ILogger
    {
        public bool Log(params KeyValuePair<string, string>[] properties){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( string.Join(';', properties.Select(kv => kv.ToString())));
            Console.ResetColor();
            return true;
        }
    }
}