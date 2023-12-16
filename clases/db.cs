using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MECANOGRAFIA.clases
{
    internal class db:conexion
    {
        clases.helpers h = new clases.helpers();
        string query;
        SqlCommand com;
        SqlDataReader reader;
        DataTable datos;

        public Int32 guardar(string tabla,string campos,string valores,int debug = 0)
        {
            Int32 res = 0;
            query = "INSERT INTO " + tabla + " (" + campos + ") VALUES (" + valores + ")";

            if (debug > 0)
            {
                Clipboard.SetText(query);
                MessageBox.Show(query);
            }

            try
            {
                com = new SqlCommand(query,SQLCon);
                SQLCon.Open();
                res = com.ExecuteNonQuery();
                SQLCon.Close();
                com.Dispose();
            }
            catch (SqlException er)
            {
                h.Warning(er.Message);
            }
            finally
            {
                Terminarconexion();
            }
            
            return res;
        }

        public Int32 actualizar(string tabla,string campos,string condicion = "",int debug = 0)
        {
            int res = 0;

            if (condicion == "")
            {
                query = "UPDATE " + tabla + " SET " + campos;
            }
            else
            {
                query = "UPDATE " + tabla + " SET " + campos + " WHERE " + condicion;
            }

            if (debug > 0)
            {
                Clipboard.SetText(query);
                MessageBox.Show(query);
            }

            try
            {
                com = new SqlCommand(query, SQLCon);
                Abrirconexion();
                res = com.ExecuteNonQuery();
                Cerrarconexion();
                com.Dispose();
            }
            catch (SqlException e)
            {
                h.Warning(e.Message);
            }
            finally
            {
                Terminarconexion();
            }

            return res;
        }

        public DataTable recuperar(string tabla,string campos,string condicion ="",int debug = 0)
        {
            datos = new DataTable();

            if (condicion == "")
            {
                query = "SELECT " + campos + " FROM " + tabla ;
            }
            else
            {
                query = "SELECT " + campos + " FROM " + tabla + " WHERE " + condicion;
            }

            if (debug > 0)
            {
                Clipboard.SetText(query);
                MessageBox.Show(query);
            }

            try
            {
                com = new SqlCommand(query,SQLCon);
                SQLCon.Open();
                reader = com.ExecuteReader();
                datos.Load(reader);

                com.Dispose();
                reader.Close();
                SQLCon.Close();
            }
            catch (SqlException er)
            {
                h.Warning(er.Message);
            }
            finally
            {
                Terminarconexion();
            }

            return datos;
        }

    }
}
