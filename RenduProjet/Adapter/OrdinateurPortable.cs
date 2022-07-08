namespace Adapter;

public class OrdinateurPortable : Ordinateur
{
    public string processeur {
        get
        {
            return composantPcPortable.processeur;
        }
        set
        {
            composantPcPortable.processeur = (value);
        }
    }
    
    public string cartemere {
        get
        {
            return composantPcPortable.cartemere;
        }
        set
        {
            composantPcPortable.cartemere = (value);
        }
    } 
    
    public string ram {
        get
        {
            return composantPcPortable.ram;
        }
        set
        {
            composantPcPortable.ram = (value);
        }
    } 
    
    public string cartegraphique {
        get
        {
            return composantPcPortable.cartegraphique;
        }
        set
        {
            composantPcPortable.cartegraphique = (value);
        }
    } 

    protected ComposantPcPortable composantPcPortable = new ComposantPcPortable();
    
    public OrdinateurPortable(string processeur, string cartemere, string ram, string cartegraphique,string tailleecran,string autonomie, string poids)
    {
        this.processeur = processeur;
        this.cartemere = cartemere;
        this.ram = ram;
        this.cartegraphique = cartegraphique;
        composantPcPortable.autonomie = autonomie;
        composantPcPortable.tailleecran = tailleecran;
        composantPcPortable.poids = poids;
    }
    
    public void afficheInformation()
    {
        composantPcPortable.afficheComposant();
    }
    
}
