using Contract;
using System.Collections.Generic;
namespace DataSource.Test
{
    public class TestLogger: ILogger{
        public bool Log(params KeyValuePair<string, string>[] properties)
        {
            return true;
        }
    }
}