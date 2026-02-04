enum LogLevel 
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine) => logLine switch
    {
        _ when logLine.StartsWith("[TRC]") => LogLevel.Trace,
        _ when logLine.StartsWith("[DBG]") => LogLevel.Debug,
        _ when logLine.StartsWith("[INF]") => LogLevel.Info,
        _ when logLine.StartsWith("[WRN]") => LogLevel.Warning,
        _ when logLine.StartsWith("[ERR]") => LogLevel.Error,
        _ when logLine.StartsWith("[FTL]") => LogLevel.Fatal,
        _ => LogLevel.Unknown
    };

    public static string OutputForShortLog(LogLevel logLevel, string message) => $"{(int)logLevel}:{message}";
}
