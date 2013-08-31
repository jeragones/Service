using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Directory_Service.GUI.Form
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtUsuario.Text.Equals("") & !txtPass.Text.Equals("")) 
            {
                Response.Write("<script type='text/javascript'>window.open('frmGrupo.aspx','_blank');</script>");
            }
        }
    }
}