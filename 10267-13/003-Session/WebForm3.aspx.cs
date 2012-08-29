using System;
using System.Web.UI;

namespace _003_Session
{
    public partial class WebForm3 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NOME"] == null)
                Response.Redirect("~/WebForm1.aspx");

            Label1.Text = Session["NOME"].ToString();
        }
    }
}