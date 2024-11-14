namespace Presentacion.frmsVendedor
{
    partial class frmVendClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendClientes));
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.VendProductos = new System.Windows.Forms.Label();
            this.btnReactivarCliente = new FontAwesome.Sharp.IconButton();
            this.btnListarClientes = new FontAwesome.Sharp.IconButton();
            this.btnEliminarCliente = new FontAwesome.Sharp.IconButton();
            this.btnModificarCliente = new FontAwesome.Sharp.IconButton();
            this.btnAltaCliente = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClientesActivos = new System.Windows.Forms.Label();
            this.lblDescClientesActivos = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelAdmUsersAlta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdmUsersAlta
            // 
            this.panelAdmUsersAlta.Controls.Add(this.VendProductos);
            this.panelAdmUsersAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmUsersAlta.Location = new System.Drawing.Point(0, 0);
            this.panelAdmUsersAlta.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdmUsersAlta.Name = "panelAdmUsersAlta";
            this.panelAdmUsersAlta.Size = new System.Drawing.Size(994, 37);
            this.panelAdmUsersAlta.TabIndex = 69;
            // 
            // VendProductos
            // 
            this.VendProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendProductos.Location = new System.Drawing.Point(2, 6);
            this.VendProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VendProductos.Name = "VendProductos";
            this.VendProductos.Size = new System.Drawing.Size(424, 26);
            this.VendProductos.TabIndex = 7;
            this.VendProductos.Text = "Panel de Vendedor - Clientes";
            // 
            // btnReactivarCliente
            // 
            this.btnReactivarCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReactivarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReactivarCliente.FlatAppearance.BorderSize = 0;
            this.btnReactivarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnReactivarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReactivarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReactivarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReactivarCliente.IconChar = FontAwesome.Sharp.IconChar.CreativeCommonsSa;
            this.btnReactivarCliente.IconColor = System.Drawing.Color.Black;
            this.btnReactivarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReactivarCliente.IconSize = 30;
            this.btnReactivarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReactivarCliente.Location = new System.Drawing.Point(387, 243);
            this.btnReactivarCliente.Name = "btnReactivarCliente";
            this.btnReactivarCliente.Size = new System.Drawing.Size(220, 56);
            this.btnReactivarCliente.TabIndex = 75;
            this.btnReactivarCliente.Text = "Reactivar Clientes";
            this.btnReactivarCliente.UseVisualStyleBackColor = false;
            this.btnReactivarCliente.Click += new System.EventHandler(this.btnReactivarCliente_Click);
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnListarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarClientes.FlatAppearance.BorderSize = 0;
            this.btnListarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnListarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnListarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarClientes.IconChar = FontAwesome.Sharp.IconChar.PersonCircleQuestion;
            this.btnListarClientes.IconColor = System.Drawing.Color.Black;
            this.btnListarClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarClientes.IconSize = 30;
            this.btnListarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarClientes.Location = new System.Drawing.Point(387, 168);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(220, 56);
            this.btnListarClientes.TabIndex = 74;
            this.btnListarClientes.Text = "Listar Clientes";
            this.btnListarClientes.UseVisualStyleBackColor = false;
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnEliminarCliente.IconColor = System.Drawing.Color.Black;
            this.btnEliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCliente.IconSize = 30;
            this.btnEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCliente.Location = new System.Drawing.Point(387, 468);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(220, 56);
            this.btnEliminarCliente.TabIndex = 73;
            this.btnEliminarCliente.Text = "Eliminar Clientes";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificarCliente.IconColor = System.Drawing.Color.Black;
            this.btnModificarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarCliente.IconSize = 30;
            this.btnModificarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCliente.Location = new System.Drawing.Point(387, 393);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(220, 56);
            this.btnModificarCliente.TabIndex = 72;
            this.btnModificarCliente.Text = "Modificar Clientes";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAltaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaCliente.FlatAppearance.BorderSize = 0;
            this.btnAltaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAltaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAltaCliente.IconColor = System.Drawing.Color.Black;
            this.btnAltaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltaCliente.IconSize = 30;
            this.btnAltaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaCliente.Location = new System.Drawing.Point(387, 318);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(220, 56);
            this.btnAltaCliente.TabIndex = 71;
            this.btnAltaCliente.Text = "Agregar Clientes";
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblClientesActivos);
            this.panel1.Controls.Add(this.lblDescClientesActivos);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Location = new System.Drawing.Point(387, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 119);
            this.panel1.TabIndex = 70;
            // 
            // lblClientesActivos
            // 
            this.lblClientesActivos.AutoSize = true;
            this.lblClientesActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesActivos.Location = new System.Drawing.Point(116, 49);
            this.lblClientesActivos.Name = "lblClientesActivos";
            this.lblClientesActivos.Size = new System.Drawing.Size(32, 15);
            this.lblClientesActivos.TabIndex = 11;
            this.lblClientesActivos.Text = "Total";
            this.lblClientesActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescClientesActivos
            // 
            this.lblDescClientesActivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescClientesActivos.Location = new System.Drawing.Point(70, 26);
            this.lblDescClientesActivos.Name = "lblDescClientesActivos";
            this.lblDescClientesActivos.Size = new System.Drawing.Size(136, 23);
            this.lblDescClientesActivos.TabIndex = 10;
            this.lblDescClientesActivos.Text = "Clientes Activos";
            this.lblDescClientesActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 26);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 10;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // frmVendClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.btnReactivarCliente);
            this.Controls.Add(this.btnListarClientes);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAdmUsersAlta);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVendClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedor - Clientes";
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label VendProductos;
        private FontAwesome.Sharp.IconButton btnReactivarCliente;
        private FontAwesome.Sharp.IconButton btnListarClientes;
        private FontAwesome.Sharp.IconButton btnEliminarCliente;
        private FontAwesome.Sharp.IconButton btnModificarCliente;
        private FontAwesome.Sharp.IconButton btnAltaCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClientesActivos;
        private System.Windows.Forms.Label lblDescClientesActivos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}