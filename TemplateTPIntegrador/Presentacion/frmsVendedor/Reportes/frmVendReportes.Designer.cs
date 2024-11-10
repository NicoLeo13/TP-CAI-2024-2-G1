﻿namespace Presentacion.frmsVendedor
{
    partial class frmVendReportes
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
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.VendReportes = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarVenta = new FontAwesome.Sharp.IconButton();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblPromo = new System.Windows.Forms.Label();
            this.lblNombrePromo = new System.Windows.Forms.Label();
            this.txtNombrePromo = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.lblProductoIDdetalle = new System.Windows.Forms.Label();
            this.lblDescripcionDetalle = new System.Windows.Forms.Label();
            this.lblCantidadDetalle = new System.Windows.Forms.Label();
            this.lblUnitarioDetalle = new System.Windows.Forms.Label();
            this.lblTotalDetalle = new System.Windows.Forms.Label();
            this.BoxDetalle = new System.Windows.Forms.ListBox();
            this.panelAdmUsersAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Teal;
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(14, 557);
            this.panelSide.TabIndex = 65;
            // 
            // panelAdmUsersAlta
            // 
            this.panelAdmUsersAlta.Controls.Add(this.VendReportes);
            this.panelAdmUsersAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmUsersAlta.Location = new System.Drawing.Point(14, 0);
            this.panelAdmUsersAlta.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdmUsersAlta.Name = "panelAdmUsersAlta";
            this.panelAdmUsersAlta.Size = new System.Drawing.Size(1269, 46);
            this.panelAdmUsersAlta.TabIndex = 67;
            // 
            // VendReportes
            // 
            this.VendReportes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendReportes.Location = new System.Drawing.Point(2, 7);
            this.VendReportes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VendReportes.Name = "VendReportes";
            this.VendReportes.Size = new System.Drawing.Size(566, 32);
            this.VendReportes.TabIndex = 7;
            this.VendReportes.Text = "Panel de Vendedor - Reportes";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmpresa.Location = new System.Drawing.Point(20, 131);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(92, 24);
            this.lblEmpresa.TabIndex = 70;
            this.lblEmpresa.Text = "Empresa";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(118, 131);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(193, 22);
            this.txtEmpresa.TabIndex = 69;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaVenta.Location = new System.Drawing.Point(20, 165);
            this.lblFechaVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(92, 24);
            this.lblFechaVenta.TabIndex = 72;
            this.lblFechaVenta.Text = "Fecha";
            this.lblFechaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFechaVenta.Click += new System.EventHandler(this.lblFechaVenta_Click);
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(118, 165);
            this.dtpFechaVenta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(193, 22);
            this.dtpFechaVenta.TabIndex = 71;
            this.dtpFechaVenta.ValueChanged += new System.EventHandler(this.dtpFechaVenta_ValueChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCliente.Location = new System.Drawing.Point(20, 94);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(92, 24);
            this.lblCliente.TabIndex = 74;
            this.lblCliente.Text = "ID Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(118, 94);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(193, 22);
            this.txtCliente.TabIndex = 73;
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarVenta.FlatAppearance.BorderSize = 0;
            this.btnBuscarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnBuscarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarVenta.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnBuscarVenta.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarVenta.IconSize = 30;
            this.btnBuscarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarVenta.Location = new System.Drawing.Point(116, 229);
            this.btnBuscarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(195, 41);
            this.btnBuscarVenta.TabIndex = 75;
            this.btnBuscarVenta.Text = "Buscar";
            this.btnBuscarVenta.UseVisualStyleBackColor = false;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDetalle.Location = new System.Drawing.Point(429, 94);
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(92, 24);
            this.lblDetalle.TabIndex = 76;
            this.lblDetalle.Text = "Detalle:";
            this.lblDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPromo
            // 
            this.lblPromo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPromo.Location = new System.Drawing.Point(429, 403);
            this.lblPromo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(92, 24);
            this.lblPromo.TabIndex = 77;
            this.lblPromo.Text = "Promociones:";
            this.lblPromo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombrePromo
            // 
            this.lblNombrePromo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombrePromo.Location = new System.Drawing.Point(641, 442);
            this.lblNombrePromo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombrePromo.Name = "lblNombrePromo";
            this.lblNombrePromo.Size = new System.Drawing.Size(92, 24);
            this.lblNombrePromo.TabIndex = 81;
            this.lblNombrePromo.Text = "Nombre Promo";
            this.lblNombrePromo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombrePromo
            // 
            this.txtNombrePromo.Location = new System.Drawing.Point(739, 442);
            this.txtNombrePromo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombrePromo.Name = "txtNombrePromo";
            this.txtNombrePromo.Size = new System.Drawing.Size(193, 22);
            this.txtNombrePromo.TabIndex = 80;
            // 
            // lblDescuento
            // 
            this.lblDescuento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescuento.Location = new System.Drawing.Point(641, 479);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(92, 24);
            this.lblDescuento.TabIndex = 79;
            this.lblDescuento.Text = "Descuento";
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(739, 479);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(193, 22);
            this.txtDescuento.TabIndex = 78;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalPagar.Location = new System.Drawing.Point(641, 526);
            this.lblTotalPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(92, 24);
            this.lblTotalPagar.TabIndex = 83;
            this.lblTotalPagar.Text = "Total a Pagar";
            this.lblTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(739, 526);
            this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(193, 22);
            this.txtTotalPagar.TabIndex = 82;
            // 
            // lblProductoIDdetalle
            // 
            this.lblProductoIDdetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductoIDdetalle.Location = new System.Drawing.Point(429, 131);
            this.lblProductoIDdetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductoIDdetalle.Name = "lblProductoIDdetalle";
            this.lblProductoIDdetalle.Size = new System.Drawing.Size(92, 24);
            this.lblProductoIDdetalle.TabIndex = 84;
            this.lblProductoIDdetalle.Text = "ID Producto";
            this.lblProductoIDdetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcionDetalle
            // 
            this.lblDescripcionDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescripcionDetalle.Location = new System.Drawing.Point(525, 131);
            this.lblDescripcionDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionDetalle.Name = "lblDescripcionDetalle";
            this.lblDescripcionDetalle.Size = new System.Drawing.Size(92, 24);
            this.lblDescripcionDetalle.TabIndex = 85;
            this.lblDescripcionDetalle.Text = "Descripción";
            this.lblDescripcionDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidadDetalle
            // 
            this.lblCantidadDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidadDetalle.Location = new System.Drawing.Point(621, 131);
            this.lblCantidadDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadDetalle.Name = "lblCantidadDetalle";
            this.lblCantidadDetalle.Size = new System.Drawing.Size(92, 24);
            this.lblCantidadDetalle.TabIndex = 86;
            this.lblCantidadDetalle.Text = "Cantidad";
            this.lblCantidadDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnitarioDetalle
            // 
            this.lblUnitarioDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblUnitarioDetalle.Location = new System.Drawing.Point(717, 131);
            this.lblUnitarioDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitarioDetalle.Name = "lblUnitarioDetalle";
            this.lblUnitarioDetalle.Size = new System.Drawing.Size(92, 24);
            this.lblUnitarioDetalle.TabIndex = 87;
            this.lblUnitarioDetalle.Text = "Unitario";
            this.lblUnitarioDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalDetalle
            // 
            this.lblTotalDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalDetalle.Location = new System.Drawing.Point(828, 131);
            this.lblTotalDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDetalle.Name = "lblTotalDetalle";
            this.lblTotalDetalle.Size = new System.Drawing.Size(92, 24);
            this.lblTotalDetalle.TabIndex = 88;
            this.lblTotalDetalle.Text = "Total";
            this.lblTotalDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BoxDetalle
            // 
            this.BoxDetalle.FormattingEnabled = true;
            this.BoxDetalle.ItemHeight = 16;
            this.BoxDetalle.Location = new System.Drawing.Point(432, 165);
            this.BoxDetalle.Name = "BoxDetalle";
            this.BoxDetalle.Size = new System.Drawing.Size(500, 228);
            this.BoxDetalle.TabIndex = 90;
            // 
            // frmVendReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 557);
            this.Controls.Add(this.BoxDetalle);
            this.Controls.Add(this.lblTotalDetalle);
            this.Controls.Add(this.lblUnitarioDetalle);
            this.Controls.Add(this.lblCantidadDetalle);
            this.Controls.Add(this.lblDescripcionDetalle);
            this.Controls.Add(this.lblProductoIDdetalle);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.lblNombrePromo);
            this.Controls.Add(this.txtNombrePromo);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lblPromo);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.btnBuscarVenta);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblFechaVenta);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.panelAdmUsersAlta);
            this.Controls.Add(this.panelSide);
            this.Name = "frmVendReportes";
            this.Text = "frmVendReportes";
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label VendReportes;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private FontAwesome.Sharp.IconButton btnBuscarVenta;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblPromo;
        private System.Windows.Forms.Label lblNombrePromo;
        private System.Windows.Forms.TextBox txtNombrePromo;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label lblProductoIDdetalle;
        private System.Windows.Forms.Label lblDescripcionDetalle;
        private System.Windows.Forms.Label lblCantidadDetalle;
        private System.Windows.Forms.Label lblUnitarioDetalle;
        private System.Windows.Forms.Label lblTotalDetalle;
        private System.Windows.Forms.ListBox BoxDetalle;
    }
}