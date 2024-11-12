using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LosingMyMind.Classes
{
    public class ImplimentingClass
    {
        private readonly GenericClass<string, string, string> genericClass = new GenericClass<string, string, string>();

        public void WriteMethod()
        {
            string phantom = "If you dont love me everyone DIES!!!!";
            genericClass.Phantom = phantom;
            genericClass.Raoul = "HOW DARE YOU SPEAK TO ANOTHER MAN!";
            genericClass.Christine = "Are we sure this is a romance?";
        }






    }
}