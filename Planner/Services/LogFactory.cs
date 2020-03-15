using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Planner.Services.Logging.Provider;

namespace Planner.Services
{
    static class LogFactory<T> // фабрика
    {
        public static Logger<T> CreateLog(IServiceProvider serviceProvider) =>
            (Logger<T>)LoggerFactory.Create(builder =>
            {// функция, которая производит настройку логера
                builder //объект, который отвечает за создание логера
                   
                   
                    .AddProvider(new FileLoggerProvider("log.log")); // провайдер (инструмент для
                // записи logа в конкретное место) до текстового файла
                // например Elasticsearch - база данных, собирает логи
            }
            ).CreateLogger<T>();
    }
}
