namespace Abstract_Factory;

public class ElectricAutomobile : Automobile
{
    public ElectricAutomobile(string brand, string color, int power, double space) : base(brand, color, power, space)
    {
    }
    
    public override  void ShowCarac()
    {
        Console.WriteLine("Electric Automobile :");
        Console.WriteLine("Brand : " + brand);
        Console.WriteLine("Color : " + color);
        Console.WriteLine("Power : " + power);
        Console.WriteLine("Space : " + space);
    }
}