using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Capa_Datos;
using Capa_Datoss;

namespace Capa_Negocioo
{
    public class CN_Empleados
    {

        // ✅ Correcto, referencia a la capa de datos

        private CD_Empleados empleados = new CD_Empleados();

        public DataTable MostrarEmpleados()
        {
            DataTable tabla = new DataTable();
            tabla = empleados.MostrarEmpleados();
            return tabla;
        }

        public void Add_Empleado(string nombre, string apellido, DateTime fecha_Ing, string telefono, string domicilio, string rfc, string seguro_Social, Boolean status, int Id_Usuario)
        {
            empleados.Add_Empleado(nombre, apellido, fecha_Ing, telefono, domicilio, rfc, seguro_Social, status, Id_Usuario);
        }

        public void Update_Empleado(string nombre, string apellido, DateTime fecha_Ing, string telefono, string domicilio, string rfc, string seguro_Social, Boolean status, int Id_Empleado, int Id_Usuario)
        {
            empleados.Update_Empleado(nombre, apellido, fecha_Ing, telefono, domicilio, rfc, seguro_Social, status, Id_Empleado, Id_Usuario);
        }

        public void Delete_Empleado(Boolean status, int Id_Empleado)
        {
            empleados.Delete_Empleado(status, Id_Empleado);
        }
    }
}
