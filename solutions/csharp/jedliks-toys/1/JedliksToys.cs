class RemoteControlCar
{
    public int DistanceDriven { get; private set; } = 0;
    public int BatteryPercentage {get; private set; } = 100;
    public static RemoteControlCar Buy()
    {
        var new_car = new RemoteControlCar();
        return new_car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {DistanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        return BatteryPercentage == 0 ? "Battery empty" : $"Battery at {BatteryPercentage}%";
    }

    public void Drive()
    {
        if (BatteryPercentage == 0) {
            return;
        }
        DistanceDriven += 20;
        BatteryPercentage -= 1;   
    }
}
