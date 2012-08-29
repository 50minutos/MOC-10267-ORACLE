using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace _005_Chat
{
    public partial class Default : Page
    {
        private String _para = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NOME"] == null)
                Response.Redirect("~/Login.aspx");

            if (DropDownList1.SelectedIndex != -1)
                _para = DropDownList1.SelectedItem.ToString();

            var lista = (List<String>)Application["USRS"];

            if (!lista.Contains("(todos)"))
                lista.Add("(todos)");

            lista.Sort();

            DropDownList1.DataSource = lista;
            DropDownList1.DataBind();

            if (!IsPostBack)
                AtualizarGrid(false);
        }

        private void AtualizarGrid(bool adicionar)
        {
            var lista = (List<Msg>)Application["MSGS"];

            if (adicionar)
            {
                lista.Add(new Msg
                              {
                                  Data = DateTime.Now,
                                  De = Session["NOME"].ToString(),
                                  Para = _para ?? "(todos)",
                                  Texto = Mensagem.Text
                              });

                Application["MSGS"] = lista;
            }

            var remover = lista.Where(item => !item.De.Equals(Session["NOME"].ToString())
                && !item.Para.Equals(Session["NOME"].ToString()) 
                && !item.Para.Equals("(todos)")).ToList();

            foreach (var item in remover)
                lista.Remove(item);

            Mensagens.DataSource = lista;
            Mensagens.DataBind();
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            if (Mensagem.Text != String.Empty)
                AtualizarGrid(true);
        }
    }
}
