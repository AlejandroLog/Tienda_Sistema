using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Capa_Datos;

namespace Capa_Datoss
{
    public class CD_Empleados
    {
        private CD_Connection conection = new CD_Connection();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        //mostrar empleados en tabla
        public DataTable MostrarEmpleados()
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ShowEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conection.CerrarConexion();
            return tabla;
        }
        //agregar empleados sp
        public void Add_Empleado(string nombre, string apellido, DateTime fechaIngreso, string telefono, string domicilio, string rfc, string seguro_Social, Boolean status, int Id_Usuario)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "AddEmpleado";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@fecha_Ing", fechaIngreso);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@domicilio", domicilio);
            comando.Parameters.AddWithValue("@rfc", rfc);
            comando.Parameters.AddWithValue("@seguro_Social", seguro_Social);
            comando.Parameters.AddWithValue("@status", status);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }

        //actualizar emmpleados sp
        public void Update_Empleado(string nombre, string apellido, DateTime fechaIngreso, string telefono,
                            string domicilio, string rfc, string seguro_Social, Boolean status, int Id_Empleado, int Id_Usuario)
        { 
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "UpdateEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@fecha_Ing", fechaIngreso);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@domicilio", domicilio);
            comando.Parameters.AddWithValue("@rfc", rfc);
            comando.Parameters.AddWithValue("@seguro_Social", seguro_Social);
            comando.Parameters.AddWithValue("@status", status);
            comando.Parameters.AddWithValue("@Id_Empleado", Id_Empleado);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }
        //eliminar empleado sp
        public void Delete_Empleado(Boolean status, int Id_Empleado)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "DeleteEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@status", status);
            comando.Parameters.AddWithValue("@Id_Empleado", Id_Empleado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }
    }
}
