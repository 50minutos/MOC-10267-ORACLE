using System;

namespace _006_Cache
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["NAO_EXPIRA"] == null)
                Server.Transfer("~/WebForm1.aspx");
            
            Label1.Text = Cache["NAO_EXPIRA"].ToString();

            if (Cache["EXPIRA_10_SEGUNDOS"] != null)
                Label2.Text = Cache["EXPIRA_10_SEGUNDOS"].ToString();

            if (Cache["EXPIRA_FINAL_DO_ANO"] != null)
                Label3.Text = Cache["EXPIRA_FINAL_DO_ANO"].ToString();
        }
    }
}