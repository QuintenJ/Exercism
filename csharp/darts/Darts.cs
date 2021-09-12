using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        var diststanceFromCenter = (x * x) + (y * y);

        if (diststanceFromCenter <= 1)
            return 10;
        else if (diststanceFromCenter > 1 && diststanceFromCenter <= 25)
            return 5;
        else if (diststanceFromCenter > 25 && diststanceFromCenter <= 100)
            return 1;
        else
            return 0;
    }
}
