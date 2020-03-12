using Microsoft.Extensions.Logging;

namespace Planner.Services
{
    internal class FileLoggerProvider : ILoggerProvider
    {
        private string v;

        public FileLoggerProvider(string v)
        {
            this.v = v;
        }

        public ILogger CreateLogger(string categoryName)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}