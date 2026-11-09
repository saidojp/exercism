class Lasagna
{
    // Cooking time
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // Remaining cooking time
    public int RemainingMinutesInOven(int actualMinutesInOven)
    {
        return ExpectedMinutesInOven() - actualMinutesInOven;
    }

    // Preparation time
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // Total elapsed time
    public int ElapsedTimeInMinutes(int layers, int actualMinutesInOven)
    {
        return PreparationTimeInMinutes(layers) + actualMinutesInOven;
    }
}