using System;

static class AssemblyLine
{
    public static double ProductionRatePerHour(int speed)
    {
        if (speed >= 1 && speed <= 4)
        {
            return speed * 221.0;
        }
        else if (speed > 5 && speed <= 7)
        {
            return speed * 198.9;
        }
        else if (speed == 9)
        {
            return speed * 176.8;
        }
        else if (speed == 10)
        {
            return Math.Round(speed * 170.17, 2);
        }
        {
            return speed * 0.0;
        }
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        if (speed >= 1 && speed <= 4)
        {
            return (speed * 221) / 60;
        }
        else if (speed >= 5 && speed <= 8)
        {
            return (speed * 199) / 60;
        }
        else if (speed == 9)
        {
            return speed * 177 / 60;
        }
        else if (speed == 10)
        {
            return speed * 170 / 60;
        }
        {
            return speed * 0;
        }
    }
}

