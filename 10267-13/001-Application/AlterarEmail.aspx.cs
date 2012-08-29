using System;

namespace _001_Application
{
    public partial class AlterarEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                TextBox1.Text = Application["EMAIL"].ToString();
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            Application["EMAIL"] = TextBox1.Text;
            Response.Redirect("~/WebForm1.aspx");
        }
    }
}