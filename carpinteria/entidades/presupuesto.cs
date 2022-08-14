using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace carpinteria
{
    class presupuesto
    {
        public int PresupuestoNro { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public double total { get; set; }
        public double Descuento { get; set; }
        public DateTime FechaBaja { get; set; }
        public List<DetallePresupuesto> Detalles { get; set; }

        public presupuesto()
        {
            Detalles = new List<DetallePresupuesto>(); 
        }
        
        public void AgregarDetalle(DetallePresupuesto detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (DetallePresupuesto item in Detalles)
            {
                total += item.CalcularSubtotal();
            }
            return total;
        }

        public bool confirmar()
        {
            bool estado = true;
            SqlConnection conexion = new SqlConnection();
            SqlTransaction transacion = null;
            try
            {
                conexion.ConnectionString = @"Data Source=DESKTOP-EU00IF5;Initial Catalog=Carpinteria;Integrated Security=True";
                conexion.Open();
                transacion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = transacion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_MAESTRO";
                comando.Parameters.AddWithValue("@cliente", this.Cliente);
                comando.Parameters.AddWithValue("@dto", this.Descuento);
                comando.Parameters.AddWithValue("@total", this.total);
                SqlParameter parm = new SqlParameter();
                parm.ParameterName = "@presupuesto_nro";
                parm.SqlDbType = SqlDbType.Int;
                parm.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parm);

                comando.ExecuteNonQuery();

                this.PresupuestoNro = (int)parm.Value;

                int detalleNro = 1;

                foreach (DetallePresupuesto item in Detalles)
                {
                    SqlCommand comandoDetalle = new SqlCommand();
                    comandoDetalle.Connection = conexion;
                    comandoDetalle.Transaction = transacion;
                    comandoDetalle.CommandType = CommandType.StoredProcedure;
                    comandoDetalle.CommandText = "SP_INSERTAR_DETALLE";
                    comandoDetalle.Parameters.AddWithValue("@presupuesto_nro", this.PresupuestoNro);
                    comandoDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    comandoDetalle.Parameters.AddWithValue("@id_producto", item.producto.ProductoNro);
                    comandoDetalle.Parameters.AddWithValue("@cantidad", item.cantidad);

                    comandoDetalle.ExecuteNonQuery();

                    detalleNro++;
                }
                transacion.Commit();
            }
            catch (Exception ex)
            {
                transacion.Rollback();
                estado = false;

            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return estado;
        }
    }
}
