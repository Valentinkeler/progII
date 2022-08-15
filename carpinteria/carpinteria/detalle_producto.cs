using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpinteria
{
    internal class detalle_producto
    {
        public producto producto { get; set; }
        public int cantidad { get; set; }

        private int CalcularSubTotal()
        {
            return cantidad * producto.precio;
        }

    }
}
