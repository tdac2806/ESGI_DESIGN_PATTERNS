namespace Abstract_Factory;

public class ElectricVehicleFactory : IVehicleFactory
{
    public Automobile CreateAutomobile(string brand, string color, int power, double space)
    {
        return new ElectricAutomobile(brand, color, power, space);
    }
}