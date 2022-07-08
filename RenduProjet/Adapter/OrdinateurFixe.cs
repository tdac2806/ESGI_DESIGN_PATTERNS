namespace Adapter;

public class OrdinateurFixe : Ordinateur
{
    public string processeur { get; set; }
    public string cartemere { get; set; }
    public string ram { get; set; }
    public string cartegraphique { get; set; }

    public OrdinateurFixe(string processeur, string cartemere, string ram, string cartegraphique)
    {
        this.processeur = processeur;
        this.cartemere = cartemere;
        this.ram = ram;
        this.cartegraphique = cartegraphique; 
    }

    public void afficheInformation()
    {
        Console.WriteLine($"Processeur : {processeur}");
        Console.WriteLine($"Carte mère : {cartemere}");
        Console.WriteLine($"Ram : {ram}");
        Console.WriteLine($"Carte graphique : {cartegraphique}");
    }
}
