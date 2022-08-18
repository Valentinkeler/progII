using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using carpinteria.DBhelper;

namespace carpinteria.forms
{
    public partial class frm_presupuesto : Form
    {
        accesoDatos oAccesoDatos = new accesoDatos();
        
            
        public frm_presupuesto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////proximoId();
            cargarCombo("SP_CONSULTAR_PRODUCTOS", cbo_Producto);
        }

        private void cargarCombo(string SP,ComboBox combo)
        {
            DataTable table = oAccesoDatos.consultarBD(SP);

            combo.DataSource = table;
            combo.ValueMember = table.Columns[0].ColumnName;
            combo.DisplayMember = table.Columns[1].ColumnName;

        }

        //private void proximoId()
        //{
        //    conexion.Open();
        //    SqlCommand comando = new SqlCommand("SP_PROXIMO_ID",conexion);
        //    comando.CommandType = CommandType.StoredProcedure;

        //    //SqlParameter param = new SqlParameter("@next",SqlDbType.Int);
        //    //param.Direction = ParameterDirection.Output;

        //    int nextID = comando.Parameters.Add(new SqlParameter("@next", SqlDbType.Int).Direction = ParameterDirection.Output);

        //    comando.ExecuteNonQuery();

        //    //int nextID =Convert.ToInt32(param);

        //    conexion.Close();

        //    lbl_PresupuestoNro.Text += nextID;  
        //}

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
