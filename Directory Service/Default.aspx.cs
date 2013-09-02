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
            //CreateUserAccount("LDAP://host:172.16.0.1", "mijo", "Menoriti.5698");
            //CreateUserAccount("LDAP://CN=user, OU=USERS, DC=operativos, DC=service", "mijoto", "Jera.5698");
            //CreateUserAccount("LDAP://DC=operativos, DC=service", "mijoto", "Jera.5698");

            CreateUserAccount("LDAP://172.16.0.1/CN=Users;DC=operativos.service", @"operativos.service\jeragones", "Jera.123");
            
            //"LDAP://192.168.1.1/CN=Users;DC=Yourdomain";
            //consultar();
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

        // *****************************************************************************************

        public void consultar() {
            DirectoryEntry entry = new DirectoryEntry("LDAP://operativos.service");
            
            DirectorySearcher Dsearch = new DirectorySearcher(entry);

            String Name = "jeragones@operativos.service";
            Dsearch.Filter = "(&(objectClass=user)(l=" + Name + "))";

            // ----------------------------------------

            // get all entries from the active directory.
            // Last Name, name, initial, homepostaladdress, title, company etc..
            foreach (SearchResult sResultSet in Dsearch.FindAll())
            {

                // Login Name
                Console.WriteLine(GetProperty(sResultSet, "cn"));
                // First Name
                Console.WriteLine(GetProperty(sResultSet, "givenName"));
                // Middle Initials
                Console.Write(GetProperty(sResultSet, "initials"));
                // Last Name
                Console.Write(GetProperty(sResultSet, "sn"));
                // Address
                string tempAddress = GetProperty(sResultSet, "homePostalAddress");

                if (tempAddress != string.Empty)
                {
                    string[] addressArray = tempAddress.Split(';');
                    string taddr1, taddr2;
                    taddr1 = addressArray[0];
                    Console.Write(taddr1);
                    taddr2 = addressArray[1];
                    Console.Write(taddr2);
                }
                // title
                Console.Write(GetProperty(sResultSet, "title"));
                // company
                Console.Write(GetProperty(sResultSet, "company"));
                //state
                Console.Write(GetProperty(sResultSet, "st"));
                //city
                Console.Write(GetProperty(sResultSet, "l"));
                //country
                Console.Write(GetProperty(sResultSet, "co"));
                //postal code
                Console.Write(GetProperty(sResultSet, "postalCode"));
                // telephonenumber
                Console.Write(GetProperty(sResultSet, "telephoneNumber"));
                //extention
                Console.Write(GetProperty(sResultSet, "otherTelephone"));
                //fax
                Console.Write(GetProperty(sResultSet, "facsimileTelephoneNumber"));

                // email address
                Console.Write(GetProperty(sResultSet, "mail"));
                // Challenge Question
                Console.Write(GetProperty(sResultSet, "extensionAttribute1"));
                // Challenge Response
                Console.Write(GetProperty(sResultSet, "extensionAttribute2"));
                //Member Company
                Console.Write(GetProperty(sResultSet, "extensionAttribute3"));
                // Company Relation ship Exits
                Console.Write(GetProperty(sResultSet, "extensionAttribute4"));
                //status
                Console.Write(GetProperty(sResultSet, "extensionAttribute5"));
                // Assigned Sales Person
                Console.Write(GetProperty(sResultSet, "extensionAttribute6"));
                // Accept T and C
                Console.Write(GetProperty(sResultSet, "extensionAttribute7"));
                // jobs
                Console.Write(GetProperty(sResultSet, "extensionAttribute8"));
                String tEamil = GetProperty(sResultSet, "extensionAttribute9");

                // email over night
                if (tEamil != string.Empty)
                {
                    string em1, em2, em3;
                    string[] emailArray = tEamil.Split(';');
                    em1 = emailArray[0];
                    em2 = emailArray[1];
                    em3 = emailArray[2];
                    Console.Write(em1 + em2 + em3);

                }
                // email daily emerging market
                Console.Write(GetProperty(sResultSet, "extensionAttribute10"));
                // email daily corporate market
                Console.Write(GetProperty(sResultSet, "extensionAttribute11"));
                // AssetMgt Range
                Console.Write(GetProperty(sResultSet, "extensionAttribute12"));
                // date of account created
                Console.Write(GetProperty(sResultSet, "whenCreated"));
                // date of account changed
                Console.Write(GetProperty(sResultSet, "whenChanged"));
            }



        }

        public static string GetProperty(SearchResult searchResult, 
 string PropertyName)
  {
   if(searchResult.Properties.Contains(PropertyName))
   {
    return searchResult.Properties[PropertyName][0].ToString() ;
   }
   else
   {
    return string.Empty;
   }
  }


        // *******************************************************************************************
    }
}
