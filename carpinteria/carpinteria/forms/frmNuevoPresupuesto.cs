using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace carpinteria.forms
{
    public partial class frm_presupuesto : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EU00IF5;Initial Catalog=carpinteria_db;Integrated Security=True");
        
            
        public frm_presupuesto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            proximoId();
        }

        private void proximoId()
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("SP_PROXIMO_ID",conexion);
            comando.CommandType = CommandType.StoredProcedure;
            
            SqlParameter param = new SqlParameter("@next",SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            int nextID =Convert.ToInt32(param.Value);

            conexion.Close();

            lbl_PresupuestoNro.Text += nextID;  
        }
    }
}
