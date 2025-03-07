using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Capa_Datoss;

namespace Capa_Negocioo
{
    public class CN_Proveedores
    {

        // referencia a capa datos
        private CD_Proveedores proveedores = new CD_Proveedores();

        // metodo para mostrar proveedores
        public DataTable MostrarProveedores()
        {
            DataTable tabla = new DataTable();
            tabla = proveedores.MostrarProveedores();
            return tabla;
        }

        // agregar proveedor
        public void Add_Proveedor(string nombre, string apellido, string empresa, string telefono, string domicilio, Boolean status, int Id_Producto)
        {
            proveedores.Add_Proveedor(nombre, apellido, empresa, telefono, domicilio, status, Id_Producto);
        }

        // actualizar proveedor
        public void Update_Proveedor(string nombre, string apellido, string empresa, string telefono, string domicilio, Boolean status, int Id_Producto, int Id_Proveedor)
        {
            proveedores.Update_Proveedor(nombre, apellido, empresa, telefono, domicilio, status, Id_Producto, Id_Proveedor);
        }

        // eliminar proveedor
        public void Delete_Proveedor(Boolean status, int Id_Proveedor)
        {
            proveedores.Delete_Proveedor(status, Id_Proveedor);
        }

    }
}
