class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int timeInOven) => ExpectedMinutesInOven() - timeInOven;

    public int PreparationTimeInMinutes(int lasagnaLayers) => lasagnaLayers * 2;

    public int ElapsedTimeInMinutes(int lasagnaLayers, int timeInOven) => PreparationTimeInMinutes(lasagnaLayers) + timeInOven;
}
