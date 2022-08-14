
namespace carpinteria.formularios
{
    partial class FrmReportesProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSproductos = new carpinteria.reportes.DSproductos();
            this.tPRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_PRODUCTOSTableAdapter = new carpinteria.reportes.DSproductosTableAdapters.T_PRODUCTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPRODUCTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tPRODUCTOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "carpinteria.reportes.rptProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(752, 413);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSproductos
            // 
            this.dSproductos.DataSetName = "DSproductos";
            this.dSproductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tPRODUCTOSBindingSource
            // 
            this.tPRODUCTOSBindingSource.DataMember = "T_PRODUCTOS";
            this.tPRODUCTOSBindingSource.DataSource = this.dSproductos;
            // 
            // t_PRODUCTOSTableAdapter
            // 
            this.t_PRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportesProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportesProductos";
            this.Text = "FrmReportesProductos";
            this.Load += new System.EventHandler(this.FrmReportesProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPRODUCTOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private reportes.DSproductos dSproductos;
        private System.Windows.Forms.BindingSource tPRODUCTOSBindingSource;
        private reportes.DSproductosTableAdapters.T_PRODUCTOSTableAdapter t_PRODUCTOSTableAdapter;
    }
}