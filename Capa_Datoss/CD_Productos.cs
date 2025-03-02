using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Capa_Datos;
using System.Data.SqlTypes;

namespace Capa_Datoss
{
    public class CD_Productos
    {

        private CD_Connection conection = new CD_Connection();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable MostrarProductos()
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ShowProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conection.CerrarConexion();
            return tabla;
        }



        public void Add_Producto(string nombre, string descripcion, SqlMoney precio, SqlMoney costo, string categoria, Boolean status)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "AddProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@costo", costo);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@status", status);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }


        public void Update_Producto(string nombre, string descripcion, SqlMoney precio, SqlMoney costo, string categoria, Boolean status, int Id_Producto)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "UpdateProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@costo", costo);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@status", status);
            comando.Parameters.AddWithValue("@Id_Producto", Id_Producto);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }

        public void Delete_Producto(Boolean status, int Id_Producto)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "DeleteProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@status", status);
            comando.Parameters.AddWithValue("@Id_Producto", Id_Producto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }
    }
}
