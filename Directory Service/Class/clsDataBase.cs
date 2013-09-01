using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace Directory_Service.Class
{
    
    public class clsDataBase
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\DataBase.mdf;Integrated Security=True;User Instance=True");

        /*
         * 
         */
        public void insertar(List<string> columnas, List<string> datos, string tabla)
        {   
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + tabla + " (" + cadena(columnas, false) + ") VALUES (" + cadena(datos, true) + ")";
            cmd.Connection = connection;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /*
         * 
         */
        public void modificar(List<string> columnas, List<string> datos, string[] condicion, string tabla)
        {
            string dato;
            if (numero(condicion[1]))
                dato = condicion[1];
            else
                dato = "'" + condicion[1] + "'";
            char[] separador = { ',' };
            string update = cadena(Fragmentar(cadena(columnas, false), separador), Fragmentar(cadena(datos, true), separador));
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE " + tabla + " SET " + update + " WHERE " + condicion[0] + " = " + dato;
            cmd.Connection = connection;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /*
         * 
         */
        public void eliminar(string column, string data, string tabla)
        {
            string dato;
            if(numero(data))
                dato = data;
            else
                dato = "'"+data+"'";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM " + tabla + " WHERE "+column+" = "+dato;
            cmd.Connection = connection;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /*
         * 
         */
        public ArrayList consultar(List<string> columnas, string[] condicion, string tabla)
        {
            ArrayList lista = new ArrayList();
            string query, dato;

            if (condicion.Length == 0)
            {
                query = "SELECT " + cadena(columnas, false) + " FROM " + tabla;
            }
            else
            {
                if (numero(condicion[1]))
                    dato = condicion[1];
                else
                    dato = "'"+condicion[1]+"'";
                query = "SELECT " + cadena(columnas, false) + " FROM " + tabla +" WHERE " + condicion[0] + " = " + dato;
            }
            
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable result = new DataTable();
            result.Load(cmd.ExecuteReader());
            connection.Close();

            foreach (DataRow row in result.Rows)
            {
                List<string> list = new List<string>();
                for (int i = 0; i < columnas.Count; i++)
                {
                    list.Add(row[columnas[i]].ToString());
                }
                list.Reverse();
                lista.Add(list);
            }
            return lista;
        }

        /*
         * 
         */
        protected string cadena(List<string> lista, bool tmp) 
        {
            string list="";
            for (int i = 0; i < lista.Count; i++)
            {
                if (i == 0)
                    list += tipo(lista[i], tmp);
                else
                    list += "," + tipo(lista[i], tmp);
            }
            return list;
        }

        /*
         * 
         */
        protected string cadena(string[] columnas, string[] datos)
        {
            string cadena = "";
            for (int i = 0; i < columnas.Length; i++)
            {
                if(i==0)
                    cadena = columnas[i] + "=" + datos[i];
                else
                    cadena += ", " + columnas[i] + "=" + datos[i];
            }
            return cadena;
        }

        /*
         * 
         */
        protected string tipo(string dato, bool tmp)
        {
            if (numero(dato))
                return dato;
            else
            {
                if(tmp)
                    return "'" + dato + "'";
                else
                    return dato; 
            }
        }

        /*
         * 
         */
        protected Boolean numero(string num)
        {
            int numero = 0;
            return (int.TryParse(num, out numero));
        }

        /*
         * 
         */
        protected String[] Fragmentar(String cadena, char[] separador)
        {
            String[] vector = cadena.Split(separador);
            return vector;
        }
    }
}