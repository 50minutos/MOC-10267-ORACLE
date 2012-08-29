using System;

namespace _001_AnonymousType
{
    class Program
    {
        static void Main()
        {
            var c = new
            {
                Marca = "FIAT",
                Modelo = "147L",
                Ano = 1980
            };

            var p = new
            {
                Nome = "Agnaldo",
                Sobrenome = "dos Santos",
                Idade = 45
            };

            Console.WriteLine("{0} {1} {2}",
              c.Marca,
              c.Modelo,
              c.Ano);

            Console.WriteLine("{0} {1} {2}",
              p.Nome,
              p.Sobrenome,
              p.Idade);

            Console.WriteLine();

            Console.WriteLine(c.GetType().Name);
            Console.WriteLine(p.GetType().Name);

            Console.WriteLine();

            Console.WriteLine(c);
            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
