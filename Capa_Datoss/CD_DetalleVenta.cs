using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Text;
using Capa_Datos;

namespace Capa_Datoss
{
    public class CD_DetalleVenta
    {
        // Instanciar la clase CD_Connection
        CD_Connection conection = new CD_Connection();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        // Método para insertar un detalle de venta
        public void Add_Detalle_Venta(int Cantidad, int Id_Producto, int Id_Venta)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "SP_InsertarDetalleVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Id_Producto", Id_Producto);
            comando.Parameters.AddWithValue("@Id_Venta", Id_Venta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }
    }
}
