using System;
using System.Collections;

namespace Vsite.CSharp
{
    // vrijednosni tip zbog 'struct'
    struct VrijednTip
    {
        public int X;
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            VrijednTip vt;  // objekt na stogu

            for (int i = 0; i < 10; ++i)
            {
                vt.X = i;     // incijalizira polje u vrijednosni tipu
                lista.Add(vt);  // pakira vrijednosni tip i dodaje referencu na njega u listu
            }

            foreach (VrijednTip v in lista)
            {
                Console.WriteLine(v.X); // ispisat će: 0, 1, 2...9
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
