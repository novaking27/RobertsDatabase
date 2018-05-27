using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RobertsDatabase
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Model.User.HasUsers())
            {
                if (Model.User.login(txtUser.Text, txtPass.Text))
                {
                    Session["user"] = txtUser.Text;
                    Response.Redirect("~/pages/Landing.aspx");
                }
            }
            else
            {
                Model.User.CreateUser(txtUser.Text, txtPass.Text);
                Session["user"] = txtUser.Text;
                Response.Redirect("~/pages/Landing.aspx");
            }
        }
    }
}