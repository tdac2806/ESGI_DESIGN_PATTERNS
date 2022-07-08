namespace Adapter;

public interface Ordinateur
{
    string processeur { get; set; }
    string cartemere { get; set; }
    string ram { get; set; }
    string cartegraphique { get; set; }
    
    void afficheInformation();
    
}