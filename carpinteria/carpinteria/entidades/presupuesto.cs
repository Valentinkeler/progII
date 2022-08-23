using carpinteria.DBhelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

        public void agregarDetalle(detalle_producto detalle)
        {
            Detalle.Add(detalle);
        }
        public void quitarDetalle(int indice)
        {
            Detalle.RemoveAt(indice);
        }
        public double calcularTotal()
        {
            double total = 0;
            foreach (detalle_producto items in Detalle)
            {
                total += items.CalcularSubTotal();
            }
            return total;
        }
        public bool Confirmar()
        {
            bool resultado=true;
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString= @"Data Source=DESKTOP-EU00IF5;Initial Catalog=carpinteria_db;Integrated Security=True";
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_MAESTRO";

                comando.Parameters.AddWithValue("@cliente", this.cliente);
                comando.Parameters.AddWithValue("@dto", this.descuento);
                comando.Parameters.AddWithValue("@total", this.calcularTotal()-this.descuento);

                SqlParameter param = new SqlParameter("@presupuesto_nro", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                comando.Parameters.Add(param);

                comando.ExecuteNonQuery();

                int presupuestoNro = Convert.ToInt32(param.Value);
                int CDetalle = 1;
                foreach (detalle_producto item in Detalle)
                {

                    SqlCommand cmdDet = new SqlCommand();                    
                    cmdDet.Connection = conexion;
                    cmdDet.CommandType = CommandType.StoredProcedure;
                    cmdDet.CommandText = "SP_INSERTAR_DETALLE";

                    cmdDet.Parameters.AddWithValue("@presupuesto_nro", presupuestoNro);
                    cmdDet.Parameters.AddWithValue("@detalle", CDetalle);
                    cmdDet.Parameters.AddWithValue("@id_producto", item.Producto.Prod);
                    cmdDet.Parameters.AddWithValue("@cantidad", item.Cantidad);

                    cmdDet.ExecuteNonQuery();
                    CDetalle++;
                }
                
            }
            catch (Exception)
            {
                resultado = false;
            }
            finally
            {
                if (conexion !=null && conexion.State==ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resultado;
        }
    }
}
