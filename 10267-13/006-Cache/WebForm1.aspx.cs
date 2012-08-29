using System;
using swc = System.Web.Caching;

namespace _006_Cache
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["NAO_EXPIRA"] == null)
                Cache["NAO_EXPIRA"] = "NUNCA VAI EXPIRAR";

            if (Cache["EXPIRA_10_SEGUNDOS"] == null)
                Cache.Insert("EXPIRA_10_SEGUNDOS", 
                    "EXPIRA APÓS 10 SEGUNDOS SEM USO", 
                    null, 
                    swc.Cache.NoAbsoluteExpiration, 
                    new TimeSpan(0, 0, 10));

            if (Cache["EXPIRA_FINAL_DO_ANO"] == null)
                Cache.Insert("EXPIRA_FINAL_DO_ANO", 
                    "EXPIRA EM 31/12/2012 23:59:59", 
                    null, 
                    new DateTime(2012, 12, 31, 23, 59, 59), 
                    swc.Cache.NoSlidingExpiration);

            Response.Redirect("~/WebForm2.aspx");
        }
    }
}