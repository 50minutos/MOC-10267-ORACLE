using System;

namespace _002_ViewState
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Nome"] == null) 
                Server.Transfer("~/WebForm1.aspx");

            Label1.Text = Session["Nome"].ToString();
            Label2.Text = Session["Senha"].ToString();
        }
    }
}