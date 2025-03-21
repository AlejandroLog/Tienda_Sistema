using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Capa_Datos;
using System.Data.SqlTypes;

namespace Capa_Datoss
{
    public class CD_Venta
    {
        CD_Connection conection = new CD_Connection();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        // Método para insertar una venta
        public int Add_Venta(DateTime Fecha_Venta, int Cantidad_Producto, SqlMoney Total, int Id_Empleado)
        {
            int idVenta = 0;
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "SP_InsertarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fecha_Venta", Fecha_Venta);
            comando.Parameters.AddWithValue("@Cantidad_Productos", Cantidad_Producto);
            comando.Parameters.AddWithValue("@Total", Total);
            comando.Parameters.AddWithValue("@Id_Empleado", Id_Empleado);

            // Obtener el ID de la venta insertada
            object result = comando.ExecuteScalar();
            if (result != null)
            {
                idVenta = Convert.ToInt32(result);
            }

            comando.Parameters.Clear();
            conection.CerrarConexion();
            return idVenta;
        }


    }
}
