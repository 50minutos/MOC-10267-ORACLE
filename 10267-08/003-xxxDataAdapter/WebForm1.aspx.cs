using System;
using System.Data;
using System.Globalization;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;

//Add Reference:
//Oracle.DataAccess

namespace _003_xxxDataAdapter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //todo: (003-xxxDataAdapter) implementar paginação e ordenação para o gridview

            #region solução de "implementar paginação e ordenação para o gridview"

            GridView1.AllowPaging = GridView1.AllowSorting = true;
            GridView1.PageIndexChanging += GridView1PageIndexChanging;
            GridView1.Sorting += GridView1Sorting;

            ViewState["SORT_DIRECTION"] = ViewState["SORT_DIRECTION"] ?? " ASC";
            ViewState["SORT_EXPRESSION"] = ViewState["SORT_EXPRESSION"] ?? "GENREID";

            #endregion

            var da = new OracleDataAdapter("SELECT * FROM GENRE",
                @"DATA SOURCE=127.0.0.1/ORCL;USER ID=chinook;PASSWORD=p4ssw0rd;");

            var ds = new DataSet();

            da.Fill(ds);

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        #region solução de "implementar paginação e ordenação para o gridview"

        void GridView1Sorting(object sender, GridViewSortEventArgs e)
        {
            Ordenar(e, true);
        }

        void GridView1PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            Ordenar(new GridViewSortEventArgs(ViewState["SORT_EXPRESSION"].ToString(), SortDirection.Ascending), false);
        }

        private void Ordenar(GridViewSortEventArgs e, bool b)
        {
            var dt = GridView1.DataSource as DataTable;

            if (dt == null) return;

            if (b)
                ViewState["SORT_DIRECTION"] = ViewState["SORT_DIRECTION"] != null && ViewState["SORT_DIRECTION"].Equals(" DESC")
                                                  ? " ASC"
                                                  : " DESC";
            ViewState["SORT_EXPRESSION"] = e.SortExpression;

            var sort = ViewState["SORT_EXPRESSION"].ToString() + ViewState["SORT_DIRECTION"];

            dt.DefaultView.Sort = sort;
            GridView1.DataSource = dt;

            GridView1.DataBind();
        }

        #endregion
    }
}