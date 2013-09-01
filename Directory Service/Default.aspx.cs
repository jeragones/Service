using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Directory_Service.Class;
using System.DirectoryServices;

namespace Directory_Service
{
    public partial class _Default : System.Web.UI.Page
    {

        clsDataBase insBD = new clsDataBase();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtUsuario.Text.Equals("") & !txtPass.Text.Equals(""))
            {
                

                Response.Write("<script type='text/javascript'>window.open('GUI/frmInicio.aspx','_parent');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> c = new List<string> {"usuario","nombre","contraseña","grupo"};
            List<string> d = new List<string> { "jdaniel", "Daniel Berrocal", "Jda.123", "5" };
            insBD.insertar(c, d, "Usuario");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<string> c = new List<string> { "nombre", "contraseña" };
            List<string> d = new List<string> { "Daniel Berrocal Ramirez", "Jda.123999" };
            string[] s = {"usuario","jdaniel"};
            insBD.modificar(c, d, s,"Usuario");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            insBD.eliminar("usuario","jdaniel","Usuario");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            List<string> c = new List<string> { "nombre", "contraseña" };
            string[] s = { "usuario", "jdaniel" };
            insBD.consultar(c,s,"Usuario");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            List<string> c = new List<string> { "usuario","nombre", "contraseña", "grupo" };
            string[] s = { };
            insBD.consultar(c, s, "Usuario");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            CreateUserAccount("LDAP:/" + "/host:172.16.0.1", "mijo", "Menoriti.5698");
        }

        public string CreateUserAccount(string ldapPath, string userName, string userPassword)
        {
            try
            {
                string oGUID = string.Empty;
                string connectionPrefix = ldapPath;
                DirectoryEntry dirEntry = new DirectoryEntry(connectionPrefix);
                DirectoryEntry newUser = dirEntry.Children.Add
                    ("CN=" + userName, "user");
                newUser.Properties["samAccountName"].Value = userName;
                newUser.CommitChanges();
                oGUID = newUser.Guid.ToString();

                newUser.Invoke("SetPassword", new object[] { userPassword });
                newUser.CommitChanges();
                dirEntry.Close();
                newUser.Close();
            }
            catch (System.DirectoryServices.DirectoryServicesCOMException E)
            {
                //DoSomethingwith --> E.Message.ToString();

            }
            return "";
        }
    }
}
