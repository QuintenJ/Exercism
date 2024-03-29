﻿using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
            throw new ArgumentOutOfRangeException("Value must be between 1 and 64");

        return (ulong)Math.Pow(2, n - 1);
    }

    public static ulong Total()
    {
        return (ulong)Math.Pow(2, 64) - 1;
    }
}