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
        presupuesto oPresupuesto = new presupuesto();

        public frm_presupuesto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            proximoId("SP_PROXIMO_ID");
            cargarCombo("SP_CONSULTAR_PRODUCTOS", cbo_Producto);
        }

        private void proximoId(string SP)
        {
            lbl_PresupuestoNro.Text +=   oAccesoDatos.nonquery(SP);
        }

        private void cargarCombo(string SP,ComboBox combo)
        {
            DataTable table = oAccesoDatos.consultarBD(SP);

            combo.DataSource = table;
            combo.ValueMember = table.Columns[0].ColumnName;
            combo.DisplayMember = table.Columns[1].ColumnName;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (cbo_Producto.Text.Equals(String.Empty))
            {
                MessageBox.Show("agragar producto", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }
            if (txt_cantidad.Text==String.Empty|| !int.TryParse(txt_cantidad.Text,out _))
            {
                MessageBox.Show("ingresar cantidad producto", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //foreach (DataGridViewRow item in dgvDetalles.Rows)
            //{
            //    if (item.Cells["colProducto"].Value.ToString().Equals(cbo_Producto.Text))
            //    {
            //        MessageBox.Show("el producto ya a sido agregado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}

            DataRowView grilla = (DataRowView)cbo_Producto.SelectedItem;

            int prod =Convert.ToInt32(grilla.Row.ItemArray[0]);
            string nom =grilla.Row.ItemArray[1].ToString();
            int Precio  =Convert.ToInt32(grilla.Row.ItemArray[2]);
            int cantidad =Convert.ToInt32(txt_cantidad.Text);

            producto oProducto = new producto(prod, nom, Precio);

            detalle_producto oDetalle = new detalle_producto(oProducto, cantidad);

            oPresupuesto.agregarDetalle(oDetalle);

            dgvDetalles.Rows.Add(new object[] { grilla.Row.ItemArray[0], grilla.Row.ItemArray[1], grilla.Row.ItemArray[2], txt_cantidad.Text });

            calcularTotal();
        }

        private void calcularTotal()
        {
            double  total   =oPresupuesto.calcularTotal();

            txt_subTotal.Text = total.ToString();

            if (txt_descuento.Text!="")
            {
                double dto = (total *Convert.ToDouble(txt_descuento.Text)) / 100;
                txt_total.Text = (total-dto).ToString();
            }

        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex==4)
            {
                oPresupuesto.quitarDetalle(dgvDetalles.CurrentRow.Index);

                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);

                calcularTotal();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_cliente.Text == String.Empty )
            {
                MessageBox.Show("ingrese cliente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDetalles.Rows.Count==0)
            {
                MessageBox.Show("debe ingresar almenos un detalle", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            guardarPresupuesto();
        }

        private void guardarPresupuesto()
        {
            oPresupuesto.cliente = txt_cliente.Text;
            oPresupuesto.descuento =Convert.ToInt32(txt_descuento.Text);
            oPresupuesto.fecha = Convert.ToDateTime(dtp_fecha.Text);

            if (oPresupuesto.Confirmar())
            {
                MessageBox.Show("se cargo el presupesto correctamente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                MessageBox.Show("error al cargar presupuesto", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
