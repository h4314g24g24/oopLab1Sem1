using System;
public class Car : Transport
{
    public string FuelType { get; set; }

    public Car(string brand, int speed, int capacity, string fuelType)
        : base(brand, speed, capacity)
    {
        FuelType = fuelType;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $", Пальне: {FuelType}";
    }
}
