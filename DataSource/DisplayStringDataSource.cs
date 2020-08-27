
using System;
using Contract;

namespace DataSource
{
    public class DisplayStringDataSource: IDataSource
    {
        private readonly ILogger _logger;
        public DisplayStringDataSource(ILogger logger){
            _logger = logger;
        }

       public string GetDisplayString(){
            return "Hello World";
       }
    }
}
