using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpinteria
{
    class DetallePresupuesto
    {
        public producto producto { get; set; }
        public int cantidad { get; set; }

        public DetallePresupuesto(producto producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }
        public double CalcularSubtotal()
        {
            return producto.Precio * cantidad;
        }
    }
}
