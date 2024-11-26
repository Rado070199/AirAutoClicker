using Serilog.Events;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AirAutoClicker.Helpers
{

    /// <summary>
    /// Provides methods for logging messages with Serilog.
    /// </summary>
    public static class LogsHelper
    {
        #region Fields
        private static ILogger _logger;
        private static LogEventLevel _logEventLevel;
        private static RollingInterval _rollingInterval;
        private static string _saveLogsPath;
        private static bool _isSaveLogsPathSet = false;
        #endregion

        #region Controler

        /// <summary>
        /// Initializes the LogsHelper class.
        /// </summary>
        /// <remarks>
        /// This constructor configures the Serilog logger for logging. It sets the minimum logging level based on the _logEventLevel field,
        /// the rolling interval based on the _rollingInterval field, and the log file path using the GetLogFilePath method. The logger is then created
        /// and assigned to the _logger field.
        /// </remarks>
        static LogsHelper()
        {
            try
            {
                LoggerConfiguration loggerConfiguration = new LoggerConfiguration();

                LogEventLevel minimumLevel = _logEventLevel != null ? _logEventLevel : LogEventLevel.Information;

                loggerConfiguration.MinimumLevel.Is(minimumLevel);

                RollingInterval rollingInterval = _rollingInterval != null ? _rollingInterval : RollingInterval.Day;

                loggerConfiguration.WriteTo.File(GetLogFilePath(), rollingInterval: rollingInterval, shared: true, flushToDiskInterval: TimeSpan.FromSeconds(1));

                _logger = loggerConfiguration.Enrich.FromLogContext().CreateLogger();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Fields

        /// <summary>
        /// Gets or sets the path to the logs.
        /// </summary>
        public static string SaveLogsPath
        {
            get { return _saveLogsPath; }
            set
            {
                if (!_isSaveLogsPathSet)
                {
                    _saveLogsPath = value;
                    _isSaveLogsPathSet = true;
                }
                else
                {
                    throw new InvalidOperationException("SaveLogsPath can only be set once.");
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves the file path for logging.
        /// </summary>
        private static string GetLogFilePath()
        {
            try
            {
                string path = string.Empty;

                if (!string.IsNullOrEmpty(_saveLogsPath))
                {
                    path = SaveLogsPath;
                }
                else
                {
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
                }

                return Path.Combine(path, $"Log_{DateTime.Now.Date:yyyy-MM-dd}.txt");

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Log saves information about project/class/method/code line and message 
        /// </summary>
        /// <param name="stackFrame"></param>
        /// <param name="message"></param>
        public static void LogDebug(string message, [CallerMemberName] string callerMethodName = "", [CallerLineNumber] int callerLine = 0, [CallerFilePath] string callerPath = "")
        {
            try
            {
                _logger.Debug($"class: {Path.GetFileNameWithoutExtension(callerPath)} method: {callerMethodName} line: {callerLine} debug: {message}");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Log saves information about project/class/method/code line and message 
        /// </summary>
        /// <param name="stackFrame"></param>
        /// <param name="message"></param>
        public static void LogInformation(string message, [CallerMemberName] string callerMethodName = "", [CallerLineNumber] int callerLine = 0, [CallerFilePath] string callerPath = "")
        {
            try
            {
                _logger.Information($"class: {Path.GetFileNameWithoutExtension(callerPath)} method: {callerMethodName} line: {callerLine} information: {message}");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Log saves information about project/class/method/code line and message 
        /// </summary>
        /// <param name="stackFrame"></param>
        public static void LogError(Exception ex, [CallerMemberName] string callerMethodName = "", [CallerLineNumber] int callerLine = 0, [CallerFilePath] string callerPath = "")
        {
            try
            {
                _logger.Error($"class: {Path.GetFileNameWithoutExtension(callerPath)} method: {callerMethodName} line: {callerLine} error: {ex.Message}");
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
