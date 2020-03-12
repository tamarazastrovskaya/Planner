using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;


namespace Planner.Services
{
    static class LogFactory<T>
    {
        public static Logger<T> CreateLog(IServiceProvider serviceProvider) =>
            (Logger<T>)LoggerFactory.Create(builder =>
            {
                builder
                   
                   
                    .AddProvider(new FileLoggerProvider("log.log"));
            }
            ).CreateLogger<T>();
    }
}
