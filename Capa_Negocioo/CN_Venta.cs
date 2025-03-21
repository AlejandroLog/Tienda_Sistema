using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using Capa_Datoss;

namespace Capa_Negocioo
{
    public class CN_Venta
    {
        // Instanciar la clase CD_Venta
        private CD_Venta venta = new CD_Venta();

        // Método para insertar una venta
        public int Add_Venta(DateTime Fecha_Venta, int Cantidad_Producto, SqlMoney Total, int Id_Empleado)
        {
            return venta.Add_Venta(Fecha_Venta, Cantidad_Producto, Total, Id_Empleado);
        }


    }
}
