using System;
using System.Collections.Generic;
using System.Linq;

namespace _005_LinqToObjects
{
    internal class Program
    {
        private static void Main()
        {
            //remova o comentário daquilo que quiser testar

            MostrarOperadorSelect();
            MostrarOperadorWhere();
            MostrarOperadorOrderBy();
            MostrarDeferredQueryExecution();
            MostrarOperadorSelectMany();

            Console.ReadKey();
        }

        #region MostrarOperadorSelectMany

        private static void MostrarOperadorSelectMany()
        {
            var lista = new List<Cliente>
                            {
                                new Cliente(1, "ADÃO", 'M')
                                    {
                                        Pedidos = new List<Pedido>
                                                      {
                                                          new Pedido(1, DateTime.Now, 1000),
                                                          new Pedido(2, DateTime.Now, 2000),
                                                          new Pedido(3, DateTime.Now, 3000)
                                                      }
                                    },
                                new Cliente(2, "EVA", 'F')
                                    {
                                        Pedidos = new List<Pedido>
                                                      {
                                                          new Pedido(4, DateTime.Now, 5000),
                                                          new Pedido(5, DateTime.Now, 12000)
                                                      }
                                    }
                            };

            var clientes = lista.Select(c => c.Nome);

            foreach (var item in clientes)
            {
                Console.WriteLine(item);
            }

            var pedidos = lista
                .SelectMany(c => c.Pedidos)
                .Select(p => new { p.Codigo, p.Valor });

            foreach (var item in pedidos)
            {
                Console.WriteLine(item);
            }
        }

        #endregion

        #region MostrarDeferredQueryExecution

        private static void MostrarDeferredQueryExecution()
        {
            int[] numeros = { 1, 2, 3, 4 };

            var numerosDobrados = from x in numeros
                                  select Dobrar(x);

            foreach (var item in numerosDobrados)
            {
                Console.WriteLine(item);
            }

            for (var i = 0; i < numeros.Length; i++)
            {
                numeros[i]++;
            }

            foreach (var item in numerosDobrados)
            {
                Console.WriteLine(item);
            }

            //immediate query execution
            //var maisNumeros = numeros
            //    .Select(n => Dobrar(n))
            //    .ToArray();

            var maisNumeros = numeros
                .Select(Dobrar)
                .ToArray();

            foreach (var item in maisNumeros)
            {
                Console.WriteLine(item);
            }
        }

        private static int Dobrar(int item)
        {
            Console.WriteLine("multiplicando");
            return item * 2;
        }

        #endregion

        private static void MostrarOperadorOrderBy()
        {
            const String x = "Santos Brasil 2012";

            var letras = from letra in x
                         orderby letra
                         select letra;

            foreach (var item in letras)
            {
                Console.WriteLine(item);
            }
        }

        private static void MostrarOperadorWhere()
        {
            const String x = "Santos Brasil 2012";

            //var numeros = from letra in x
            //              where Char.IsDigit(letra)
            //              select letra;

            //var numeros = x
            //    .Where(l => Char.IsDigit(l));

            var numeros = x
                .Where(Char.IsDigit);

            foreach (var item in numeros)
            {
                Console.WriteLine("** {0} **", item);
            }
        }

        private static void MostrarOperadorSelect()
        {
            const String x = "Santos Brasil 2012";

            //var letras = from letra in x
            //             select letra;

            var letras = x.Select(letra => letra);

            foreach (var item in letras)
            {
                Console.WriteLine(item);
            }
        }
    }
}