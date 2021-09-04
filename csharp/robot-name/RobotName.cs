using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly Random random = new Random();
    private static readonly HashSet<string> names = new HashSet<string>();

    public string Name { get; private set; }

    public Robot() => assignName();

    public void Reset() => assignName();

    private void assignName()
    {
        string robotName;
        do { robotName = generateName(); } while (names.Contains(robotName));
        names.Add(robotName);
        this.Name = robotName;
    }

    private string generateName() =>
        $"{randomLetter()}{randomLetter()}{random.Next(0, 1000):d03}";

    private char randomLetter() => (char)random.Next('A', 'Z' + 1);
}