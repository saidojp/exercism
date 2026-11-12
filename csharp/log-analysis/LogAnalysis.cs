
public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string subs)
        => str[(str.IndexOf(subs) + subs.Length)..];
    public static string SubstringBetween(this string str, string start, string end)
        => str[(str.IndexOf(start) + start.Length)..str.IndexOf(end)];
    public static string Message(this string str) => str.SubstringAfter(": ");
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}