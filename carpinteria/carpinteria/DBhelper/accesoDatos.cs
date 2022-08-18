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
        SqlCommand comando = new SqlCommand();

        public  DataTable consultarBD(string consulta)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = consulta;

            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return  tabla;
        }
    }
}
