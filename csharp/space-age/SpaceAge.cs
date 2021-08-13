using System;

public class SpaceAge
{
    private readonly int Age;

    private double CalculateAge(int age, double x) => age / (x * 31557600.0);

    public SpaceAge(int seconds) => Age = seconds;

    public double OnEarth() => CalculateAge(Age, 1);

    public double OnMercury() => CalculateAge(Age, 0.2408467);

    public double OnVenus() => CalculateAge(Age, 0.61519726);

    public double OnMars() => CalculateAge(Age, 1.8808158);

    public double OnJupiter() => CalculateAge(Age, 11.862615);

    public double OnSaturn() => CalculateAge(Age, 29.447498);

    public double OnUranus() => CalculateAge(Age, 84.016846);

    public double OnNeptune() => CalculateAge(Age, 164.79132);
}