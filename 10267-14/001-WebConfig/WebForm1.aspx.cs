using System;
using System.Web.Configuration;
using System.Web.UI;

namespace _001_WebConfig
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = WebConfigurationManager.AppSettings["EMPRESA"];
            Label2.Text = WebConfigurationManager.AppSettings["EMAIL"];
            Label3.Text = WebConfigurationManager.ConnectionStrings["OracleProd"].ConnectionString;
            Label4.Text = WebConfigurationManager.ConnectionStrings["OracleDev"].ConnectionString;
            Label5.Text = WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        
            //todo: (001-WebConfig) implementar site que suporte 3 strings de conexão: desenvolvimento, homologacao e producao
            //Ver projeto 005-ConnectionStrings
        }
    }
}