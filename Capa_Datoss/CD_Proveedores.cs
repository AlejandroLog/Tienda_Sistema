using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Capa_Datos;

namespace Capa_Datoss
{
    public class CD_Proveedores
    {

        private CD_Connection conection = new CD_Connection();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarProveedores()
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ShowProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conection.CerrarConexion();
            return tabla;
        }

        public void Add_Proveedor(string nombre, string apellido, string empresa, string telefono, string domicilio, Boolean status, int Id_Producto)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "AddProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@empresa", empresa);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@domicilio", domicilio);
            comando.Parameters.AddWithValue("@status", status);
            comando.Parameters.AddWithValue("@Id_Producto", Id_Producto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }

      


        public void Update_Proveedor(string nombre, string apellido, string empresa, string telefono, string domicilio, Boolean status, int Id_Producto, int Id_Proveedor)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "UpdateProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@empresa", empresa);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@domicilio", domicilio);
            comando.Parameters.AddWithValue("@status", status);
            comando.Parameters.AddWithValue("@Id_Producto", Id_Producto);
            comando.Parameters.AddWithValue("@Id_Proveedor", Id_Proveedor);  // ¡Este faltaba!
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }



        public void Delete_Proveedor(Boolean status, int Id_Proveedor)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "DeleteProveedor"; 
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@status", status);
            comando.Parameters.AddWithValue("@Id_Proveedor", Id_Proveedor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }
    }
}
