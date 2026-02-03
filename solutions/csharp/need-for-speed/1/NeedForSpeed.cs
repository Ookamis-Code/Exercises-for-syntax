class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int speedpercorred;
    private int batterycharge;
    
    public RemoteControlCar(int spd, int batDrain)
    {
        speed = spd;
        batteryDrain = batDrain;
        speedpercorred = 0;
        batterycharge = 100;
    }
    
    public bool BatteryDrained()
    {
        return batterycharge < batteryDrain;
    }

    public int DistanceDriven()
    {
        return speedpercorred;
    }

    public void Drive()
    {
        if (!BatteryDrained() && batterycharge >= batteryDrain) {
            speedpercorred = speedpercorred + speed;
        }
        batterycharge = batterycharge - batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance;
    public RaceTrack(int dst)
    {
        distance = dst;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained()) {
            car.Drive();
        }
        return car.DistanceDriven() >= distance;
    }
}
