namespace Chain_Of_Responsability;

public class VoitureEssenceHandler : Handler
{
    public override void Handle(string request)
    {
        if (request == "SP95-E10" || request == "SP95" || request == "SP98")
        {
            Console.WriteLine("Voiture Essence handled");
        }
        else if (request != null && next != null)
        {
            next.Handle(request);
        }
    }
}
