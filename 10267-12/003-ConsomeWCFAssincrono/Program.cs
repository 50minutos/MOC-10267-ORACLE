using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _003_ConsomeWCFAssincrono.ProxyGenero;

namespace _003_ConsomeWCFAssincrono
{
    class Program
    {
        static GeneroServiceClient c = null;

        static void Main(string[] args)
        {
            c = new GeneroServiceClient();

            c.BeginGetFirst10(GetFirst10Completed, null);

            c.BeginGetById(1, GetByIdCompleted, null);
            c.BeginGetById(10, GetByIdCompleted, null);
            c.BeginGetById(100, GetByIdCompleted, null);

            Console.ReadKey();
        }

        private static void GetByIdCompleted(IAsyncResult iar)
        {
            var contato = c.EndGetById(iar);

            if (contato == null) return;

            Console.WriteLine("por Id -> {0} {1}", contato.Id, contato.Nome);
        }

        private static void GetFirst10Completed(IAsyncResult iar)
        {
            var contatos = c.EndGetFirst10(iar);

            if (contatos == null || contatos.Length == 0) return;

            foreach (var item in contatos)
            {
                Console.WriteLine("-> {0} {1}", item.Id, item.Nome);
            }
        }
    }
}
