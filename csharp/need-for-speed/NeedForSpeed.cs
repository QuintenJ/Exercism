using System;

class RemoteControlCar
{
    private readonly int speed;
    private readonly int batteryDrain;
    int distance = 0;
    int battery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => battery <= 0;

    public int DistanceDriven() => distance;

    public void Drive()
    {
        if (BatteryDrained())
            return;
        distance += speed;
        battery -= batteryDrain;
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private readonly int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }



    public bool CarCanFinish(RemoteControlCar car)
    {
        bool canFinish = true;
        bool finish = true;
        while (finish)
        {
            car.Drive();
            if (car.DistanceDriven() >= this.distance)
                return canFinish = true;
            if (car.BatteryDrained())
                return canFinish = false;
        }
        return canFinish;
    }
}
