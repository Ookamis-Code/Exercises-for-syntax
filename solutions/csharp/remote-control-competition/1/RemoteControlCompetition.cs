// TODO implement the IRemoteControlCar interface
public interface IRemoteControlCar : IComparable<IRemoteControlCar>
{
    void Drive();
    int DistanceTravelled { get; }
    int NumberOfVictories { get; }
    
    
}

public class ProductionRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }
    public int CompareTo(IRemoteControlCar other) 
    {
        if (other == null) return 1;
        return this.NumberOfVictories.CompareTo(other.NumberOfVictories);
    }

    public void Drive()
    {
        DistanceTravelled += 10;
    }
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }
    public int CompareTo(IRemoteControlCar other) 
    {
        if (other == null) return 1;
        return this.DistanceTravelled.CompareTo(other.DistanceTravelled);
    }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        var cars = new List<ProductionRemoteControlCar> { prc1, prc2 };
        cars.Sort();
        return cars;
    }
}
