using System;
using System.Collections.Generic;
using System.Web.UI;

namespace _005_Chat
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1Click(object sender, EventArgs e)
        {
            if (Nome.Text.Equals(String.Empty)) return;
            
            var lista = (List<String>)Application["USRS"];

            if (lista.Contains(Nome.Text))
                Label1.Text = "o nome já existe - escolha outro";
            else
            {
                Session["NOME"] = Nome.Text;

                lista.Add(Nome.Text);
                lista.Sort();

                Application.Lock();
                Application["USRS"] = lista;
                Application.UnLock();

                Response.Redirect("~/Default.aspx");
            }
        }
    }
}