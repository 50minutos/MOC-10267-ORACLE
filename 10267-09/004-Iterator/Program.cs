using System;
using System.Collections.Generic;

namespace _004_Iterator
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("------------");
            Console.WriteLine("SEM ITERATOR");
            Console.WriteLine("------------");

            foreach (var item in ObterNumeros())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("------------");
            Console.WriteLine("COM ITERATOR");
            Console.WriteLine("------------");
            
            foreach (var item in ObterNumerosIterator())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static IEnumerable<int> ObterNumeros()
        {
            var retorno = new List<int>();

            Console.WriteLine("adicionei 1");
            retorno.Add(1);

            Console.WriteLine("adicionei 11");
            retorno.Add(11);

            Console.WriteLine("adicionei 111");
            retorno.Add(111);

            return retorno;
        }

        private static IEnumerable<int> ObterNumerosIterator()
        {
            Console.WriteLine("retornei 1");
            yield return 1;

            Console.WriteLine("retornei 11");
            yield return 11;

            Console.WriteLine("retornei 111");
            yield return 111;
        }
    }
}