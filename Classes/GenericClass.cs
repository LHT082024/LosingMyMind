using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LosingMyMind.Classes
{


    //her setter jeg opp 3 generiske typer T, U, I
    //jeg har også satt opp 2 primitive typer int og double

    //med min forståelse for genersike typer så er det typer som du lager utenom string, int osv  
    //og istede modifiserer seinere med forskjellige verdier.
    public class GenericClass<T, U, I>
    {
        public T? Phantom;
        public U? Raoul;
        public I? Christine;

        public int lovers;

        public double Iq;

    }
}
