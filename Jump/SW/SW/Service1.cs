using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using System.Data.SqlClient;
using System.IO;

namespace SW
{
    public partial class SW : ServiceBase
    {

        Timer tiempo = null;
        SqlConnection con = new SqlConnection("Data Source=DANIEL;Initial Catalog=FERRETERIA1;Integrated Security=True");
        string strPathLog = @"C:\Users\jdbr\Desktop\registrooo.txt";
        
        
        
        
        public SW(){
           InitializeComponent();
           tiempo = new Timer(5000);
           tiempo.AutoReset = true;
           tiempo.Elapsed += new ElapsedEventHandler(ejecucion);
           
           
         }


        public void onDebug(){
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
           tiempo.Start();
          }


        public void ejecucion(object send, ElapsedEventArgs c)
        {
            TextWriter tw = new StreamWriter(strPathLog, true);
            tw.WriteLine(DateTime.Now.ToString()+ " Se inicio el servicio");
            con.Open();
            try
            {
                
                SqlCommand cmd2 = new SqlCommand("Select * From Persona;", con);
                DataTable result = new DataTable();
                result.Load(cmd2.ExecuteReader());
                con.Close();
                tw.WriteLine("in");
                 foreach (DataRow row in result.Rows)
                {
                    string linea = Convert.ToString(row["Nombre"]);
                    tw.WriteLine(linea);
                } 
            }
            catch
            {
                tw.WriteLine("no");
            }
           tw.Close();   
        }

        protected override void OnStop()
        {
            
            tiempo.Stop();
        }
    }
}
