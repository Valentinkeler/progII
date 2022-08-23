using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpinteria.DBhelper
{
    internal class accesoDatos
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EU00IF5;Initial Catalog=carpinteria_db;Integrated Security=True");
        

        public  DataTable consultarBD(string SP)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = SP;

            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return  tabla;
        }
        public  int nonquery(string SP)
        {
            SqlCommand cmd = new SqlCommand();
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SP;

            SqlParameter param  =   new SqlParameter("@Next",SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            conexion.Close();

            return  Convert.ToInt32(param.Value);
        }
        public  void insert(string  SP,string nombre,int precio,string activo)
        {
            SqlCommand cmd1 = new SqlCommand();
            conexion.Open();
            cmd1.Connection = conexion;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = SP;

            cmd1.Parameters.AddWithValue("@n_producto", nombre);
            cmd1.Parameters.AddWithValue("@precio",precio);
            cmd1.Parameters.AddWithValue("@activo",activo);

            cmd1.ExecuteNonQuery();

            conexion.Close();
        }
      
    }
}
