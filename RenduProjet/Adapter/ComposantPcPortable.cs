namespace Adapter;

public class ComposantPcPortable
{
    public string processeur { get; set; }
    public string cartemere{ get; set; }
    public string ram{ get; set; }
    public string cartegraphique{ get; set; }
    public string tailleecran{ get; set; }
    public string autonomie{ get; set; }
    public string poids{ get; set; }
    

    public void afficheComposant()
    {
        Console.WriteLine($"Processeur : {processeur}");
        Console.WriteLine($"Carte mere : {cartemere}");
        Console.WriteLine($"Ram : {ram}");
        Console.WriteLine($"Carte graphique : {cartegraphique}");
        Console.WriteLine($"Taille ecran : {tailleecran}");
        Console.WriteLine($"Autonomie : {autonomie}");
        Console.WriteLine($"Poids : {poids}");
    }

}