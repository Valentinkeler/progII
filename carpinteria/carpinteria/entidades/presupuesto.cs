using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpinteria
{
    internal class presupuesto
    {
        public int presupuestoNro { get; set; }
        public DateTime fecha { get; set; }
        public string cliente { get; set; }
        public int costoMO { get; set; }
        public int descuento { get; set; }
        public DateTime fechaBaja { get; set; }
        public List<detalle_producto> Detalle{ get; set; }

        public presupuesto()
        {
            Detalle = new List<detalle_producto>();
        }

        private void agregarDetalle(detalle_producto detalle)
        {
            Detalle.Add(detalle);
        }
        private void quitarDetalle(int indice)
        {
            Detalle.RemoveAt(indice);
        }
        private double calcularTotal()
        {
            double total = 0;
            foreach (detalle_producto items in Detalle)
            {
                total += items.CalcularSubTotal();
            }
            return total;
        }
        private void Confirmar()
        {

        }
    }
}
