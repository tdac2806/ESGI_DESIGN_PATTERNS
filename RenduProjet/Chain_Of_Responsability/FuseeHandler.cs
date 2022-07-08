namespace Chain_Of_Responsability;

public class FuseeHandler : Handler
{
public override void Handle(string request)
    {
        if (request == "Hydrogène")
        {
            Console.WriteLine("Fusee handled");
        }
        else if (request != null && next != null)
        {
            next.Handle(request);
        }
    }
}