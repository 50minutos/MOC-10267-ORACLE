using System;
using System.Collections.Generic;
using System.Linq;

namespace _003_ExtensionMethods
{
    public static class Extensions
    {
        public static String MeuNome(this Object o)
        {
            return "Agnaldo";
        }

        public static int Somar(this List<int> lista)
        {
            return lista.Sum();
        }
    }
}
