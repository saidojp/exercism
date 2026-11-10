static class LogLine
{
    public static string Message(string logLine)
    {
        int separator = logLine.IndexOf(":");
        return logLine.Substring(separator + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf("[");
        int end = logLine.IndexOf("]");
        
        string level = logLine.Substring(start + 1, end - start - 1);

        return level.ToLower();
    }

    public static string Reformat(string logLine)
    {
    string message = Message(logLine);
    string level = LogLevel(logLine);

    return $"{message} ({level})";
    }
}
