using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Caching;

namespace _004_LoginUsandoSession
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1Click(object sender, EventArgs e)
        {
            LerXML("App_Data/Usuarios.xml");

            if (!ValidarUsuario()) return;
            
            MultiView1.ActiveViewIndex = 1;

            Session["USUARIO"] = new Usuario(TextBox1.Text, TextBox2.Text);
        }

        private bool ValidarUsuario()
        {
            var lista = (List<Usuario>)Cache["USUARIOS"];

            return lista.Contains(new Usuario(TextBox1.Text, TextBox2.Text));
        }

        private void LerXML(string nomeArquivo)
        {
            if (Cache["USUARIOS"] != null) return;
            
            var nome = Server.MapPath(nomeArquivo);

            var ds = new DataSet();
            ds.ReadXml(nome);

            var lista = (from DataRow linha in ds.Tables[0].Rows select new Usuario(linha["id"].ToString(), linha["senha"].ToString())).ToList();

            var cd = new CacheDependency(nome);

            Cache.Insert("USUARIOS", lista, cd);
        }
    }
}