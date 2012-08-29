using System;
using System.Web.UI;

namespace _002_ViewState
{
    public partial class WebForm2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.Items["Nome"]==null) Server.Transfer("~/WebForm1.aspx");

            Label1.Text = Context.Items["Nome"].ToString();
            Label2.Text = Context.Items["Senha"].ToString();
        }
    }
}