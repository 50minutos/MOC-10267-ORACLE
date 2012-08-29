using System;
using System.Configuration;
using System.Web.Configuration;
using System.Web.UI;

namespace _001_WebConfig
{
    public partial class WebForm2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            var c = WebConfigurationManager.OpenWebConfiguration("~/");

            if (WebConfigurationManager.AppSettings[TextBox1.Text] == null)
            {
                c.AppSettings.Settings.Add(new KeyValueConfigurationElement(TextBox1.Text, TextBox2.Text));
            }
            else
            {
                c.AppSettings.Settings[TextBox1.Text].Value = TextBox2.Text;
            }

            c.Save(ConfigurationSaveMode.Minimal);

            Response.Redirect("~/WebForm1.aspx");

            //todo: (001-WebConfig) Criar um site que apresente os seguintes indicadores: "visitantes online" e "visitantes desde a criação do site". Usar o web.config para persistir os dados - se necessário.
            //ver o projeto 004-Visitantes
        }
    }
}
