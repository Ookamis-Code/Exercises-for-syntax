class WeighingMachine
{
    
    public double Precision { get; } 

    
    public WeighingMachine(int precision)
    {
        Precision = precision;
    }

    private double _weight;
    public double Weight 
    {
        get => _weight;
        
        set => _weight = value < 0 
            ? throw new ArgumentOutOfRangeException() 
            : Math.Round(value, (int)Precision);
    }

    public double TareAdjustment { get; set; } = 5.0; 

    public string DisplayWeight => 
        (Weight - TareAdjustment).ToString($"F{(int)Precision}") + " kg";
}
