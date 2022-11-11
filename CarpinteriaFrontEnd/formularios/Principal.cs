﻿using CarpinteriaApp.Servicios;

namespace CarpinteriaApp.formularios
{
    public partial class Principal : Form
    {
        private FabricaServicio fabrica;
        public Principal(FabricaServicio fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carpintería App", "Caso Testigo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nuevoPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Principal(fabrica).ShowDialog();
        }

        private void consultarPresupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarPresupuestos(fabrica).ShowDialog();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporteProducto(fabrica).ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}