namespace Presentacion
{
    partial class frmVendNuevaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendNuevaVenta));
            this.btnLimpiarCampos = new FontAwesome.Sharp.IconButton();
            this.btnCargarVenta = new FontAwesome.Sharp.IconButton();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.lblInfoDatosProd = new System.Windows.Forms.Label();
            this.txtBoxNombreProd = new System.Windows.Forms.TextBox();
            this.grpDatosStock = new System.Windows.Forms.GroupBox();
            this.lblContIdProd = new System.Windows.Forms.Label();
            this.lblContStock = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblIdProd = new System.Windows.Forms.Label();
            this.lblContPrecio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.grpVenta = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.panelAdmUsersAlta.SuspendLayout();
            this.grpDatosStock.SuspendLayout();
            this.grpVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnLimpiarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarCampos.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarCampos.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarCampos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarCampos.IconSize = 30;
            this.btnLimpiarCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(761, 514);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(195, 41);
            this.btnLimpiarCampos.TabIndex = 38;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnCargarVenta
            // 
            this.btnCargarVenta.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCargarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarVenta.FlatAppearance.BorderSize = 0;
            this.btnCargarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnCargarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnCargarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCargarVenta.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnCargarVenta.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnCargarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarVenta.IconSize = 30;
            this.btnCargarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarVenta.Location = new System.Drawing.Point(761, 452);
            this.btnCargarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarVenta.Name = "btnCargarVenta";
            this.btnCargarVenta.Size = new System.Drawing.Size(195, 41);
            this.btnCargarVenta.TabIndex = 37;
            this.btnCargarVenta.Text = "Guardar";
            this.btnCargarVenta.UseVisualStyleBackColor = false;
            this.btnCargarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Teal;
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(18, 566);
            this.panelSide.TabIndex = 63;
            // 
            // panelAdmUsersAlta
            // 
            this.panelAdmUsersAlta.Controls.Add(this.lblTop);
            this.panelAdmUsersAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmUsersAlta.Location = new System.Drawing.Point(18, 0);
            this.panelAdmUsersAlta.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdmUsersAlta.Name = "panelAdmUsersAlta";
            this.panelAdmUsersAlta.Size = new System.Drawing.Size(976, 46);
            this.panelAdmUsersAlta.TabIndex = 64;
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(2, 7);
            this.lblTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(579, 32);
            this.lblTop.TabIndex = 7;
            this.lblTop.Text = "Panel de Vendedor - Ingrese nueva venta\r\n";
            this.lblTop.Click += new System.EventHandler(this.lblTop_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 30;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(304, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 34);
            this.btnBuscar.TabIndex = 73;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblInfoDatosProd
            // 
            this.lblInfoDatosProd.AutoSize = true;
            this.lblInfoDatosProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoDatosProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDatosProd.Location = new System.Drawing.Point(48, 61);
            this.lblInfoDatosProd.Name = "lblInfoDatosProd";
            this.lblInfoDatosProd.Size = new System.Drawing.Size(246, 21);
            this.lblInfoDatosProd.TabIndex = 71;
            this.lblInfoDatosProd.Text = "Ingrese el Nombre del Producto";
            this.lblInfoDatosProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxNombreProd
            // 
            this.txtBoxNombreProd.Location = new System.Drawing.Point(72, 96);
            this.txtBoxNombreProd.Name = "txtBoxNombreProd";
            this.txtBoxNombreProd.Size = new System.Drawing.Size(206, 25);
            this.txtBoxNombreProd.TabIndex = 72;
            // 
            // grpDatosStock
            // 
            this.grpDatosStock.Controls.Add(this.lblContIdProd);
            this.grpDatosStock.Controls.Add(this.lblIdProd);
            this.grpDatosStock.Controls.Add(this.lblContStock);
            this.grpDatosStock.Controls.Add(this.lblPrecio);
            this.grpDatosStock.Controls.Add(this.lblStock);
            this.grpDatosStock.Controls.Add(this.lblContPrecio);
            this.grpDatosStock.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosStock.Location = new System.Drawing.Point(72, 130);
            this.grpDatosStock.Name = "grpDatosStock";
            this.grpDatosStock.Size = new System.Drawing.Size(365, 172);
            this.grpDatosStock.TabIndex = 74;
            this.grpDatosStock.TabStop = false;
            this.grpDatosStock.Text = "Datos de Producto";
            // 
            // lblContIdProd
            // 
            this.lblContIdProd.BackColor = System.Drawing.Color.DarkGray;
            this.lblContIdProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContIdProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContIdProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContIdProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContIdProd.Location = new System.Drawing.Point(129, 33);
            this.lblContIdProd.Name = "lblContIdProd";
            this.lblContIdProd.Size = new System.Drawing.Size(230, 25);
            this.lblContIdProd.TabIndex = 80;
            this.lblContIdProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContStock
            // 
            this.lblContStock.BackColor = System.Drawing.Color.DarkGray;
            this.lblContStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContStock.Location = new System.Drawing.Point(129, 125);
            this.lblContStock.Name = "lblContStock";
            this.lblContStock.Size = new System.Drawing.Size(230, 25);
            this.lblContStock.TabIndex = 78;
            this.lblContStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(6, 125);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(105, 25);
            this.lblStock.TabIndex = 77;
            this.lblStock.Text = "Stock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdProd
            // 
            this.lblIdProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProd.Location = new System.Drawing.Point(6, 33);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(105, 25);
            this.lblIdProd.TabIndex = 79;
            this.lblIdProd.Text = "ID Producto";
            this.lblIdProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContPrecio
            // 
            this.lblContPrecio.BackColor = System.Drawing.Color.DarkGray;
            this.lblContPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContPrecio.Location = new System.Drawing.Point(129, 78);
            this.lblContPrecio.Name = "lblContPrecio";
            this.lblContPrecio.Size = new System.Drawing.Size(230, 25);
            this.lblContPrecio.TabIndex = 76;
            this.lblContPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(6, 78);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(105, 25);
            this.lblPrecio.TabIndex = 75;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpVenta
            // 
            this.grpVenta.Controls.Add(this.textBox1);
            this.grpVenta.Controls.Add(this.lblCantidad);
            this.grpVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVenta.Location = new System.Drawing.Point(72, 321);
            this.grpVenta.Name = "grpVenta";
            this.grpVenta.Size = new System.Drawing.Size(365, 233);
            this.grpVenta.TabIndex = 81;
            this.grpVenta.TabStop = false;
            this.grpVenta.Text = "Agregar al Carrito";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(130, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 25);
            this.textBox1.TabIndex = 44;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(6, 33);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(105, 25);
            this.lblCantidad.TabIndex = 43;
            this.lblCantidad.Text = "Nombre";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmVendNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.grpVenta);
            this.Controls.Add(this.grpDatosStock);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblInfoDatosProd);
            this.Controls.Add(this.txtBoxNombreProd);
            this.Controls.Add(this.panelAdmUsersAlta);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnCargarVenta);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVendNuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaVenta";
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.grpDatosStock.ResumeLayout(false);
            this.grpVenta.ResumeLayout(false);
            this.grpVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnLimpiarCampos;
        private FontAwesome.Sharp.IconButton btnCargarVenta;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label lblTop;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label lblInfoDatosProd;
        private System.Windows.Forms.TextBox txtBoxNombreProd;
        private System.Windows.Forms.GroupBox grpDatosStock;
        private System.Windows.Forms.Label lblContIdProd;
        private System.Windows.Forms.Label lblIdProd;
        private System.Windows.Forms.Label lblContStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblContPrecio;
        private System.Windows.Forms.GroupBox grpVenta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCantidad;
    }
}