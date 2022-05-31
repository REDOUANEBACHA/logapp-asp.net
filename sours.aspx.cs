using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace logine
{
    public partial class sours : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Redirect("cible.aspx?Login="+TextBox1.Text);
            
             Response.Cookies["login"].Value = TextBox1.Text;
            
             Response.Redirect("cible.aspx");
             
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Server.Transfer("cible.aspx");
            
        }
    }
}