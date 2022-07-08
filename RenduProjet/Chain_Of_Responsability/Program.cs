using Chain_Of_Responsability;

public class Program
{
    static void Main(string[] args)
    {
        FuseeHandler fusee = new FuseeHandler();
        VoitureDieselHandler voitureDiesel = new VoitureDieselHandler();
        VoitureEssenceHandler voitureEssence = new VoitureEssenceHandler();
 
        fusee.setNext(voitureDiesel).setNext(voitureEssence);
        
        string[] requests = { "SP98", "Diesel", "SP95", "Hydrogène", "SP95-E10"};
        foreach (string request in requests)
        {
            fusee.Handle(request);
        }

    }
}