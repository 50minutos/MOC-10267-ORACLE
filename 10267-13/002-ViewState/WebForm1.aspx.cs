using System;
using System.Web.UI;

namespace _002_ViewState
{
    public partial class WebForm1 : Page
    {
        protected void Button1Click(object sender, EventArgs e)
        {
            ViewState["NOME_SENHA"] = String.Format("{0}, sua senha é {1}", 
                TextBox1.Text, TextBox2.Text);
            Label1.Text = String.Empty;
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            if (ViewState["NOME_SENHA"] != null)
                Label1.Text = ViewState["NOME_SENHA"].ToString();
        }

        protected void Button3Click(object sender, EventArgs e)
        {
            Context.Items["Nome"] = TextBox1.Text;
            Context.Items["Senha"] = TextBox2.Text;

            Server.Transfer("~/WebForm2.aspx");
        }

        protected void Button4Click(object sender, EventArgs e)
        {
            Session["Nome"] = TextBox1.Text;
            Session["Senha"] = TextBox2.Text;

            Server.Transfer("~/WebForm3.aspx");
        }
    }
}