using System;
using System.Data;

namespace _006_MostrarLinqToDataSet
{
    class Program
    {
        static void Main()
        {
            var dt = new DataTable("PRODUTOS");

            //Como se obter o Type
            //var t = typeof(Tipo);
            //var t = variavel.GetType();

            dt.Columns.Add("CODIGO", typeof(int));
            dt.Columns.Add("DESCRICAO", typeof(String));
            dt.Columns.Add("PRECO", typeof(double));

            dt.Columns[1].MaxLength = 50;

            var dr = dt.NewRow();

            dr[0] = 1;
            dr[1] = "MARTELO";
            dr[2] = 33.10;

            dt.Rows.Add(dr);

            dr = dt.NewRow();

            dr[0] = 2;
            dr[1] = "SERROTE";
            dr[2] = 110.20;

            dt.Rows.Add(dr);

            dr = dt.NewRow();

            dr[0] = 3;
            dr[1] = "CHAVE DE FENDA";
            dr[2] = 13.30;

            dt.Rows.Add(dr);

            var produtos = from p in dt.AsEnumerable()
                           where (double)p[2] > 0
                           select p;

            foreach (var produto in produtos)
            {
                foreach (var campo in produto.ItemArray)
                {
                    Console.Write("{0} ", campo);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            var novaTabela = dt
                .AsEnumerable()
                .Where(p => p.Field<double>(2) > 15)
                .CopyToDataTable();

            foreach (DataRow linha in novaTabela.Rows)
            {
                foreach (DataColumn coluna in novaTabela.Columns)
                {
                    Console.Write("{0} ", linha[coluna]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
