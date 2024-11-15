namespace Presentacion.frmsVendedor
{
    partial class frmVendProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendProductos));
            this.lblTop = new System.Windows.Forms.Label();
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.VendProductos = new System.Windows.Forms.Label();
            this.btnListarProductos = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProdActivos = new System.Windows.Forms.Label();
            this.lblTopProdActivos = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelAdmUsersAlta.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(22, 7);
            this.lblTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(312, 26);
            this.lblTop.TabIndex = 65;
            this.lblTop.Text = "Panel de Vendedor - Ingrese nueva venta\r\n";
            // 
            // panelAdmUsersAlta
            // 
            this.panelAdmUsersAlta.Controls.Add(this.VendProductos);
            this.panelAdmUsersAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmUsersAlta.Location = new System.Drawing.Point(0, 0);
            this.panelAdmUsersAlta.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdmUsersAlta.Name = "panelAdmUsersAlta";
            this.panelAdmUsersAlta.Size = new System.Drawing.Size(994, 37);
            this.panelAdmUsersAlta.TabIndex = 66;
            // 
            // VendProductos
            // 
            this.VendProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendProductos.Location = new System.Drawing.Point(4, 6);
            this.VendProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VendProductos.Name = "VendProductos";
            this.VendProductos.Size = new System.Drawing.Size(422, 26);
            this.VendProductos.TabIndex = 7;
            this.VendProductos.Text = "Panel de Vendedor - Productos";
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnListarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarProductos.FlatAppearance.BorderSize = 0;
            this.btnListarProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnListarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnListarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProductos.IconChar = FontAwesome.Sharp.IconChar.ClipboardQuestion;
            this.btnListarProductos.IconColor = System.Drawing.Color.Black;
            this.btnListarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarProductos.IconSize = 30;
            this.btnListarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarProductos.Location = new System.Drawing.Point(387, 209);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(220, 56);
            this.btnListarProductos.TabIndex = 68;
            this.btnListarProductos.Text = "Listar Productos";
            this.btnListarProductos.UseVisualStyleBackColor = false;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblProdActivos);
            this.panel2.Controls.Add(this.lblTopProdActivos);
            this.panel2.Controls.Add(this.guna2CirclePictureBox2);
            this.panel2.Location = new System.Drawing.Point(387, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 119);
            this.panel2.TabIndex = 67;
            // 
            // lblProdActivos
            // 
            this.lblProdActivos.AutoSize = true;
            this.lblProdActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdActivos.Location = new System.Drawing.Point(119, 49);
            this.lblProdActivos.Name = "lblProdActivos";
            this.lblProdActivos.Size = new System.Drawing.Size(32, 15);
            this.lblProdActivos.TabIndex = 14;
            this.lblProdActivos.Text = "Total";
            this.lblProdActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopProdActivos
            // 
            this.lblTopProdActivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopProdActivos.Location = new System.Drawing.Point(73, 26);
            this.lblTopProdActivos.Name = "lblTopProdActivos";
            this.lblTopProdActivos.Size = new System.Drawing.Size(136, 23);
            this.lblTopProdActivos.TabIndex = 12;
            this.lblTopProdActivos.Text = "Productos Activos";
            this.lblTopProdActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(3, 26);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 13;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // frmVendProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.btnListarProductos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelAdmUsersAlta);
            this.Controls.Add(this.lblTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVendProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedor - Productos";
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label VendProductos;
        private FontAwesome.Sharp.IconButton btnListarProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProdActivos;
        private System.Windows.Forms.Label lblTopProdActivos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
    }
}