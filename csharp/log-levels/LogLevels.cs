using System;


static class LogLine
{
    public static string Message(string logLine)
    {
        if (logLine.Contains("[ERROR]: "))
            return logLine.Replace("[ERROR]: ", "").Trim();
        else if (logLine.Contains("[INFO]: "))
            return logLine.Replace("[INFO]: ", "").Trim();
        else if (logLine.Contains("[WARNING]: "))
            return logLine.Replace("[WARNING]: ", "").Trim();
        else
            return logLine;
    }

    public static string LogLevel(string logLine)
    {
        if (logLine.Contains("[ERROR]: "))
            return "error";
        else if (logLine.Contains("[INFO]: "))
            return "info";
        else if (logLine.Contains("[WARNING]: "))
            return "warning";
        else
            return logLine;
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
