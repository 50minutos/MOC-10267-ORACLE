using System;
using System.Collections.Generic;

namespace _005_LinqToObjects
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public char Sexo { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Cliente(int codigo, string nome, char sexo)
        {
            Codigo = codigo;
            Nome = nome;
            Sexo = sexo;
        }
    }
}
