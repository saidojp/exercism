using System.Reflection.Metadata.Ecma335;

public static class Leap
{
    public static bool IsLeapYear(int year) => year % 400 == 0 || year % 100 != 0 && year % 4 == 0;

}