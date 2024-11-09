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
            this.lblHost = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblInfoDatosUser = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblProductoID = new System.Windows.Forms.Label();
            this.lblVentaID = new System.Windows.Forms.Label();
            this.lblInfoDatosPers = new System.Windows.Forms.Label();
            this.cmbHost = new System.Windows.Forms.ComboBox();
            this.txtBoxContraseña = new System.Windows.Forms.TextBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtProductoID = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.txtVentaID = new System.Windows.Forms.TextBox();
            this.panelAdmUsersAlta.SuspendLayout();
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
            this.btnLimpiarCampos.Location = new System.Drawing.Point(82, 514);
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
            this.btnCargarVenta.Location = new System.Drawing.Point(707, 514);
            this.btnCargarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarVenta.Name = "btnCargarVenta";
            this.btnCargarVenta.Size = new System.Drawing.Size(195, 41);
            this.btnCargarVenta.TabIndex = 37;
            this.btnCargarVenta.Text = "Guardar";
            this.btnCargarVenta.UseVisualStyleBackColor = false;
            this.btnCargarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // lblHost
            // 
            this.lblHost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHost.Location = new System.Drawing.Point(612, 209);
            this.lblHost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(92, 25);
            this.lblHost.TabIndex = 58;
            this.lblHost.Text = "Rol";
            this.lblHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContraseña
            // 
            this.lblContraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblContraseña.Location = new System.Drawing.Point(612, 164);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(92, 25);
            this.lblContraseña.TabIndex = 56;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsuario.Location = new System.Drawing.Point(612, 117);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(92, 25);
            this.lblUsuario.TabIndex = 54;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoDatosUser
            // 
            this.lblInfoDatosUser.AutoSize = true;
            this.lblInfoDatosUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoDatosUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDatosUser.Location = new System.Drawing.Point(598, 77);
            this.lblInfoDatosUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoDatosUser.Name = "lblInfoDatosUser";
            this.lblInfoDatosUser.Size = new System.Drawing.Size(168, 28);
            this.lblInfoDatosUser.TabIndex = 53;
            this.lblInfoDatosUser.Text = "Datos de Usuario";
            this.lblInfoDatosUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstado.Location = new System.Drawing.Point(79, 348);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(92, 24);
            this.lblEstado.TabIndex = 47;
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Location = new System.Drawing.Point(79, 302);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(92, 24);
            this.lblCantidad.TabIndex = 49;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClienteID
            // 
            this.lblClienteID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblClienteID.Location = new System.Drawing.Point(79, 164);
            this.lblClienteID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(92, 24);
            this.lblClienteID.TabIndex = 51;
            this.lblClienteID.Text = "ID Cliente";
            this.lblClienteID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescripcion.Location = new System.Drawing.Point(78, 256);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 24);
            this.lblDescripcion.TabIndex = 45;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductoID
            // 
            this.lblProductoID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductoID.Location = new System.Drawing.Point(78, 210);
            this.lblProductoID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductoID.Name = "lblProductoID";
            this.lblProductoID.Size = new System.Drawing.Size(92, 24);
            this.lblProductoID.TabIndex = 43;
            this.lblProductoID.Text = "ID Producto";
            this.lblProductoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVentaID
            // 
            this.lblVentaID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblVentaID.Location = new System.Drawing.Point(79, 118);
            this.lblVentaID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVentaID.Name = "lblVentaID";
            this.lblVentaID.Size = new System.Drawing.Size(92, 24);
            this.lblVentaID.TabIndex = 40;
            this.lblVentaID.Text = "ID Venta";
            this.lblVentaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoDatosPers
            // 
            this.lblInfoDatosPers.AutoSize = true;
            this.lblInfoDatosPers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoDatosPers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDatosPers.Location = new System.Drawing.Point(62, 77);
            this.lblInfoDatosPers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoDatosPers.Name = "lblInfoDatosPers";
            this.lblInfoDatosPers.Size = new System.Drawing.Size(167, 28);
            this.lblInfoDatosPers.TabIndex = 42;
            this.lblInfoDatosPers.Text = "Datos Personales";
            this.lblInfoDatosPers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbHost
            // 
            this.cmbHost.FormattingEnabled = true;
            this.cmbHost.Location = new System.Drawing.Point(708, 209);
            this.cmbHost.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHost.Name = "cmbHost";
            this.cmbHost.Size = new System.Drawing.Size(194, 29);
            this.cmbHost.TabIndex = 59;
            // 
            // txtBoxContraseña
            // 
            this.txtBoxContraseña.Location = new System.Drawing.Point(708, 164);
            this.txtBoxContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxContraseña.Name = "txtBoxContraseña";
            this.txtBoxContraseña.Size = new System.Drawing.Size(194, 29);
            this.txtBoxContraseña.TabIndex = 57;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(708, 117);
            this.txtBoxUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(194, 29);
            this.txtBoxUsuario.TabIndex = 55;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(177, 348);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(193, 29);
            this.txtEstado.TabIndex = 48;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(175, 302);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(193, 29);
            this.txtCantidad.TabIndex = 50;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(177, 256);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(193, 29);
            this.txtDescripcion.TabIndex = 52;
            // 
            // txtProductoID
            // 
            this.txtProductoID.Location = new System.Drawing.Point(177, 210);
            this.txtProductoID.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductoID.Name = "txtProductoID";
            this.txtProductoID.Size = new System.Drawing.Size(193, 29);
            this.txtProductoID.TabIndex = 46;
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(177, 164);
            this.txtClienteID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(193, 29);
            this.txtClienteID.TabIndex = 44;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Teal;
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(14, 566);
            this.panelSide.TabIndex = 63;
            // 
            // panelAdmUsersAlta
            // 
            this.panelAdmUsersAlta.Controls.Add(this.lblTop);
            this.panelAdmUsersAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmUsersAlta.Location = new System.Drawing.Point(14, 0);
            this.panelAdmUsersAlta.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdmUsersAlta.Name = "panelAdmUsersAlta";
            this.panelAdmUsersAlta.Size = new System.Drawing.Size(980, 46);
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
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(177, 394);
            this.dtpFechaVenta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(193, 29);
            this.dtpFechaVenta.TabIndex = 65;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaVenta.Location = new System.Drawing.Point(79, 394);
            this.lblFechaVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(92, 24);
            this.lblFechaVenta.TabIndex = 66;
            this.lblFechaVenta.Text = "Fecha";
            this.lblFechaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVentaID
            // 
            this.txtVentaID.Location = new System.Drawing.Point(175, 117);
            this.txtVentaID.Margin = new System.Windows.Forms.Padding(2);
            this.txtVentaID.Name = "txtVentaID";
            this.txtVentaID.Size = new System.Drawing.Size(193, 29);
            this.txtVentaID.TabIndex = 68;
            // 
            // frmVendNuevaVenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.txtVentaID);
            this.Controls.Add(this.lblFechaVenta);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.panelAdmUsersAlta);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblInfoDatosUser);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblProductoID);
            this.Controls.Add(this.lblVentaID);
            this.Controls.Add(this.lblInfoDatosPers);
            this.Controls.Add(this.cmbHost);
            this.Controls.Add(this.txtBoxContraseña);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtProductoID);
            this.Controls.Add(this.txtClienteID);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnLimpiarCampos;
        private FontAwesome.Sharp.IconButton btnCargarVenta;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblInfoDatosUser;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblProductoID;
        private System.Windows.Forms.Label lblVentaID;
        private System.Windows.Forms.Label lblInfoDatosPers;
        private System.Windows.Forms.ComboBox cmbHost;
        private System.Windows.Forms.TextBox txtBoxContraseña;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtProductoID;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.TextBox txtVentaID;
    }
}