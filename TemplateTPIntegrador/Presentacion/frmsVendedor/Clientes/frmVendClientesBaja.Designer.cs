﻿namespace Presentacion
{
    partial class frmVendClientesBaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendClientesBaja));
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.txtBoxBuscarClientePorDNI = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblInfoDatosCliente = new System.Windows.Forms.Label();
            this.btnEliminarCliente = new FontAwesome.Sharp.IconButton();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.lblContDni = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblContFechaAlta = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblContApellido = new System.Windows.Forms.Label();
            this.lblContNombre = new System.Windows.Forms.Label();
            this.panelAdmUsersAlta.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.grpCliente.SuspendLayout();
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
            this.lblTop.Text = "Clientes - Baja cliente";
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
            // txtBoxBuscarClientePorDNI
            // 
            this.txtBoxBuscarClientePorDNI.Location = new System.Drawing.Point(47, 68);
            this.txtBoxBuscarClientePorDNI.Name = "txtBoxBuscarClientePorDNI";
            this.txtBoxBuscarClientePorDNI.Size = new System.Drawing.Size(206, 25);
            this.txtBoxBuscarClientePorDNI.TabIndex = 24;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(105, 25);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(7, 117);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(105, 25);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoDatosCliente
            // 
            this.lblInfoDatosCliente.AutoSize = true;
            this.lblInfoDatosCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoDatosCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDatosCliente.Location = new System.Drawing.Point(23, 33);
            this.lblInfoDatosCliente.Name = "lblInfoDatosCliente";
            this.lblInfoDatosCliente.Size = new System.Drawing.Size(291, 21);
            this.lblInfoDatosCliente.TabIndex = 22;
            this.lblInfoDatosCliente.Text = "Ingrese el DNI del cliente a dar de baja";
            this.lblInfoDatosCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnEliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarCliente.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCliente.IconSize = 30;
            this.btnEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCliente.Location = new System.Drawing.Point(757, 455);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(195, 41);
            this.btnEliminarCliente.TabIndex = 29;
            this.btnEliminarCliente.Text = "Baja";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LightSlateGray;
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
            this.btnVolver.Location = new System.Drawing.Point(26, 455);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 41);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarCliente.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCliente.IconSize = 30;
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(279, 62);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(133, 34);
            this.btnBuscarCliente.TabIndex = 34;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContenedor.Controls.Add(this.grpCliente);
            this.panelContenedor.Controls.Add(this.btnBuscarCliente);
            this.panelContenedor.Controls.Add(this.btnVolver);
            this.panelContenedor.Controls.Add(this.btnEliminarCliente);
            this.panelContenedor.Controls.Add(this.lblInfoDatosCliente);
            this.panelContenedor.Controls.Add(this.txtBoxBuscarClientePorDNI);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(18, 56);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(976, 510);
            this.panelContenedor.TabIndex = 33;
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.lblContDni);
            this.grpCliente.Controls.Add(this.lblDni);
            this.grpCliente.Controls.Add(this.lblContFechaAlta);
            this.grpCliente.Controls.Add(this.lblFechaAlta);
            this.grpCliente.Controls.Add(this.lblContApellido);
            this.grpCliente.Controls.Add(this.lblContNombre);
            this.grpCliente.Controls.Add(this.lblNombre);
            this.grpCliente.Controls.Add(this.lblApellido);
            this.grpCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCliente.Location = new System.Drawing.Point(516, 33);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(436, 287);
            this.grpCliente.TabIndex = 35;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Datos del cliente";
            // 
            // lblContDni
            // 
            this.lblContDni.BackColor = System.Drawing.Color.DarkGray;
            this.lblContDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContDni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContDni.Location = new System.Drawing.Point(130, 189);
            this.lblContDni.Name = "lblContDni";
            this.lblContDni.Size = new System.Drawing.Size(230, 25);
            this.lblContDni.TabIndex = 39;
            this.lblContDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDni
            // 
            this.lblDni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(7, 189);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(105, 25);
            this.lblDni.TabIndex = 38;
            this.lblDni.Text = "DNI";
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContFechaAlta
            // 
            this.lblContFechaAlta.BackColor = System.Drawing.Color.DarkGray;
            this.lblContFechaAlta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContFechaAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContFechaAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContFechaAlta.Location = new System.Drawing.Point(130, 250);
            this.lblContFechaAlta.Name = "lblContFechaAlta";
            this.lblContFechaAlta.Size = new System.Drawing.Size(230, 25);
            this.lblContFechaAlta.TabIndex = 37;
            this.lblContFechaAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.Location = new System.Drawing.Point(7, 250);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(105, 25);
            this.lblFechaAlta.TabIndex = 36;
            this.lblFechaAlta.Text = "Fecha de alta";
            this.lblFechaAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContApellido
            // 
            this.lblContApellido.BackColor = System.Drawing.Color.DarkGray;
            this.lblContApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContApellido.Location = new System.Drawing.Point(129, 118);
            this.lblContApellido.Name = "lblContApellido";
            this.lblContApellido.Size = new System.Drawing.Size(230, 25);
            this.lblContApellido.TabIndex = 34;
            this.lblContApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContNombre
            // 
            this.lblContNombre.BackColor = System.Drawing.Color.DarkGray;
            this.lblContNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContNombre.Location = new System.Drawing.Point(129, 47);
            this.lblContNombre.Name = "lblContNombre";
            this.lblContNombre.Size = new System.Drawing.Size(230, 25);
            this.lblContNombre.TabIndex = 33;
            this.lblContNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmVendClientesBaja
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
            this.Name = "frmVendClientesBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedores - Baja Cliente";
            this.Load += new System.EventHandler(this.frmVendClientesBaja_Load);
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.grpCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.TextBox txtBoxBuscarClientePorDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblInfoDatosCliente;
        private FontAwesome.Sharp.IconButton btnEliminarCliente;
        private FontAwesome.Sharp.IconButton btnVolver;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Label lblContApellido;
        private System.Windows.Forms.Label lblContNombre;
        private System.Windows.Forms.Label lblContDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblContFechaAlta;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.TextBox txtDni;


    }
}