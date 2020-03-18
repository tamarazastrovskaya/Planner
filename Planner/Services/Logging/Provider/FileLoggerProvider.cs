using Microsoft.Extensions.Logging;

namespace Planner.Services.Logging.Provider
{
    internal class FileLoggerProvider : ILoggerProvider
        // путь, куда будут записываться логи
    {
        private string path;
        // свойство для хранения пути
        public FileLoggerProvider(string _path)// конструктор для создания провайдера с заданными настройками
        {
            this.path = _path;
        }

        public ILogger CreateLogger(string categoryName) // создаёт  соединение
        {
            return new FileLogger(path);// возвращает класс, который отвечает за запись логов туда
        }

        public void Dispose()// удаляет соединение
        {
           
        }
    }
}