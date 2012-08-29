using System.Linq;

namespace _002_Util
{
    public class Calculadora
    {
        public static double Somar(params double[] itens)
        {
            return itens.Sum();
        }

        public static double Subtrair(double x, double y)
        {
            return x - y;
        }

        public static double Multiplicar(params double[] itens)
        {
            return itens.Aggregate<double, double>(1, (current, item) => current * item);
        }

        public static double Dividir(double x, double y)
        {
            return x / y;
        }

        //registrar no GAC:
        //abrir o VS2010 command prompt como administrador
        //executar o comando: gacutil -I "C:\Users\Usuario\Desktop\10267 ORACLE\10267-14\Util\bin\Debug\Util.dll"
    }
}
