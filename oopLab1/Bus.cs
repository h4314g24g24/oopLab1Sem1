using System;
public class Bus : Transport
{
    public int RouteNumber { get; set; }

    public Bus(string brand, int speed, int capacity, int routeNumber)
        : base(brand, speed, capacity)
    {
        RouteNumber = routeNumber;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $", Маршрут №{RouteNumber}";
    }
}
