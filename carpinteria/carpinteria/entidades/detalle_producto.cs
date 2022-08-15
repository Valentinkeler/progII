using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpinteria
{
    internal class detalle_producto
    {
        public producto Producto { get; set; }
        public int Cantidad { get; set; }
        public detalle_producto(producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public double CalcularSubTotal()
        {
            return Producto.Precio * Cantidad;
        }

    }
}
