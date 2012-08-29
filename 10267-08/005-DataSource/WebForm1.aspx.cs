using System;
using System.Web.UI.WebControls;

namespace _005_DataSource
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //todo: (005-DataSource) implementar update e delete

            #region solução de "implementar update e delete"
            /*
             * Abra o arquivo WebForm1.aspx
             * Clique na opção Configure Data Source do menu SqlDataSource Tasks do controle SqlDataSource (ID = OracleDataSource)
             * Verifique a string de conexão
             * Clique em [Next]
             * Desmarque o checkbox Yes, save this connection as
             * Clique em [Next]
             * Confira a origem dos dados: comando ou tabela
             * Clique em [Advanced]
             * Selecione Generate INSERT, UPDATE, and DELETE statements
             * Clique em [Ok]
             * Clique em [Next]
             * Clique em [Finish]
             * Altere os comandos gerados (ins, upd e del) para: (O "?" sai e entra o ":NOME_DO_PARAMETRO")
             * 
             *  DeleteCommand="DELETE FROM &quot;GENRE&quot; WHERE &quot;GENREID&quot; = :GENREID" 
             *  InsertCommand="INSERT INTO &quot;GENRE&quot; (&quot;GENREID&quot;, &quot;NAME&quot;) VALUES (:GENREID, :NAME)" 
             *  UpdateCommand="UPDATE &quot;GENRE&quot; SET &quot;NAME&quot; = :NAME WHERE &quot;GENREID&quot; = :GENREID">
             */
            #endregion
        }
    }
}