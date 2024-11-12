using System.Security.Cryptography.X509Certificates;

namespace LosingMyMind.Classes;

class Program
{

    static void Main(string[] args)
    {
        GenericClass<string, string, string> genericClass = new GenericClass<string, string, string>();
        genericClass.Phantom = "If you dont love me everyone DIES!!!!";
        genericClass.Raoul = "HOW DARE YOU SPEAK TO ANOTHER MAN!";
        genericClass.Christine = "Are we sure this is a romance?";

        Console.WriteLine(genericClass.Phantom);
        Console.WriteLine(genericClass.Raoul);
        Console.WriteLine(genericClass.Christine);

    }
}
