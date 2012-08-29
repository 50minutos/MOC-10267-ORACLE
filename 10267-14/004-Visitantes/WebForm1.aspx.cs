using System;
using System.Web.Configuration;
using System.Web.UI;

namespace _004_Visitantes
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = WebConfigurationManager.OpenWebConfiguration("~/").AppSettings.Settings["QTD"].Value;

            Label2.Text = Application["ONLINE"].ToString();
        }
    }
}