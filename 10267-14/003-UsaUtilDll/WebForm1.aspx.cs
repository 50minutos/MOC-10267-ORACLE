using System;
using System.Web.UI;
using _002_Util;

namespace _003_UsaUtilDll
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Calculadora.Somar(1, 2, 3, 4));
            Response.Write("<p/>");
            Response.Write(Calculadora.Subtrair(1, 2));
            Response.Write("<p/>");
            Response.Write(Calculadora.Multiplicar(1, 2, 3, 4));
            Response.Write("<p/>");
            Response.Write(Calculadora.Dividir(3, 4));
        }
    }
}