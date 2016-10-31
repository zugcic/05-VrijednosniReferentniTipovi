using System;

namespace Vsite.CSharp
{
    // vrijednosni tip zbog 'struct'
    struct VrijednTip
    {
        public int X;
    }

    // referentni tip
    class RefTip { 
        public int X; 
    }


    public class Pridruživanje
    {
        public static void PridruživanjeStruktura(int prvaVrijednost, int drugaVrijednost)
        {
            VrijednTip vt1 = new VrijednTip();
            vt1.X = prvaVrijednost;

            // TODO: Zadati novo ime "vt2" za objekt tipa VrijednTip i pridružiti mu vrijednost objekta "vt1"


            // TODO: Dodati dvije naredbe koje će ispisati vrijednosti članova vt1.X, odnosno vt2.X


            vt1.X = drugaVrijednost;

            // TODO: Dodati dvije naredbe koje će ponovno ispisati vrijednosti članova vt1.X, odnosno vt2.X


            // TODO: Pokrenuti program i provjeriti ispis
        }

        public static void PridruživanjeKlasa(int prvaVrijednost, int drugaVrijednost)
        {
            RefTip rt1 = new RefTip();
            rt1.X = prvaVrijednost;

            // TODO: Zadati novo ime "rt2" za objekt tipa RefTip i pridružiti mu vrijednost objekta "rt1"


            // TODO: Dodati dvije naredbe koje će ispisati vrijednosti članova vt1.X, odnosno vt2.X


            rt1.X = drugaVrijednost;

            // TODO: Dodati dvije naredbe koje će ponovno ispisati vrijednosti članova vt1.X, odnosno vt2.X


            // TODO: Pokrenuti program i provjeriti ispis
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Pridruživanje vrijednosnih tipova");
            PridruživanjeStruktura(1, 5);
            Console.WriteLine();
            Console.WriteLine("Pridruživanje vrijednosnih klasa");
            PridruživanjeKlasa(1, 5);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
