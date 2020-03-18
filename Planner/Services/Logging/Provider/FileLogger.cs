using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace Planner.Services.Logging.Provider
{
    internal class FileLogger : ILogger //  класс отвечает за запись файла
    {
        private string filepath;
        private static object _loc = new object();// объект для блокирования файла, 
        

        //чтобы запись была последовательная

        public FileLogger(string path) // конструктор, через который  получаем путь
        {
            filepath = path;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)// метод говорит о возможности или нет 
                                                //записать лог в данный момент
        {
            return true;
        }

        public void Log<TState>( // метод принимает: уровень ошибки, id события, состояние и форматер
            LogLevel logLevel, 
            EventId eventId,
            TState state,
            Exception exception, 
            Func<TState,Exception,string> formatte 
            )
        {
           if(formatte != null)
            {
                lock (_loc)
                {
                    File.AppendAllText(
                        filepath, formatte(state, exception) + Environment.NewLine 
                        // обезопасили файл от одновременной параллельной записи
                        );
                }
            }
        }
    }
}