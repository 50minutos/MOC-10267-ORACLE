using System;

namespace _005_LinqToObjects
{
    public class Pedido
    {
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        public Pedido(int codigo, DateTime data, double valor)
        {
            Codigo = codigo;
            Data = data;
            Valor = valor;
        }
    }
}
