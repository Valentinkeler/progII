﻿namespace carpinteria.forms
{
    partial class frm_presupuesto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_PresupuestoNro = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.cbo_Producto = new System.Windows.Forms.ComboBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_subTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_PresupuestoNro
            // 
            this.lbl_PresupuestoNro.AutoSize = true;
            this.lbl_PresupuestoNro.Location = new System.Drawing.Point(39, 30);
            this.lbl_PresupuestoNro.Name = "lbl_PresupuestoNro";
            this.lbl_PresupuestoNro.Size = new System.Drawing.Size(89, 13);
            this.lbl_PresupuestoNro.TabIndex = 1;
            this.lbl_PresupuestoNro.Text = "Presupuesto Nro:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(131, 73);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(187, 20);
            this.dtp_fecha.TabIndex = 2;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(131, 111);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(358, 20);
            this.txt_cliente.TabIndex = 3;
            this.txt_cliente.Text = "CONSUMIDOR FINAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "%descuento:";
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(130, 150);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(188, 20);
            this.txt_descuento.TabIndex = 11;
            this.txt_descuento.Text = "0";
            // 
            // cbo_Producto
            // 
            this.cbo_Producto.FormattingEnabled = true;
            this.cbo_Producto.Location = new System.Drawing.Point(60, 199);
            this.cbo_Producto.Name = "cbo_Producto";
            this.cbo_Producto.Size = new System.Drawing.Size(291, 21);
            this.cbo_Producto.TabIndex = 12;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(357, 199);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(106, 20);
            this.txt_cantidad.TabIndex = 13;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(478, 197);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 14;
            this.btn_agregar.Text = "agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sub Total $";
            // 
            // txt_subTotal
            // 
            this.txt_subTotal.Location = new System.Drawing.Point(469, 496);
            this.txt_subTotal.Name = "txt_subTotal";
            this.txt_subTotal.Size = new System.Drawing.Size(98, 20);
            this.txt_subTotal.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Total $";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(469, 535);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(98, 20);
            this.txt_total.TabIndex = 20;
            // 
            // frm_presupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 586);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_subTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.cbo_Producto);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.lbl_PresupuestoNro);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_presupuesto";
            this.Text = "nuevo presupuesto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_PresupuestoNro;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.ComboBox cbo_Producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_subTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_total;
    }
}

