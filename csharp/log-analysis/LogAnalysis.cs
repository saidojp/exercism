public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string separator)
    {
        int index = str.IndexOf(separator);
        if (index == -1)
        {
            return string.Empty; 
        }
        return str.Substring(index + separator.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string start, string end)
    {
        int startIndex = str.IndexOf(start);
        if (startIndex == -1)
        {
            return string.Empty; 
        }
        startIndex += start.Length;

        int endIndex = str.IndexOf(end, startIndex);
        if (endIndex == -1)
        {
            return string.Empty; 
        }

        return str.Substring(startIndex, endIndex - startIndex);
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}