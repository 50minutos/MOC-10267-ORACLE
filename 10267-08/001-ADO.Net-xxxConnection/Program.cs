using System;
using System.Data;
using System.Threading;
using Oracle.DataAccess.Client;

//Add Reference:
//Oracle.DataAccess

namespace _001_ADO.Net_xxxConnection
{
    class Program
    {
        static void Main()
        {
            const String cs = @"DATA SOURCE=127.0.0.1/ORCL;DBA PRIVILEGE=SYSDBA;USER ID=SYS;PASSWORD=queC0isa;";

            var c = new OracleConnection { ConnectionString = cs };

            c.StateChange += CStateChange;


            c.Disposed += CDisposed;

            c.Open();

            Thread.Sleep(2000);

            c.Close();

            //tentativa de liberar o objeto da memória

            //c.Dispose();

            //ou

            //c = null;
            //GC.Collect();

            Console.ReadKey();
        }

        static void CDisposed(object sender, EventArgs e)
        {
            Console.WriteLine("o objeto de conexão foi descartado da memória");
        }

        static void CStateChange(object sender, StateChangeEventArgs e)
        {
            Console.WriteLine("o status da conexão foi de {0} para {1}", e.OriginalState, e.CurrentState);
        }
    }
}
