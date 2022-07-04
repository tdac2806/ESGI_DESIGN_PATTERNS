namespace Abstract_Factory;

public interface IVehicleFactory
{
    Automobile CreateAutomobile(string brand, string color, int power, double space);
}