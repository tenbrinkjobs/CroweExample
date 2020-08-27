using System;
using System.Collections.Generic;

namespace Contract
{
    public interface ILogger
    {
        bool Log(params KeyValuePair<string, string>[] properties);
    }
}
