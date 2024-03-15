﻿using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuti.Windows.Utilities
{
    public static class LoggerExtensions
    {
        public static void Verbose(this ILogger logger, Action<ILogger> logAction) =>
            Log(logger, LogEventLevel.Verbose, logAction);

        public static void Debug(this ILogger logger, Action<ILogger> logAction) => 
            Log(logger, LogEventLevel.Debug, logAction);

        private static void Log(ILogger logger, LogEventLevel level, Action<ILogger> logAction)
        {
            if (logger.IsEnabled(level))
            {
                logAction(logger);
            }
        }
    }
}
