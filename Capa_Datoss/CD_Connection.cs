using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
//using System.Reflection.Metadata.Ecma335;

namespace Capa_Datos
{
    public class CD_Connection
    {
        // Cadena de conexión corregida
        private SqlConnection connection = new SqlConnection("Server=ALEJANDRO\\SQLEXPRESS; Database=store2; Integrated Security=True; TrustServerCertificate=True;");

        // Método para abrir la conexión
        public SqlConnection AbrirConexion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            Console.WriteLine("conexion establecida");
            return connection;
        }

        // Método para cerrar la conexióna
        public SqlConnection CerrarConexion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
            Console.WriteLine("conexion cerrada");
            return connection;
        }

    }
}