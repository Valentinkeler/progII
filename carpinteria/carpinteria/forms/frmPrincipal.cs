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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();          
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_presupuesto nuevo = new frm_presupuesto();
            nuevo.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarPresupuesto nuevo = new frmConsultarPresupuesto();
            nuevo.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNuevoProducto nuevo = new frmNuevoProducto();
            nuevo.Show();
        }
    }
}
