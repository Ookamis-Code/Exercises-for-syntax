static class LogLine
{
    public static string Message(string logLine)
    {
        int colonIndex = logLine.IndexOf(':');
        if (colonIndex != -1) {
            return logLine.Substring(colonIndex + 1).Trim();
        }
        throw new ArgumentException("Invalid log line format");
    }

    public static string LogLevel(string logLine)
    {
       int colonIndex = logLine.IndexOf(':');
        if (colonIndex != -1) {
            string level = logLine.Substring(0, colonIndex).Trim(' ', '[', ']').ToLower();
            return level;
        }
        throw new ArgumentException("Invalid log line format");
    }

    public static string Reformat(string logLine)
    {
        string level = LogLevel(logLine);
        string message = Message(logLine);
        return $"{message} ({level})";
    }
}
