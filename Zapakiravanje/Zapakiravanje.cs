using System;
using System.Collections;

namespace Vsite.CSharp
{
    class RefTip
    {
        public int X;
    }

    struct VrijednTip
    {
        public int X;
    }

    public class Zapakiravanje
    {
        public static void DodavanjeKlaseUArrayList()
        {
            ArrayList lista = new ArrayList();//referentni tip koji se smješta na heap
            RefTip rt = new RefTip();         //

            for (int i = 0; i < 10; ++i)
            {
                rt.X = i;   //kopiramo adrese sa stacka koje pokazuju uvijek na isti objekt
                lista.Add(rt);
            }

            // Dodati petlju koja će ispisati član X za svaki element kolekcije lista.
            foreach (RefTip r in lista)
            {

                Console.WriteLine(r.X);
                
            }
        }

        public static void DodavanjeStruktureUArrayList()
        {
            ArrayList lista = new ArrayList();
            VrijednTip vt = new VrijednTip();

            for (int i = 0; i < 10; ++i)
            {
                vt.X = i;
                lista.Add(vt);
            }

            // Dodati petlju koja će ispisati član X za svaki element kolekcije lista.
            foreach (VrijednTip r in lista)
            {

                Console.WriteLine(r.X);

            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Dodavanje klase");
            DodavanjeKlaseUArrayList();

            Console.WriteLine("Dodavanje strukture");
            DodavanjeStruktureUArrayList();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
