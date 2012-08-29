using System;
using System.Web.UI;

namespace _001_Application
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Application.Get("EMAIL").ToString();
        }
    }
}