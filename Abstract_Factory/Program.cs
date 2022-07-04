namespace Abstract_Factory;

public class Catalogue
{
    public static int VehicleNumber = 3;
    public static void Main(string[] args)
    {
      IVehicleFactory factory = new ElectricVehicleFactory();
        Automobile auto = factory.CreateAutomobile("Ford", "Red", 300, 2.5);
        auto.ShowCarac();
    }
}