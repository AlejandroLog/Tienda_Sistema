using System;
using System.Collections.Generic;
using System.Text;
using Capa_Datoss;

namespace Capa_Negocioo
{
    public class CN_DetalleVenta
    {
        private CD_DetalleVenta detalleVenta = new CD_DetalleVenta();

        public void Add_Detalle_Venta(int Cantidad, int Id_Producto, int Id_Venta)
        {
          detalleVenta.Add_Detalle_Venta(Cantidad, Id_Producto, Id_Venta);
        }
    }
}
