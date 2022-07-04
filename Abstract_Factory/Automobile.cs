namespace Abstract_Factory;
public abstract class Automobile
{
    protected string brand;
    protected string color;
    protected int power;
    protected double space;

    protected Automobile(string brand, string color, int power, double space)
    {
        this.brand = brand;
        this.color = color;
        this.power = power;
        this.space = space;
    }
    public abstract void ShowCarac();
    
}