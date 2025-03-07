using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Text;
using Capa_Datos;
using Capa_Datoss;

namespace Capa_Negocioo
{

    public class CN_Productos
    {

        //referencia a capa datos
        private CD_Productos productos = new CD_Productos();

        // metodo para mostrar productos
        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = productos.MostrarProductos();
            return tabla;
        }


        //agregar producto
        public void Add_Producto(string nombre, string descripcion, SqlMoney precio, SqlMoney costo, string categoria, Boolean status)
        {
            productos.Add_Producto(nombre, descripcion, precio, costo, categoria, status);
        }

        //actualizar producto
        public void Update_Producto(string nombre, string descripcion, SqlMoney precio, SqlMoney costo, string categoria, Boolean status, int Id_Producto)
        {
            productos.Update_Producto(nombre, descripcion, precio, costo, categoria, status, Id_Producto);
        }


        //eliminar producto
        public void Delete_Producto(Boolean status, int Id_Producto)
        {
            productos.Delete_Producto(status, Id_Producto);
        }
    }
}
