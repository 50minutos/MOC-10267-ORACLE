using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _002_ConsomeWCF.ProxyGenero;

namespace _002_ConsomeWCF
{
    class Program
    {
        static void Main()
        {
            var proxy = new GeneroServiceClient();

            var c = proxy.GetById(1);
            if (c != null) Console.WriteLine("{0} -> {1}", c.Id, c.Nome);

            c = proxy.GetById(10);
            if (c != null) Console.WriteLine("{0} -> {1}", c.Id, c.Nome);

            c = proxy.GetById(10000);
            if (c != null) Console.WriteLine("{0} -> {1}", c.Id, c.Nome);

            Console.WriteLine();

            var generos = proxy.GetFirst10();

            foreach (var item in generos)
            {
                Console.WriteLine("{0} -> {1}", item.Id, item.Nome);
            }

            Console.ReadKey();

        }
    }
}
