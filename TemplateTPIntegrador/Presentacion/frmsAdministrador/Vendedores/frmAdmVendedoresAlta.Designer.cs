﻿namespace Presentacion
{
    partial class frmAdmVendedoresAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmVendedoresAlta));
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnGuardarVendedor = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarCampos = new FontAwesome.Sharp.IconButton();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.grpDatosUser = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxContraseña = new System.Windows.Forms.TextBox();
            this.grpDatosPers = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtBoxDni = new System.Windows.Forms.TextBox();
            this.panelAdmUsersAlta.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.grpDatosUser.SuspendLayout();
            this.grpDatosPers.SuspendLayout();
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
            this.lblTop.Text = "Panel de Vendedores - Agregar Vendedores";
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
            // btnGuardarVendedor
            // 
            this.btnGuardarVendedor.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardarVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarVendedor.FlatAppearance.BorderSize = 0;
            this.btnGuardarVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnGuardarVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarVendedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarVendedor.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarVendedor.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarVendedor.IconSize = 30;
            this.btnGuardarVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarVendedor.Location = new System.Drawing.Point(370, 460);
            this.btnGuardarVendedor.Name = "btnGuardarVendedor";
            this.btnGuardarVendedor.Size = new System.Drawing.Size(195, 41);
            this.btnGuardarVendedor.TabIndex = 29;
            this.btnGuardarVendedor.Text = "Guardar";
            this.btnGuardarVendedor.UseVisualStyleBackColor = false;
            this.btnGuardarVendedor.Click += new System.EventHandler(this.btnGuardarVendedor_Click);
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
            this.btnLimpiarCampos.Location = new System.Drawing.Point(754, 460);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(195, 41);
            this.btnLimpiarCampos.TabIndex = 30;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SlateGray;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.btnVolver.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 30;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(27, 460);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 41);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Controls.Add(this.grpDatosUser);
            this.panelContenedor.Controls.Add(this.grpDatosPers);
            this.panelContenedor.Controls.Add(this.btnVolver);
            this.panelContenedor.Controls.Add(this.btnLimpiarCampos);
            this.panelContenedor.Controls.Add(this.btnGuardarVendedor);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(18, 56);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(976, 510);
            this.panelContenedor.TabIndex = 33;
            // 
            // grpDatosUser
            // 
            this.grpDatosUser.Controls.Add(this.label1);
            this.grpDatosUser.Controls.Add(this.txtBoxUsuario);
            this.grpDatosUser.Controls.Add(this.label2);
            this.grpDatosUser.Controls.Add(this.txtBoxContraseña);
            this.grpDatosUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosUser.Location = new System.Drawing.Point(538, 26);
            this.grpDatosUser.Name = "grpDatosUser";
            this.grpDatosUser.Size = new System.Drawing.Size(410, 159);
            this.grpDatosUser.TabIndex = 36;
            this.grpDatosUser.TabStop = false;
            this.grpDatosUser.Text = "Datos de Usuario Vendedor";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(116, 36);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(257, 29);
            this.txtBoxUsuario.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxContraseña
            // 
            this.txtBoxContraseña.Location = new System.Drawing.Point(116, 85);
            this.txtBoxContraseña.Name = "txtBoxContraseña";
            this.txtBoxContraseña.Size = new System.Drawing.Size(257, 29);
            this.txtBoxContraseña.TabIndex = 26;
            // 
            // grpDatosPers
            // 
            this.grpDatosPers.Controls.Add(this.lblNombre);
            this.grpDatosPers.Controls.Add(this.txtBoxNombre);
            this.grpDatosPers.Controls.Add(this.lblApellido);
            this.grpDatosPers.Controls.Add(this.txtBoxApellido);
            this.grpDatosPers.Controls.Add(this.lblDireccion);
            this.grpDatosPers.Controls.Add(this.txtBoxDireccion);
            this.grpDatosPers.Controls.Add(this.lblTelefono);
            this.grpDatosPers.Controls.Add(this.txtBoxTelefono);
            this.grpDatosPers.Controls.Add(this.lblFechaNacimiento);
            this.grpDatosPers.Controls.Add(this.lblEmail);
            this.grpDatosPers.Controls.Add(this.lblDni);
            this.grpDatosPers.Controls.Add(this.txtBoxEmail);
            this.grpDatosPers.Controls.Add(this.dtpFechaNac);
            this.grpDatosPers.Controls.Add(this.txtBoxDni);
            this.grpDatosPers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosPers.Location = new System.Drawing.Point(27, 26);
            this.grpDatosPers.Name = "grpDatosPers";
            this.grpDatosPers.Size = new System.Drawing.Size(454, 395);
            this.grpDatosPers.TabIndex = 35;
            this.grpDatosPers.TabStop = false;
            this.grpDatosPers.Text = "Datos Personales";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(34, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(105, 25);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(144, 35);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(257, 29);
            this.txtBoxNombre.TabIndex = 10;
            // 
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(34, 84);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(105, 25);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(144, 85);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(257, 29);
            this.txtBoxApellido.TabIndex = 13;
            // 
            // lblDireccion
            // 
            this.lblDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(34, 134);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(105, 25);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(144, 135);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(257, 29);
            this.txtBoxDireccion.TabIndex = 15;
            // 
            // lblTelefono
            // 
            this.lblTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(34, 184);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(105, 25);
            this.lblTelefono.TabIndex = 20;
            this.lblTelefono.Text = "Teléfono";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Location = new System.Drawing.Point(146, 185);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(257, 29);
            this.txtBoxTelefono.TabIndex = 21;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(34, 331);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(105, 36);
            this.lblFechaNacimiento.TabIndex = 32;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            this.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(33, 234);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(105, 25);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDni
            // 
            this.lblDni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(33, 284);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(105, 25);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "DNI";
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(145, 235);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(257, 29);
            this.txtBoxEmail.TabIndex = 19;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Location = new System.Drawing.Point(145, 335);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(257, 25);
            this.dtpFechaNac.TabIndex = 33;
            // 
            // txtBoxDni
            // 
            this.txtBoxDni.Location = new System.Drawing.Point(144, 285);
            this.txtBoxDni.Name = "txtBoxDni";
            this.txtBoxDni.Size = new System.Drawing.Size(257, 29);
            this.txtBoxDni.TabIndex = 17;
            // 
            // frmAdmVendedoresAlta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelAdmUsersAlta);
            this.Controls.Add(this.panelSide);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmVendedoresAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmUsuariosAlta";
            this.Load += new System.EventHandler(this.frmAdmUsuariosAlta_Load);
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.grpDatosUser.ResumeLayout(false);
            this.grpDatosUser.PerformLayout();
            this.grpDatosPers.ResumeLayout(false);
            this.grpDatosPers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panelSide;
        private FontAwesome.Sharp.IconButton btnGuardarVendedor;
        private FontAwesome.Sharp.IconButton btnLimpiarCampos;
        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.GroupBox grpDatosPers;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtBoxDni;
        private System.Windows.Forms.GroupBox grpDatosUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxContraseña;
    }
}