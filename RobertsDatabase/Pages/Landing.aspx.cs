using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RobertsDatabase
{
    public partial class Landing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String search = txtSearch.Text.ToString();
            gvList.DataSource = Model.DatabaseData.SelectAll();
            gvList.DataBind();
        }

        protected void gdvAll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var list = Model.DatabaseData.Filter(txtSearch.Text);
            gvList.DataSource = list;
            gvList.DataBind();

        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/pages/Default.aspx");
        }
    }
}