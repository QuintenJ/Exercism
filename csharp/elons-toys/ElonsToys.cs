using System;

class RemoteControlCar
{
    private int metersDriven = 0;
    private int batteryPercentage = 100;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay()
    {
        if (metersDriven > 2000)
            return "Driven 2000 meters";
        else
            return $"Driven {metersDriven} meters";
    }

    public string BatteryDisplay()
    {

        if (batteryPercentage <= 0)
            return "Battery empty";
        else
            return $"Battery at {batteryPercentage}%";
    }

    public void Drive()
    {
        metersDriven += 20;
        batteryPercentage -= 1;

    }
}
