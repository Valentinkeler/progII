using carpinteria.DBhelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carpinteria.forms
{
    public partial class frmNuevoProducto : Form
    {
        accesoDatos accesoDatos = new accesoDatos();
        public frmNuevoProducto()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text=="")
            {
                MessageBox.Show("ingresar   producto", "Control",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
            }
            if (txtPrecio.Text=="" || !int.TryParse(txtPrecio.Text,out _))
            {
                    MessageBox.Show("ingresar  un precio", "Control",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }

            if (guardarProducto())
            {
                MessageBox.Show("se guardo el producto correctamente", "Control",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("no se pdo guardar", "Control",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Exclamation);
            }
            
        }

        private bool guardarProducto()
        {
            string activo;
            string  nombre=txtNombre.Text;
            int precio = Convert.ToInt32(txtPrecio.Text);
            if (chkEstado.Checked)
            {
                activo = "S";
            }
            else
            {
                activo="n";
            }

            producto oProducto = new producto(nombre,precio,activo);

            accesoDatos.insert("PA_insertar_Producto", oProducto.Nombre,Convert.ToInt32(oProducto.Precio), oProducto.Activo);

            return true;

        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
