using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Unidade.Configuration
{
    public class ListLogger : ILogger
    {
        public readonly IList<string> Logs;

        public IDisposable BeginScope<TState>(TState state) => NullScope.Instance;

        public bool IsEnabled(LogLevel logLevel) => false;

        public ListLogger() => Logs = new List<string>();

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state,
            Exception exception, Func<TState, Exception, string> formatter) =>
            Logs.Add(formatter(state, exception));
    }

    public class NullScope : IDisposable
    {
        public static NullScope Instance { get; } = new NullScope();

        private NullScope() { }

        public void Dispose() { }
    }
}
