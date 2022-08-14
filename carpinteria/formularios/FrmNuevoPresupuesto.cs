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

namespace carpinteria.formularios
{
    public partial class FrmNuevoPresupuesto : Form
    {
        presupuesto nuevo;
        public FrmNuevoPresupuesto()
        {
            nuevo = new presupuesto();
            InitializeComponent();
        }

        private void FrmNuevoPresupuesto_Load(object sender, EventArgs e)
        {
            lblPresupuesto.Text += proximoPresupuesto();
            cargarProductos();
            txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtCliente.Text = "consumidor final";
            txtDescuento.Text = "0";
            txtCantidad.Text = 1.ToString();
        }

        private void cargarProductos()
        {
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EU00IF5;Initial Catalog=Carpinteria;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_PRODUCTOS";

            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            cboProductos.DataSource = tabla;
            cboProductos.DisplayMember = "n_producto";
            cboProductos.ValueMember = "id_producto";

        }

        private int proximoPresupuesto()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EU00IF5;Initial Catalog=Carpinteria;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_PROXIMO_ID";
            SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            conexion.Close();

            return (int)param.Value;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProductos.Text.Equals(string.Empty))
            {
                MessageBox.Show("debe seleccionar algo", "control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("debe ingresar una cantidad valida", "control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["Colprod"].Value.ToString().Equals(cboProductos.Text))
                {
                    MessageBox.Show("ya esta presupuestado", "control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            DataRowView item = (DataRowView)cboProductos.SelectedItem;

            int prod = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            double pre = Convert.ToDouble(item.Row.ItemArray[2]);
            int cant = Convert.ToInt32(txtCantidad.Text);

            producto p = new producto(prod, nom, pre);
            DetallePresupuesto detalle = new DetallePresupuesto(p, cant);

            nuevo.AgregarDetalle(detalle);
            dgvDetalles.Rows.Add(new object[] { prod, nom, pre, cant });

            calcularTotales();
        }

        private void calcularTotales()
        {
            txtSubTotal.Text = nuevo.CalcularTotal().ToString();

            double desc = nuevo.CalcularTotal() * Convert.ToDouble(txtDescuento.Text) / 100;
            txtTotal.Text = (nuevo.CalcularTotal() - desc).ToString();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                nuevo.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                calcularTotales();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //validar
            if (txtCliente.Text == string.Empty)
            {
                MessageBox.Show("debe ingresar cliente", "control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCliente.Focus();
                return;
            }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("debe ingresar un detalle al menos", "control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboProductos.Focus();
                return;
            }

            //grabar maestro detalle
            guardarPresupuesto();
        }

        private void guardarPresupuesto()
        {
            nuevo.Fecha = Convert.ToDateTime(txtFecha.Text);
            nuevo.Cliente = txtCliente.Text;
            nuevo.Descuento = Convert.ToDouble(txtDescuento.Text);
            nuevo.total = Convert.ToDouble(txtTotal.Text);

            if (nuevo.confirmar())
            {
                MessageBox.Show("se ingreso correctamente", "correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("hubo un error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
