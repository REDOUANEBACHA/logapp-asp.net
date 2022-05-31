using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace logine
{
    public partial class cible : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //Label2.Text = Request.QueryString["Login"];
           //Label2.Text = Request.Form["TextBox1"];
            Label2.Text = Request.Cookies["login"].Value;
        }
    }
}