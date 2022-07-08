using System;
using Adapter;

public class Program
{
    static void Main(string[] args)
    {
        Ordinateur ordinateur1, ordinateur2;
        ordinateur1 = new OrdinateurFixe("Core i9-12900KS","ROG MAXIMUS Z690 HERO","2x16GB","RTX 3090");
        ordinateur1.afficheInformation();
        Console.WriteLine();
        ordinateur2 = new OrdinateurPortable("AMD Ryzen 7 5800H","DELL ALIENWARE M15 R5","16GB","RTX 3060 mobile","15.6","9h","2kg");
        ordinateur2.afficheInformation();
    }
}