
namespace Microsoft.Extensions.Logging;

/// <summary>
/// This class contains a bootstrap logger
/// </summary>
public sealed class BootstrapLogger : ILogger
{
    // *******************************************************************
    // Fields.
    // *******************************************************************

    #region Fields

    /// <summary>
    /// This field contains the factory for this bootstrap logger.
    /// </summary>
    internal static ILoggerFactory? _loggerFactory;

    /// <summary>
    /// This field contains the singleton instance for this bootstrap logger
    /// </summary>
    internal static BootstrapLogger _instance = null!;
        
    /// <summary>
    /// This field contains the inner logger for this bootstrap logger.
    /// </summary>
    internal readonly ILogger? _innerLogger;

    #endregion

    // *******************************************************************
    // Constructors.
    // *******************************************************************

    #region Constructors

    /// <summary>
    /// This constructor creates a new instance of the <see cref="BootstrapLogger"/>
    /// class.
    /// </summary>
    [DebuggerStepThrough]
    public BootstrapLogger()
    {
        // Create the logger.
        _innerLogger = _loggerFactory?.CreateLogger<BootstrapLogger>();
    }

    #endregion

    // *******************************************************************
    // Public methods.
    // *******************************************************************

    #region Public methods

    /// <summary>
    /// This method returns the singleton instance of <see cref="BootstrapLogger"/>
    /// </summary>
    /// <returns>The singleton instance of <see cref="BootstrapLogger"/></returns>
    [DebuggerStepThrough]
    public static ILogger Instance()
    {
        // Should we create the instance?
        if (null == _instance)
        {
            // Should we create a default log level?
            if (_loggerFactory is null)
            {
                // Default to information.
                LogLevelToInformation();
            }

            // Create the instance.
            _instance = new BootstrapLogger();
        }

        // Return the instance.
        return _instance;
    }

    // *******************************************************************

    /// <summary>
    /// This method sets the minimum logger level to information. 
    /// </summary>
    /// <remarks>
    /// <para>
    /// This method must be called before the <see cref="BootstrapLogger.Instance"/>
    /// method is called, for it to have any effect.
    /// </para>
    /// </remarks>
    public static void LogLevelToInformation()
    {
        // Make sure the instance hasn't been created.
        if (_instance is null)
        {
            // Create the logger factory.
            _loggerFactory = LoggerFactory.Create(loggingBuilder =>
            {
                loggingBuilder.SetMinimumLevel(LogLevel.Information);
                loggingBuilder.AddSimpleConsole(options =>
                {
                    options.SingleLine = true;
                    options.TimestampFormat = "HH:mm:ss ";
                });
            });
        }
    }

    // *******************************************************************

    /// <summary>
    /// This method sets the minimum logger level to warning. 
    /// </summary>
    /// <remarks>
    /// <para>
    /// This method must be called before the <see cref="BootstrapLogger.Instance"/>
    /// method is called, for it to have any effect.
    /// </para>
    /// </remarks>
    public static void LogLevelToWarning()
    {
        // Make sure the instance hasn't been created.
        if (_instance is null)
        {
            // Create the logger factory.
            _loggerFactory = LoggerFactory.Create(loggingBuilder =>
            {
                loggingBuilder.SetMinimumLevel(LogLevel.Warning);
                loggingBuilder.AddSimpleConsole(options =>
                {
                    options.SingleLine = true;
                    options.TimestampFormat = "HH:mm:ss ";
                });
            });
        }
    }

    // *******************************************************************

    /// <summary>
    /// This method sets the minimum logger level to error. 
    /// </summary>
    /// <remarks>
    /// <para>
    /// This method must be called before the <see cref="BootstrapLogger.Instance"/>
    /// method is called, for it to have any effect.
    /// </para>
    /// </remarks>
    public static void LogLevelToError()
    {
        // Make sure the instance hasn't been created.
        if (_instance is null)
        {
            // Create the logger factory.
            _loggerFactory = LoggerFactory.Create(loggingBuilder =>
            {
                loggingBuilder.SetMinimumLevel(LogLevel.Error);
                loggingBuilder.AddSimpleConsole(options =>
                {
                    options.SingleLine = true;
                    options.TimestampFormat = "HH:mm:ss ";
                });
            });
        }
    }

    // *******************************************************************

    /// <summary>
    /// This method sets the minimum logger level to critical. 
    /// </summary>
    /// <remarks>
    /// <para>
    /// This method must be called before the <see cref="BootstrapLogger.Instance"/>
    /// method is called, for it to have any effect.
    /// </para>
    /// </remarks>
    public static void LogLevelToCritical()
    {
        // Make sure the instance hasn't been created.
        if (_instance is null)
        {
            // Create the logger factory.
            _loggerFactory = LoggerFactory.Create(loggingBuilder =>
            {
                loggingBuilder.SetMinimumLevel(LogLevel.Critical);
                loggingBuilder.AddSimpleConsole(options =>
                {
                    options.SingleLine = true;
                    options.TimestampFormat = "HH:mm:ss ";
                });
            });
        }
    }

    // *******************************************************************

    /// <summary>
    /// This method sets the minimum logger level to debug. 
    /// </summary>
    /// <remarks>
    /// <para>
    /// This method must be called before the <see cref="BootstrapLogger.Instance"/>
    /// method is called, for it to have any effect.
    /// </para>
    /// </remarks>
    public static void LogLevelToDebug()
    {
        // Make sure the instance hasn't been created.
        if (_instance is null)
        {
            // Create the logger factory.
            _loggerFactory = LoggerFactory.Create(loggingBuilder =>
            {
                loggingBuilder.SetMinimumLevel(LogLevel.Debug);
                loggingBuilder.AddSimpleConsole(options =>
                {
                    options.SingleLine = true;
                    options.TimestampFormat = "HH:mm:ss ";
                });
            });
        }
    }

    // *******************************************************************

    /// <summary>
    /// This method sets the minimum logger level to trace. 
    /// </summary>
    /// <remarks>
    /// <para>
    /// This method must be called before the <see cref="BootstrapLogger.Instance"/>
    /// method is called, for it to have any effect.
    /// </para>
    /// </remarks>
    public static void LogLevelToTrace()
    {
        // Make sure the instance hasn't been created.
        if (_instance is null)
        {
            // Create the logger factory.
            _loggerFactory = LoggerFactory.Create(loggingBuilder =>
            {
                loggingBuilder.SetMinimumLevel(LogLevel.Trace);
                loggingBuilder.AddSimpleConsole(options =>
                {
                    options.SingleLine = true;
                    options.TimestampFormat = "HH:mm:ss ";
                });
            });
        }
    }

    #endregion

    // *******************************************************************
    // Private methods.
    // *******************************************************************

    #region Private methods

    /// <summary>
    /// This method begins a logical operation scope.
    /// </summary>
    /// <typeparam name="TState">The type of the state to begin scope for.</typeparam>
    /// <param name="state">The identifier for the scope.</param>
    /// <returns>An <see cref="System.IDisposable"/> that ends the logical 
    /// operation scope on dispose.</returns>
    [DebuggerStepThrough]
    IDisposable ILogger.BeginScope<TState>(
        TState state
        )
    {
        // Defer to the inner logger.
#pragma warning disable CS8603 // Possible null reference return.
        return _innerLogger?.BeginScope(state);
#pragma warning restore CS8603 // Possible null reference return.
    }

    // *******************************************************************

    /// <summary>
    /// This method checks if the given <paramref name="logLevel"/> is enabled.
    /// </summary>
    /// <param name="logLevel">Level to be checked.</param>
    /// <returns>true if enabled.</returns>
    [DebuggerStepThrough]
    bool ILogger.IsEnabled(LogLevel logLevel)
    {
        // Defer to the inner logger.
        return _innerLogger?.IsEnabled(logLevel) ?? false;    
    }

    // *******************************************************************

    /// <summary>
    /// This method writes a log entry.
    /// </summary>
    /// <typeparam name="TState">The type of the object to be written.</typeparam>
    /// <param name="logLevel">Entry will be written on this level.</param>
    /// <param name="eventId">Id of the event.</param>
    /// <param name="state">The entry to be written. Can be also an object.</param>
    /// <param name="exception">The exception related to this entry.</param>
    /// <param name="formatter">Function to create a System.String message 
    /// of the state and exception.</param>
    [DebuggerStepThrough]
    void ILogger.Log<TState>(
        LogLevel logLevel,
        EventId eventId,
        TState state,
        Exception? exception,
        Func<TState, Exception?, string> formatter
        )
    {
        // Defer to the inner logger.
        _innerLogger?.Log<TState>(
            logLevel,
            eventId,
            state,
            exception,
            formatter
            );
    }

    #endregion
}
