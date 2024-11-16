namespace Presentacion
{
    partial class frmSupervDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupervDevoluciones));
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.txtBoxIdVenta = new System.Windows.Forms.TextBox();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.lblInfoDatosVenta = new System.Windows.Forms.Label();
            this.btnDevolverVenta = new FontAwesome.Sharp.IconButton();
            this.btnBuscarVentaADevolver = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.grpVenta = new System.Windows.Forms.GroupBox();
            this.lblContCantidadVenta = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblContFechaAltaVenta = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblContEstadoVenta = new System.Windows.Forms.Label();
            this.panelAdmUsersAlta.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.grpVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdmUsersAlta
            // 
            this.panelAdmUsersAlta.Controls.Add(this.lblTop);
            this.panelAdmUsersAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmUsersAlta.Location = new System.Drawing.Point(18, 0);
            this.panelAdmUsersAlta.Name = "panelAdmUsersAlta";
            this.panelAdmUsersAlta.Size = new System.Drawing.Size(976, 56);
            this.panelAdmUsersAlta.TabIndex = 7;
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(3, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(409, 39);
            this.lblTop.TabIndex = 7;
            this.lblTop.Text = "Panel de Devoluciones - Devolver Venta";
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Teal;
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(18, 566);
            this.panelSide.TabIndex = 34;
            // 
            // txtBoxIdVenta
            // 
            this.txtBoxIdVenta.Location = new System.Drawing.Point(47, 68);
            this.txtBoxIdVenta.Name = "txtBoxIdVenta";
            this.txtBoxIdVenta.Size = new System.Drawing.Size(206, 25);
            this.txtBoxIdVenta.TabIndex = 24;
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.Location = new System.Drawing.Point(6, 35);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(105, 25);
            this.lblNombreProd.TabIndex = 12;
            this.lblNombreProd.Text = "Estado";
            this.lblNombreProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoDatosVenta
            // 
            this.lblInfoDatosVenta.AutoSize = true;
            this.lblInfoDatosVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoDatosVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDatosVenta.Location = new System.Drawing.Point(23, 33);
            this.lblInfoDatosVenta.Name = "lblInfoDatosVenta";
            this.lblInfoDatosVenta.Size = new System.Drawing.Size(265, 21);
            this.lblInfoDatosVenta.TabIndex = 22;
            this.lblInfoDatosVenta.Text = "Ingrese el ID de la venta a devolver";
            this.lblInfoDatosVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDevolverVenta
            // 
            this.btnDevolverVenta.BackColor = System.Drawing.Color.Firebrick;
            this.btnDevolverVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolverVenta.FlatAppearance.BorderSize = 0;
            this.btnDevolverVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnDevolverVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnDevolverVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolverVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDevolverVenta.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDevolverVenta.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnDevolverVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDevolverVenta.IconSize = 30;
            this.btnDevolverVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolverVenta.Location = new System.Drawing.Point(737, 455);
            this.btnDevolverVenta.Name = "btnDevolverVenta";
            this.btnDevolverVenta.Size = new System.Drawing.Size(195, 41);
            this.btnDevolverVenta.TabIndex = 29;
            this.btnDevolverVenta.Text = "Devolver";
            this.btnDevolverVenta.UseVisualStyleBackColor = false;
            this.btnDevolverVenta.Click += new System.EventHandler(this.btnDevolverVenta_Click);
            // 
            // btnBuscarVentaADevolver
            // 
            this.btnBuscarVentaADevolver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarVentaADevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarVentaADevolver.FlatAppearance.BorderSize = 0;
            this.btnBuscarVentaADevolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnBuscarVentaADevolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarVentaADevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVentaADevolver.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVentaADevolver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarVentaADevolver.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarVentaADevolver.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarVentaADevolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarVentaADevolver.IconSize = 30;
            this.btnBuscarVentaADevolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarVentaADevolver.Location = new System.Drawing.Point(279, 62);
            this.btnBuscarVentaADevolver.Name = "btnBuscarVentaADevolver";
            this.btnBuscarVentaADevolver.Size = new System.Drawing.Size(133, 34);
            this.btnBuscarVentaADevolver.TabIndex = 34;
            this.btnBuscarVentaADevolver.Text = "Buscar";
            this.btnBuscarVentaADevolver.UseVisualStyleBackColor = false;
            this.btnBuscarVentaADevolver.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContenedor.Controls.Add(this.grpVenta);
            this.panelContenedor.Controls.Add(this.btnBuscarVentaADevolver);
            this.panelContenedor.Controls.Add(this.btnDevolverVenta);
            this.panelContenedor.Controls.Add(this.lblInfoDatosVenta);
            this.panelContenedor.Controls.Add(this.txtBoxIdVenta);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(18, 56);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(976, 510);
            this.panelContenedor.TabIndex = 33;
            // 
            // grpVenta
            // 
            this.grpVenta.Controls.Add(this.lblContCantidadVenta);
            this.grpVenta.Controls.Add(this.lblCantidad);
            this.grpVenta.Controls.Add(this.lblContFechaAltaVenta);
            this.grpVenta.Controls.Add(this.lblPrecio);
            this.grpVenta.Controls.Add(this.lblContEstadoVenta);
            this.grpVenta.Controls.Add(this.lblNombreProd);
            this.grpVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVenta.Location = new System.Drawing.Point(547, 33);
            this.grpVenta.Name = "grpVenta";
            this.grpVenta.Size = new System.Drawing.Size(385, 213);
            this.grpVenta.TabIndex = 35;
            this.grpVenta.TabStop = false;
            this.grpVenta.Text = "Datos de la venta";
            // 
            // lblContCantidadVenta
            // 
            this.lblContCantidadVenta.BackColor = System.Drawing.Color.DarkGray;
            this.lblContCantidadVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContCantidadVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContCantidadVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContCantidadVenta.Location = new System.Drawing.Point(129, 150);
            this.lblContCantidadVenta.Name = "lblContCantidadVenta";
            this.lblContCantidadVenta.Size = new System.Drawing.Size(230, 25);
            this.lblContCantidadVenta.TabIndex = 43;
            this.lblContCantidadVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(6, 150);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(105, 25);
            this.lblCantidad.TabIndex = 42;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContFechaAltaVenta
            // 
            this.lblContFechaAltaVenta.BackColor = System.Drawing.Color.DarkGray;
            this.lblContFechaAltaVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContFechaAltaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContFechaAltaVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContFechaAltaVenta.Location = new System.Drawing.Point(129, 94);
            this.lblContFechaAltaVenta.Name = "lblContFechaAltaVenta";
            this.lblContFechaAltaVenta.Size = new System.Drawing.Size(230, 25);
            this.lblContFechaAltaVenta.TabIndex = 39;
            this.lblContFechaAltaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(6, 94);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(105, 25);
            this.lblPrecio.TabIndex = 38;
            this.lblPrecio.Text = "Fecha alta";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContEstadoVenta
            // 
            this.lblContEstadoVenta.BackColor = System.Drawing.Color.DarkGray;
            this.lblContEstadoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContEstadoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContEstadoVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContEstadoVenta.Location = new System.Drawing.Point(129, 35);
            this.lblContEstadoVenta.Name = "lblContEstadoVenta";
            this.lblContEstadoVenta.Size = new System.Drawing.Size(230, 25);
            this.lblContEstadoVenta.TabIndex = 34;
            this.lblContEstadoVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSupervDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelAdmUsersAlta);
            this.Controls.Add(this.panelSide);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSupervDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Devoluciones";
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.grpVenta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.TextBox txtBoxIdVenta;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Label lblInfoDatosVenta;
        private FontAwesome.Sharp.IconButton btnDevolverVenta;
        private FontAwesome.Sharp.IconButton btnBuscarVentaADevolver;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.GroupBox grpVenta;
        private System.Windows.Forms.Label lblContEstadoVenta;
        private System.Windows.Forms.Label lblContFechaAltaVenta;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblContCantidadVenta;
        private System.Windows.Forms.Label lblCantidad;
    }
}