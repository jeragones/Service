using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Directory_Service
{
    public partial class frmInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!txtRegUsuario.Text.Equals("") & !txtRegNombre.Text.Equals("") &
               !txtRegPass.Text.Equals("") & (txtRegPass.Text.Equals(txtRepPass.Text))) 
            {
                // insertar en la BD
            }
        }
    }
}
