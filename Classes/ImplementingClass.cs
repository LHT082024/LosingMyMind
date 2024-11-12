using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LosingMyMind.Classes
{
    public class ImplimentingClass
    {
        GenericClass<string, string, string> genericClass = new GenericClass<string, string, string>();

        public void ImplimentationMethod()
        {
            genericClass.Phantom = "If you dont love me everyone DIES!!!!";
            genericClass.Raoul = "HOW DARE YOU SPEAK TO ANOTHER MAN!";
            genericClass.Christine = "Are we sure this is a romance?";
        }

        public void WriteGenericMethod()
        {
            Console.WriteLine(genericClass.Phantom);
            Console.WriteLine(genericClass.Raoul);
            Console.WriteLine(genericClass.Christine);
        }





    }
}