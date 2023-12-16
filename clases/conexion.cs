using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Net;

namespace MECANOGRAFIA.clases
{
    internal class conexion:ENV
    {
        // CADENA DE CONEXION PARA CONEXIONES LOCALES //static string cadena_de_conexion = $"Server=" + ENV.SERVER + ";Database=" + ENV.DB + ";User Id=" + ENV.USER + ";Password=" + ENV.PWD + ";TrustServerCertificate=True";
        static string cadena_conexion = "Data Source=" + Dns.GetHostName() + "\\LOCAL;Initial Catalog=MECANOGRAFIAA;Integrated Security=True";
        public static SqlConnection SQLCon = new SqlConnection(cadena_conexion);

        public void Abrirconexion()
        {
            try
            {
                SQLCon.Open();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void Cerrarconexion()
        {
            try
            {
                SQLCon.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void Terminarconexion()
        {
            if (SQLCon.State == ConnectionState.Open)
            {
                SQLCon.Close();
            }
        }
    }
}
