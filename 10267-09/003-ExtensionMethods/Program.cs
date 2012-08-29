using System;
using System.Collections.Generic;

namespace _003_ExtensionMethods
{
    class Program
    {
        static void Main()
        {
            //Veja o arquivo Extensions.cs

            Console.WriteLine("x".MeuNome());
            Console.WriteLine((10).MeuNome());

            const int x = 10;
            Console.WriteLine(x.MeuNome());

            var lista = new List<int> { 1, 2, 324, 54, 6, 23, 23 };
            Console.WriteLine(lista.Somar());

            Console.ReadKey();
        }
    }
}
