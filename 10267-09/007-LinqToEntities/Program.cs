using System;

namespace _007_LinqToEntities
{
    class Program
    {
        static void Main()
        {
            using (var e = new Entities())
            {
                foreach (var item in e.Generos)
                {
                    Console.WriteLine("{0} -> {1}", item.Id, item.Nome);
                }
            }

            Console.ReadKey();
        }
    }
}
