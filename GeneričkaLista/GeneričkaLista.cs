using System;
using System.Collections.Generic;

namespace Vsite.CSharp
{
    struct VrijednTip
    {
        public int X;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<VrijednTip> lista = new List<VrijednTip>();
            VrijednTip vt = new VrijednTip();
            for (int i = 0; i < 10; ++i)
            {
                vt.X = i;
                lista.Add(vt);
            }

            foreach (VrijednTip v in lista)
            {
                Console.WriteLine(v.X); // ispisat će: 0, 1, 2...9
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
