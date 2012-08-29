using System;
using System.Collections.Generic;

namespace _005_Chat
{
    public partial class Limpar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Equals("123"))
            {
                Session.Abandon();
                
                Application.Clear();

                Application.Lock();
                
                Application["MSGS"] = new List<Msg>();
                Application["USRS"] = new List<String>();
                
                Application.UnLock();
            }

            Response.Redirect("~/Default.aspx");
        }
    }
}