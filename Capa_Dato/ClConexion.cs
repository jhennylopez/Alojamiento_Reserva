using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Dato
{
    public class ClConexion
    {
        public class cl_conexion
        {   
            public string cadena = "Data Source=DESKTOP-0F9J2A1\\SQLEXPRESS;Initial Catalog=SistemaReservasBD;Integrated Security=True";
            public SqlConnection conexion = new SqlConnection();
            public cl_conexion()
            
            { 
                conexion.ConnectionString = cadena;


            }

            public void abrir()
            {
                try 
                {
                    conexion.Open();
                    Console.WriteLine("Conexión Correcta");
                } 
                catch(Exception ex) 
                {
                    Console.WriteLine("Error: ", ex);
                }
            }

            public void cerrar()
            {
                conexion.Close();

            }
                
        }
    }
}
