namespace Chain_Of_Responsability;

public class VoitureDieselHandler : Handler
{
    public override void Handle(string request)
    {
        if (request == "Diesel")
        {
            Console.WriteLine("Voiture Diesel handled");
        }
        else if (request != null && next != null)
        {
            next.Handle(request);
        }
    }
}