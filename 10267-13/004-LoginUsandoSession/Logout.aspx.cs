using System;

namespace _004_LoginUsandoSession
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/WebForm1.aspx");
        }
    }
}