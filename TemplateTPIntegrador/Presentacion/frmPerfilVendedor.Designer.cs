namespace Presentacion
{
    partial class frmPerfilVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilVendedor));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblDescSistema = new System.Windows.Forms.Label();
            this.lblTopTitulo = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnVendLogout = new FontAwesome.Sharp.IconButton();
            this.btnVendReportes = new FontAwesome.Sharp.IconButton();
            this.btnVendProduct = new FontAwesome.Sharp.IconButton();
            this.btnVendVenta = new FontAwesome.Sharp.IconButton();
            this.panelInfoUser = new System.Windows.Forms.Panel();
            this.lblVendRol = new System.Windows.Forms.Label();
            this.lblVendUser = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.panelInfoUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelTop.Controls.Add(this.lblDescSistema);
            this.panelTop.Controls.Add(this.lblTopTitulo);
            this.panelTop.Controls.Add(this.guna2PictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1174, 75);
            this.panelTop.TabIndex = 12;
            // 
            // lblDescSistema
            // 
            this.lblDescSistema.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSistema.Location = new System.Drawing.Point(963, 39);
            this.lblDescSistema.Name = "lblDescSistema";
            this.lblDescSistema.Size = new System.Drawing.Size(208, 27);
            this.lblDescSistema.TabIndex = 16;
            this.lblDescSistema.Text = "Sistema de Gestión";
            // 
            // lblTopTitulo
            // 
            this.lblTopTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitulo.Location = new System.Drawing.Point(80, 9);
            this.lblTopTitulo.Name = "lblTopTitulo";
            this.lblTopTitulo.Size = new System.Drawing.Size(263, 44);
            this.lblTopTitulo.TabIndex = 15;
            this.lblTopTitulo.Text = "ElectroHogar SA";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(62, 50);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelOpciones.Controls.Add(this.btnVendLogout);
            this.panelOpciones.Controls.Add(this.btnVendReportes);
            this.panelOpciones.Controls.Add(this.btnVendProduct);
            this.panelOpciones.Controls.Add(this.btnVendVenta);
            this.panelOpciones.Controls.Add(this.panelInfoUser);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 75);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(180, 566);
            this.panelOpciones.TabIndex = 13;
            // 
            // btnVendLogout
            // 
            this.btnVendLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnVendLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVendLogout.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVendLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnVendLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnVendLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVendLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnVendLogout.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnVendLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendLogout.IconSize = 30;
            this.btnVendLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendLogout.Location = new System.Drawing.Point(0, 510);
            this.btnVendLogout.Name = "btnVendLogout";
            this.btnVendLogout.Size = new System.Drawing.Size(180, 56);
            this.btnVendLogout.TabIndex = 21;
            this.btnVendLogout.Text = "Cerrar Sesión";
            this.btnVendLogout.UseVisualStyleBackColor = false;
            this.btnVendLogout.Click += new System.EventHandler(this.btnVendLogout_Click);
            // 
            // btnVendReportes
            // 
            this.btnVendReportes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVendReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendReportes.FlatAppearance.BorderSize = 0;
            this.btnVendReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnVendReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendReportes.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnVendReportes.IconColor = System.Drawing.Color.Black;
            this.btnVendReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendReportes.IconSize = 30;
            this.btnVendReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendReportes.Location = new System.Drawing.Point(0, 258);
            this.btnVendReportes.Name = "btnVendReportes";
            this.btnVendReportes.Size = new System.Drawing.Size(180, 56);
            this.btnVendReportes.TabIndex = 19;
            this.btnVendReportes.Text = "Reportes";
            this.btnVendReportes.UseVisualStyleBackColor = false;
            this.btnVendReportes.Click += new System.EventHandler(this.btnVendReportes_Click);
            this.btnVendReportes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnVendReportes.MouseEnter += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnVendProduct
            // 
            this.btnVendProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVendProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendProduct.FlatAppearance.BorderSize = 0;
            this.btnVendProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnVendProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendProduct.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnVendProduct.IconColor = System.Drawing.Color.Black;
            this.btnVendProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendProduct.IconSize = 30;
            this.btnVendProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendProduct.Location = new System.Drawing.Point(0, 202);
            this.btnVendProduct.Name = "btnVendProduct";
            this.btnVendProduct.Size = new System.Drawing.Size(180, 56);
            this.btnVendProduct.TabIndex = 18;
            this.btnVendProduct.Text = "Productos";
            this.btnVendProduct.UseVisualStyleBackColor = false;
            this.btnVendProduct.Click += new System.EventHandler(this.btnVendProduct_Click);
            this.btnVendProduct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnVendProduct.MouseEnter += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnVendVenta
            // 
            this.btnVendVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVendVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendVenta.FlatAppearance.BorderSize = 0;
            this.btnVendVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnVendVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendVenta.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.btnVendVenta.IconColor = System.Drawing.Color.Black;
            this.btnVendVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendVenta.IconSize = 30;
            this.btnVendVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendVenta.Location = new System.Drawing.Point(0, 146);
            this.btnVendVenta.Name = "btnVendVenta";
            this.btnVendVenta.Size = new System.Drawing.Size(180, 56);
            this.btnVendVenta.TabIndex = 22;
            this.btnVendVenta.Text = "Nueva Venta";
            this.btnVendVenta.UseVisualStyleBackColor = false;
            this.btnVendVenta.Click += new System.EventHandler(this.btnVendVenta_Click);
            this.btnVendVenta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnVendVenta.MouseEnter += new System.EventHandler(this.btn_MouseHover);
            // 
            // panelInfoUser
            // 
            this.panelInfoUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInfoUser.Controls.Add(this.lblVendRol);
            this.panelInfoUser.Controls.Add(this.lblVendUser);
            this.panelInfoUser.Controls.Add(this.guna2CirclePictureBox1);
            this.panelInfoUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoUser.Location = new System.Drawing.Point(0, 0);
            this.panelInfoUser.Name = "panelInfoUser";
            this.panelInfoUser.Size = new System.Drawing.Size(180, 146);
            this.panelInfoUser.TabIndex = 14;
            // 
            // lblVendRol
            // 
            this.lblVendRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendRol.Location = new System.Drawing.Point(35, 117);
            this.lblVendRol.Name = "lblVendRol";
            this.lblVendRol.Size = new System.Drawing.Size(110, 21);
            this.lblVendRol.TabIndex = 15;
            this.lblVendRol.Text = "Vendedor";
            this.lblVendRol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVendUser
            // 
            this.lblVendUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendUser.Location = new System.Drawing.Point(12, 86);
            this.lblVendUser.Name = "lblVendUser";
            this.lblVendUser.Size = new System.Drawing.Size(152, 21);
            this.lblVendUser.TabIndex = 14;
            this.lblVendUser.Text = "Username";
            this.lblVendUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(54, 6);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(73, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 14;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContenedor.BackColor = System.Drawing.Color.Gainsboro;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(180, 75);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(994, 566);
            this.panelContenedor.TabIndex = 17;
            // 
            // frmPerfilVendedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1174, 641);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPerfilVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroHogar SA - Panel Vendedor";
            this.Load += new System.EventHandler(this.frmPerfilVendedor_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelInfoUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Panel panelInfoUser;
        private FontAwesome.Sharp.IconButton btnVendReportes;
        private FontAwesome.Sharp.IconButton btnVendProduct;
        private FontAwesome.Sharp.IconButton btnVendLogout;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblVendRol;
        private System.Windows.Forms.Label lblVendUser;
        private System.Windows.Forms.Label lblTopTitulo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblDescSistema;
        private FontAwesome.Sharp.IconButton btnVendVenta;
        private System.Windows.Forms.Panel panelContenedor;
    }
}