namespace Singleton;

public sealed class Vendeur
{
    private Vendeur()
    {
    }
    private static Vendeur _instance = null;
    public int TotalSales { get; set; }
    public static Vendeur Instance()
    {
        if(null == _instance)
        {
            _instance = new Vendeur();
        }
        return _instance;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Vendeur vendeur1 = Vendeur.Instance();
        vendeur1.TotalSales = 12;
        Console.WriteLine("Vendeur1 valeur : " + vendeur1.TotalSales);
        Vendeur vendeur2 = Vendeur.Instance();
        Console.WriteLine("Vendeur2 valeur : " + vendeur2.TotalSales);
        if (vendeur1 == vendeur2)
        {
            Console.WriteLine("Il y a bien qu'une seule instance");
        }
    }
}