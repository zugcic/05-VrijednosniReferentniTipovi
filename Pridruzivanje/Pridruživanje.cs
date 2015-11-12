using System;

namespace Vsite.CSharp
{
    // referentni tip
    class RefTip { 
        public int X; 
    }

    // vrijednosni tip zbog 'struct'
    struct VrijednTip { 
        public int X; 
    }


    class Program
    {
        static void Main(string[] args)
        {
            RefTip rt1 = new RefTip(); // na hrpi
            VrijednTip vt1 = new VrijednTip();   // na stogu

            rt1.X = 5; // dereferencira pokazivač
            vt1.X = 5; // promjena na stogu

            Console.WriteLine("rt1.X = {0}", rt1.X);
            Console.WriteLine("vt1.X = {0}", vt1.X);

            Console.WriteLine("Inicijaliziramo nove objekte i pridružimo im postojeće");
            RefTip rt2 = rt1;
            VrijednTip vt2 = vt1;

            Console.WriteLine("Mijenjamo rt1.X");
            rt1.X = 1; // promijenit će "original" i "presliku"
            Console.WriteLine("rt1.X = {0}", rt1.X);
            Console.WriteLine("rt2.X = {0}", rt2.X);

            Console.WriteLine("Mijenjamo vt1.X");
            vt1.X = 1;
            Console.WriteLine("vt1.X = {0}", vt1.X);
            Console.WriteLine("vt2.X = {0}", vt2.X);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
