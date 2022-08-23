using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpinteria
{
    internal class producto
    {
        private string nom;

        public int Prod { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Activo { get; set; }
        public producto(string nombre, double precio,string activo)
        {
            Nombre = nombre;
            Precio = precio;
            Activo = activo;
        }

        public producto(int prod, string nom, int precio)
        {
            Prod = prod;
            this.nom = nom;
            Precio = precio;
        }

        private string toString()
        { 
            return Nombre+" | $"+Precio+" | "+Activo;
        } 

    }
}
