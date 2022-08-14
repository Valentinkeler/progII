using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carpinteria.formularios
{
    public partial class FrmReportesProductos : Form
    {
        public FrmReportesProductos()
        {
            InitializeComponent();
        }

        private void FrmReportesProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSproductos.T_PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.t_PRODUCTOSTableAdapter.Fill(this.dSproductos.T_PRODUCTOS);

            this.reportViewer1.RefreshReport();
        }
    }
}
