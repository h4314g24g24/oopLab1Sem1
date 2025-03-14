using System;
public class Bicycle : Transport
{
    public bool HasGears { get; set; }

    public Bicycle(string brand, int speed, int capacity, bool hasGears)
        : base(brand, speed, capacity)
    {
        HasGears = hasGears;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $", Передачі: {(HasGears ? "є" : "немає")}";
    }
}
