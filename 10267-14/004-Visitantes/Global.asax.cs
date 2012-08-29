using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.SessionState;

namespace _004_Visitantes
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["ONLINE"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            var c = WebConfigurationManager.OpenWebConfiguration("~/");

            if (WebConfigurationManager.AppSettings["QTD"] == null)
            {
                c.AppSettings.Settings.Add(new KeyValueConfigurationElement("QTD", "1"));
            }
            else
            {
                c.AppSettings.Settings["QTD"].Value = (Int32.Parse(c.AppSettings.Settings["QTD"].Value)+1).ToString(CultureInfo.InvariantCulture);
            }

            c.Save(ConfigurationSaveMode.Minimal);

            Application.Lock();
            Application["ONLINE"] = ((int)Application["ONLINE"]) + 1;
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["ONLINE"] = ((int)Application["ONLINE"]) - 1;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}