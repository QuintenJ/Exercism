using System;
using System.Linq;

class BirdCount
{
    int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay) => this.birdsPerDay = birdsPerDay;

    public static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today() => birdsPerDay[6];

    public int IncrementTodaysCount() => birdsPerDay[birdsPerDay.Length - 1]++;

    public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays) => birdsPerDay.Take(numberOfDays).Sum();

    public int BusyDays() => birdsPerDay.Where(o => o >= 5).Count();

}
