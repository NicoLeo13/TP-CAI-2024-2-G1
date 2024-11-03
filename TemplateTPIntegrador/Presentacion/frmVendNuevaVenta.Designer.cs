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
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarCampos = new FontAwesome.Sharp.IconButton();
            this.btnCargarVenta = new FontAwesome.Sharp.IconButton();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblInfoDatosUser = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblInfoDatosPers = new System.Windows.Forms.Label();
            this.comboBoxHost = new System.Windows.Forms.ComboBox();
            this.txtBoxContraseña = new System.Windows.Forms.TextBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxDni = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Panel de Vendedor - Ingrese nueva venta";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.btnVolver.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 30;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(25, 495);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 41);
            this.btnVolver.TabIndex = 39;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            this.btnLimpiarCampos.Location = new System.Drawing.Point(776, 495);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnCargarVenta.Location = new System.Drawing.Point(374, 495);
            this.btnCargarVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargarVenta.Name = "btnCargarVenta";
            this.btnCargarVenta.Size = new System.Drawing.Size(195, 41);
            this.btnCargarVenta.TabIndex = 37;
            this.btnCargarVenta.Text = "Guardar";
            this.btnCargarVenta.UseVisualStyleBackColor = false;
            this.btnCargarVenta.Click += new System.EventHandler(this.btnCargarVenta_Click);
            // 
            // lblHost
            // 
            this.lblHost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHost.Location = new System.Drawing.Point(33, 333);
            this.lblHost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(68, 20);
            this.lblHost.TabIndex = 58;
            this.lblHost.Text = "Rol";
            this.lblHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContraseña
            // 
            this.lblContraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblContraseña.Location = new System.Drawing.Point(33, 304);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(79, 20);
            this.lblContraseña.TabIndex = 56;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsuario.Location = new System.Drawing.Point(33, 277);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 54;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoDatosUser
            // 
            this.lblInfoDatosUser.AutoSize = true;
            this.lblInfoDatosUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoDatosUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDatosUser.Location = new System.Drawing.Point(21, 248);
            this.lblInfoDatosUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoDatosUser.Name = "lblInfoDatosUser";
            this.lblInfoDatosUser.Size = new System.Drawing.Size(134, 21);
            this.lblInfoDatosUser.TabIndex = 53;
            this.lblInfoDatosUser.Text = "Datos de Usuario";
            this.lblInfoDatosUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDni
            // 
            this.lblDni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDni.Location = new System.Drawing.Point(37, 202);
            this.lblDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(79, 20);
            this.lblDni.TabIndex = 47;
            this.lblDni.Text = "DNI";
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Location = new System.Drawing.Point(37, 176);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(79, 20);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelefono
            // 
            this.lblTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTelefono.Location = new System.Drawing.Point(37, 151);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 20);
            this.lblTelefono.TabIndex = 51;
            this.lblTelefono.Text = "Teléfono";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDireccion
            // 
            this.lblDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDireccion.Location = new System.Drawing.Point(37, 126);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(79, 20);
            this.lblDireccion.TabIndex = 45;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblApellido.Location = new System.Drawing.Point(37, 101);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(79, 20);
            this.lblApellido.TabIndex = 43;
            this.lblApellido.Text = "ID producto";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(38, 76);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 20);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.Text = "ID proveedor";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoDatosPers
            // 
            this.lblInfoDatosPers.AutoSize = true;
            this.lblInfoDatosPers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoDatosPers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDatosPers.Location = new System.Drawing.Point(21, 50);
            this.lblInfoDatosPers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoDatosPers.Name = "lblInfoDatosPers";
            this.lblInfoDatosPers.Size = new System.Drawing.Size(133, 21);
            this.lblInfoDatosPers.TabIndex = 42;
            this.lblInfoDatosPers.Text = "Datos Personales";
            this.lblInfoDatosPers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxHost
            // 
            this.comboBoxHost.FormattingEnabled = true;
            this.comboBoxHost.Location = new System.Drawing.Point(114, 330);
            this.comboBoxHost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxHost.Name = "comboBoxHost";
            this.comboBoxHost.Size = new System.Drawing.Size(194, 21);
            this.comboBoxHost.TabIndex = 59;
            // 
            // txtBoxContraseña
            // 
            this.txtBoxContraseña.Location = new System.Drawing.Point(115, 301);
            this.txtBoxContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxContraseña.Name = "txtBoxContraseña";
            this.txtBoxContraseña.Size = new System.Drawing.Size(194, 20);
            this.txtBoxContraseña.TabIndex = 57;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(115, 274);
            this.txtBoxUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(194, 20);
            this.txtBoxUsuario.TabIndex = 55;
            // 
            // txtBoxDni
            // 
            this.txtBoxDni.Location = new System.Drawing.Point(119, 202);
            this.txtBoxDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxDni.Name = "txtBoxDni";
            this.txtBoxDni.Size = new System.Drawing.Size(194, 20);
            this.txtBoxDni.TabIndex = 48;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(120, 177);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(194, 20);
            this.txtBoxEmail.TabIndex = 50;
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Location = new System.Drawing.Point(120, 152);
            this.txtBoxTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(194, 20);
            this.txtBoxTelefono.TabIndex = 52;
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(120, 127);
            this.txtBoxDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(194, 20);
            this.txtBoxDireccion.TabIndex = 46;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(120, 102);
            this.txtBoxApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(194, 20);
            this.txtBoxApellido.TabIndex = 44;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(119, 76);
            this.txtBoxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(194, 20);
            this.txtBoxNombre.TabIndex = 41;
            // 
            // frmVendNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblInfoDatosUser);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblInfoDatosPers);
            this.Controls.Add(this.comboBoxHost);
            this.Controls.Add(this.txtBoxContraseña);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.txtBoxDni);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxTelefono);
            this.Controls.Add(this.txtBoxDireccion);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnCargarVenta);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVendNuevaVenta";
            this.Text = "NuevaVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnVolver;
        private FontAwesome.Sharp.IconButton btnLimpiarCampos;
        private FontAwesome.Sharp.IconButton btnCargarVenta;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblInfoDatosUser;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblInfoDatosPers;
        private System.Windows.Forms.ComboBox comboBoxHost;
        private System.Windows.Forms.TextBox txtBoxContraseña;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.TextBox txtBoxDni;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxNombre;
    }
}