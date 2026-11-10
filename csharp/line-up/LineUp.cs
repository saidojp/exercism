public static class LineUp
{
    public static string Format(string name, int number)
    {
       string ending = "th";

       int lastTwoDigits = number % 100;
       int lastDigit = number % 10;

       if (lastTwoDigits >= 11 && lastTwoDigits <= 13)
       {
        ending = "th";
       }

       else if (lastDigit == 1)
       {
        ending = "st";
       }
        else if (lastDigit == 2)
       {
        ending = "nd";
       }
        else if (lastDigit == 3)
       {
        ending = "rd";
       }    
        return $"{name}, you are the {number}{ending} customer we serve today. Thank you!";
    }

    /* 
        or other way to solve it

    {
        string ordinalNumeral = (number % 10) switch
        {
            1 when (number % 100 != 11) => "st",
            2 when (number % 100 != 12) => "nd",
            3 when (number % 100 != 13) => "rd",
            _ => "th"
        };

        return $"{name}, you are the {number}{ordinalNumeral} customer we serve today. Thank you!";
        }
    
    */
}
