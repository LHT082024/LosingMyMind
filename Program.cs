using System.Security.Cryptography.X509Certificates;

namespace LosingMyMind.Classes;

class Program
{

    static void Main(string[] args)
    {
        GenericClass<string, string, double> genericClass = new GenericClass<string, string, double>();
        genericClass.Phantom = "If you dont love me everyone DIES!!!!";
        genericClass.Raoul = "HOW DARE YOU SPEAK TO ANOTHER MAN!";
        genericClass.Christine = 8.8;
        genericClass.lovers = 2;
        genericClass.Iq = 2.5;

        Console.WriteLine(genericClass.Phantom);
        Console.WriteLine(genericClass.Raoul);
        Console.WriteLine(genericClass.Christine);
        Console.WriteLine($"lovers {genericClass.lovers}");
        Console.WriteLine($"their collective iq {genericClass.Iq}");
    }
}
