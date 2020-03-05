using System;
using Microsoft.Extensions.Configuration;

namespace SimpleCRM
{
    public class ConfigurationGreeter : IGreeter
    {
        public IConfiguration Configuration { get; }

        public ConfigurationGreeter(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string GetGreeting()
        {
            return Configuration["Greeting"];
        }
    }
}
