using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;

//Add Reference:
//Oracle.DataAccess

namespace _004_xxxDataReader
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //todo: (004-xxxDataReader) remover o botão, mantendo a funcionalidade da página

            #region solução de "remover o botão, mantendo a funcionalidade da página"
            //ver o arquivo WebForm1.aspx
            #endregion

            DropDownList1.SelectedIndexChanged += DropDownList1SelectedIndexChanged;

            if (IsPostBack) return;

            DropDownList1.Items.Clear();

            DropDownList1.Items.Add(new ListItem("(escolha uma opção)", "-1"));

            using (var c = new OracleConnection(@"DATA SOURCE=127.0.0.1/ORCL;USER ID=chinook;PASSWORD=p4ssw0rd;"))
            {
                var k = new OracleCommand("SELECT * FROM GENRE", c);

                c.Open();

                var dr = k.ExecuteReader();

                while (dr.Read())
                {
                    DropDownList1.Items.Add(new ListItem(dr[1].ToString(), dr[0].ToString()));
                }

                c.Close();

                DropDownList1.DataBind();
            }
        }

        void DropDownList1SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue;
        }
    }
}