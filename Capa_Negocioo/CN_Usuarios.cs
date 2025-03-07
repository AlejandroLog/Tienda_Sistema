using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Capa_Datos;

namespace Capa_Negocioo
{
    public class CN_Usuarios
    {

        // referencia a capa datos
        private CD_Usuarios usuarios = new CD_Usuarios();


        // metodo para mostrar usuarios
        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = usuarios.MostrarUsuarios();
            return tabla;
        }


        // agregar usuario
        public void Add_Usuario(string usuario, string password, Boolean status)
        {
            usuarios.Add_Usuario(usuario, password, status);
        }


        // actualizar usuario
        public void Update_Usuario(string usuario, string password, Boolean status, int Id_Usuario)
        {
            usuarios.Update_Usuario(usuario, password, status, Id_Usuario);
        }

        // eliminar usuario
        public void Delete_Usuario( Boolean status, int Id_Usuario)
        {
            usuarios.Delete_Usuario(status, Id_Usuario);
        }

        // validar usuario
        public bool ValidarUsuario(string usuario, string password)
        {
            return usuarios.ValidarUsuario(usuario, password);
        }

    }
}
