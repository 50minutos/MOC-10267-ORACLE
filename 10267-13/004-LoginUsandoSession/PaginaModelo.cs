using System;
using System.Web.UI;

namespace _004_LoginUsandoSession
{
    public class PaginaModelo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USUARIO"] == null)
                Response.Redirect("~/Login.aspx");
        }
    }
}