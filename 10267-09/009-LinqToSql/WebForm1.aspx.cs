using System;
using System.Diagnostics;
using System.Linq;
using System.Web.UI;

namespace _009_LinqToSql
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var dc = new ModelDataContext())
            {
                dc.Log = Console.Out;

                var x = dc.GetTable<Cliente>();

                GridView1.DataSource = x.ToList();
                GridView1.DataBind();

                var y = from c in x
                        select c.Nome;

                var z = from n in y
                        where n.StartsWith("A")
                        select n;

                foreach (var item in z)
                {
                    Debug.Print(item);
                }
            }
        }
    }
}