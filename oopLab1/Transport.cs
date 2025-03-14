using System;
public class Transport
{
    public string Brand { get; set; }
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public Transport(string brand, int speed, int capacity)
    {
        Brand = brand;
        Speed = speed;
        Capacity = capacity;
    }

    public virtual string GetInfo()
    {
        return $"Марка: {Brand}, Швидкість: {Speed} км/г, Вмістимість: {Capacity}";
    }
}
