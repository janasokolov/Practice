using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers
{
    internal class FileLogger : ILogger
    {
        private readonly string _logFilePath;
        private readonly object _lock = new object();

        public FileLogger(string logFilePath)
        {
            _logFilePath = logFilePath;
        }
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            var logMessage = $"{DateTime.Now:s} [{logLevel}] {eventId.Id} {formatter(state, exception)}\n";
            try
            {
                System.IO.File.AppendAllText(_logFilePath, logMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }
    }
}
