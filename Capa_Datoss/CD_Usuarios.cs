using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Usuarios
    {
        private CD_Connection conection = new CD_Connection();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarUsuarios()
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ShowUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conection.CerrarConexion();
            return tabla;
        }

        //agregar usuarios sp
        public void Add_Usuario(string usuario, string password, Boolean status)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "AddUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@status", status);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }

        //actualizar usuario sp
        public void Update_Usuario(string usuario, string password, Boolean status, int Id_Usuario)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "UpdateUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@status", status);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }

        //eliminar usuario sp
        public void Delete_Usuario(Boolean status, int Id_Usuario)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "DeleteUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@status", status);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }

        //validar usuario sp
        public bool ValidarUsuario(string usuario, string password)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ValidarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@password", password);

            SqlDataReader leer = comando.ExecuteReader();
            bool esValido = leer.HasRows;

            comando.Parameters.Clear();
            conection.CerrarConexion();

            return esValido;
        }
    }
}