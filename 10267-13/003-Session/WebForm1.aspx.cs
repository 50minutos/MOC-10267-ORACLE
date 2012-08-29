using System;
using System.Web.UI;

namespace _003_Session
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["NOME"] != null)
                TextBox1.Text = Session["NOME"].ToString();
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            Session.Add("NOME", TextBox1.Text);
            Response.Redirect("~/WebForm2.aspx");
        }

        //todo: (003-Session) Criar um chat usando Application e Session
    }
}