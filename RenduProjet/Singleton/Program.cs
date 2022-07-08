namespace Singleton;

public class Program
{
    static void Main(string[] args)
    {
        var path = "data.txt";                  // Path du fichier
        User user1 = new User();                // Cree un nouvel utilisateur
        User user2 = new User();                // Cree un deuxieme utilisateur
        user1.StartWriter(path);                // Démarre l'écriture dans le fichier
        user2.StartWriter(path);                // Ne démarre pas de nouvelle ecriture (utilise celle d'user1)
        user1.Write("Hello");            // Ecrit dans le fichier
        user2.Write("Hello2");           // Ecrit dans le fichier
        user1.Close();                          // Ferme le fichier
        user2.Write("Bye");              // Ne fait rien (l'instance à été fermée par user 1)
        user2.StartWriter(path);                // Démarre une nouvelle ecriture dans le fichier
        user2.Write("Bye2");             // Ecrit dans le fichier
        user2.Close();                          // Ferme le fichier
        Console.WriteLine(user1.Read(path));    // Lit le fichier
    }
}