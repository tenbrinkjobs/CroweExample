using System;
using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
using Contract;
using System.Collections.Generic;

namespace DisplayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("AutofacConfig.json")
                .Build();
            var module = new ConfigurationModule(config);
            var builder = new ContainerBuilder();
            builder.RegisterModule(module);
           var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var logger = scope.Resolve<ILogger>();
                var dataDisplay = scope.Resolve<IDisplayService>();

                logger.Log(new KeyValuePair<string, string>("Message","Example Project Opened"));

                dataDisplay.DisplayString();
                            //Hold Open for confirmation
                Console.Read();

                logger.Log(new KeyValuePair<string, string>("Message","Example Project Exiting"));
            }
        }
    }
}
