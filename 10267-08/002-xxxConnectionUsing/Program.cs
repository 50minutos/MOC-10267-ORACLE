using System;
using System.Threading;
using Oracle.DataAccess.Client;

//Add Reference:
//Oracle.DataAccess

namespace _002_xxxConnectionUsing
{
    internal class Program
    {
        private static void Main()
        {
            const String cs = @"DATA SOURCE=127.0.0.1/ORCL;USER ID=chinook;PASSWORD=p4ssw0rd;";

            using (var c = new OracleConnection {ConnectionString = cs})
            {
                c.StateChange += CStateChange;
                c.Disposed += CDisposed;

                c.Open();

                Thread.Sleep(1000);

                c.Close();
            
                Thread.Sleep(1000);
            }

            Console.ReadKey();
        }

        private static void CDisposed(object sender, EventArgs e)
        {
            Console.WriteLine("o objeto de conexão foi descartado da memória");
        }

        private static void CStateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            Console.WriteLine("o status da conexão foi de {0} para {1}", e.OriginalState, e.CurrentState);
        }
    }
}