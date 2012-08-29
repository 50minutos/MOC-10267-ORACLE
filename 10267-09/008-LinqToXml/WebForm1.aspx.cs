using System;
using System.Web.UI;

namespace _008_LinqToXml
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1Click(object sender, EventArgs e)
        {
            BLL.Usuario.Insert(new Model.Usuario
            {
                User = TextBox1.Text,
                Password = TextBox2.Text
            });

            MultiView1.ActiveViewIndex = 1;
        }
    }
}