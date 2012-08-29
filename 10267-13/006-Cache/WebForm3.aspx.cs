using System;
using System.Drawing;
using System.IO;
using System.Web.Caching;
using System.Web.UI;

namespace _006_Cache
{
    public partial class WebForm3 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["TEXTO"] != null)
            {
                Label1.ForeColor = Color.Green;
                Label1.Text = "os dados vieram do CACHE";
            }
            else
            {
                Label1.ForeColor = Color.Red;
                Label1.Text = "os dados vieram do DISCO";
      
                var arq = new StreamReader(Server.MapPath("Arquivo.txt"));
                var txt = arq.ReadToEnd().Replace(Environment.NewLine, "<br/>");
                arq.Close();

                using (var cd = new CacheDependency(Server.MapPath("Arquivo.txt")))
                {
                    Cache.Insert("TEXTO", txt, cd);
                }
            }

            Label2.Text = Cache["TEXTO"].ToString();
        }
    }
}