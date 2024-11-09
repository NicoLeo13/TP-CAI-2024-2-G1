namespace Presentacion
{
    partial class frmPerfilAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilAdministrador));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblDescSistema = new System.Windows.Forms.Label();
            this.lblTopTitulo = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnAdmLogout = new FontAwesome.Sharp.IconButton();
            this.btnAdmReportes = new FontAwesome.Sharp.IconButton();
            this.btnAdmProduct = new FontAwesome.Sharp.IconButton();
            this.btnAdmProveed = new FontAwesome.Sharp.IconButton();
            this.btnAdmSuperv = new FontAwesome.Sharp.IconButton();
            this.btnAdmVendedor = new FontAwesome.Sharp.IconButton();
            this.btnAdmUsuarios = new FontAwesome.Sharp.IconButton();
            this.panelInfoUser = new System.Windows.Forms.Panel();
            this.lblAdmRol = new System.Windows.Forms.Label();
            this.lblAdmUser = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.Bienv = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.panelInfoUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Bisque;
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
            this.lblDescSistema.Location = new System.Drawing.Point(979, 39);
            this.lblDescSistema.Name = "lblDescSistema";
            this.lblDescSistema.Size = new System.Drawing.Size(192, 27);
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
            this.panelOpciones.Controls.Add(this.btnAdmLogout);
            this.panelOpciones.Controls.Add(this.btnAdmReportes);
            this.panelOpciones.Controls.Add(this.btnAdmProduct);
            this.panelOpciones.Controls.Add(this.btnAdmProveed);
            this.panelOpciones.Controls.Add(this.btnAdmSuperv);
            this.panelOpciones.Controls.Add(this.btnAdmVendedor);
            this.panelOpciones.Controls.Add(this.btnAdmUsuarios);
            this.panelOpciones.Controls.Add(this.panelInfoUser);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 75);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(180, 566);
            this.panelOpciones.TabIndex = 13;
            // 
            // btnAdmLogout
            // 
            this.btnAdmLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdmLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdmLogout.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAdmLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnAdmLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnAdmLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnAdmLogout.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmLogout.IconSize = 30;
            this.btnAdmLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmLogout.Location = new System.Drawing.Point(0, 510);
            this.btnAdmLogout.Name = "btnAdmLogout";
            this.btnAdmLogout.Size = new System.Drawing.Size(180, 56);
            this.btnAdmLogout.TabIndex = 21;
            this.btnAdmLogout.Text = "Cerrar Sesión";
            this.btnAdmLogout.UseVisualStyleBackColor = false;
            this.btnAdmLogout.Click += new System.EventHandler(this.btnAdmLogout_Click);
            // 
            // btnAdmReportes
            // 
            this.btnAdmReportes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmReportes.FlatAppearance.BorderSize = 0;
            this.btnAdmReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAdmReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmReportes.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnAdmReportes.IconColor = System.Drawing.Color.Black;
            this.btnAdmReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmReportes.IconSize = 30;
            this.btnAdmReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmReportes.Location = new System.Drawing.Point(0, 426);
            this.btnAdmReportes.Name = "btnAdmReportes";
            this.btnAdmReportes.Size = new System.Drawing.Size(180, 56);
            this.btnAdmReportes.TabIndex = 19;
            this.btnAdmReportes.Text = "Reportes";
            this.btnAdmReportes.UseVisualStyleBackColor = false;
            this.btnAdmReportes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnAdmReportes.MouseEnter += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnAdmProduct
            // 
            this.btnAdmProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmProduct.FlatAppearance.BorderSize = 0;
            this.btnAdmProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAdmProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmProduct.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnAdmProduct.IconColor = System.Drawing.Color.Black;
            this.btnAdmProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmProduct.IconSize = 30;
            this.btnAdmProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmProduct.Location = new System.Drawing.Point(0, 370);
            this.btnAdmProduct.Name = "btnAdmProduct";
            this.btnAdmProduct.Size = new System.Drawing.Size(180, 56);
            this.btnAdmProduct.TabIndex = 18;
            this.btnAdmProduct.Text = "Productos";
            this.btnAdmProduct.UseVisualStyleBackColor = false;
            this.btnAdmProduct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnAdmProduct.MouseEnter += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnAdmProveed
            // 
            this.btnAdmProveed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmProveed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmProveed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmProveed.FlatAppearance.BorderSize = 0;
            this.btnAdmProveed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAdmProveed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmProveed.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.btnAdmProveed.IconColor = System.Drawing.Color.Black;
            this.btnAdmProveed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmProveed.IconSize = 30;
            this.btnAdmProveed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmProveed.Location = new System.Drawing.Point(0, 314);
            this.btnAdmProveed.Name = "btnAdmProveed";
            this.btnAdmProveed.Size = new System.Drawing.Size(180, 56);
            this.btnAdmProveed.TabIndex = 17;
            this.btnAdmProveed.Text = "Proveedores";
            this.btnAdmProveed.UseVisualStyleBackColor = false;
            this.btnAdmProveed.Click += new System.EventHandler(this.btnAdmProveed_Click);
            this.btnAdmProveed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnAdmProveed.MouseEnter += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnAdmSuperv
            // 
            this.btnAdmSuperv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmSuperv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmSuperv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmSuperv.FlatAppearance.BorderSize = 0;
            this.btnAdmSuperv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAdmSuperv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmSuperv.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnAdmSuperv.IconColor = System.Drawing.Color.Black;
            this.btnAdmSuperv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmSuperv.IconSize = 30;
            this.btnAdmSuperv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmSuperv.Location = new System.Drawing.Point(0, 258);
            this.btnAdmSuperv.Name = "btnAdmSuperv";
            this.btnAdmSuperv.Size = new System.Drawing.Size(180, 56);
            this.btnAdmSuperv.TabIndex = 20;
            this.btnAdmSuperv.Text = "Supervisores";
            this.btnAdmSuperv.UseVisualStyleBackColor = false;
            this.btnAdmSuperv.Click += new System.EventHandler(this.btnAdmSuperv_Click);
            this.btnAdmSuperv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnAdmSuperv.MouseEnter += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnAdmVendedor
            // 
            this.btnAdmVendedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmVendedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmVendedor.FlatAppearance.BorderSize = 0;
            this.btnAdmVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAdmVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmVendedor.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            this.btnAdmVendedor.IconColor = System.Drawing.Color.Black;
            this.btnAdmVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmVendedor.IconSize = 30;
            this.btnAdmVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmVendedor.Location = new System.Drawing.Point(0, 202);
            this.btnAdmVendedor.Name = "btnAdmVendedor";
            this.btnAdmVendedor.Size = new System.Drawing.Size(180, 56);
            this.btnAdmVendedor.TabIndex = 16;
            this.btnAdmVendedor.Text = "Vendedores";
            this.btnAdmVendedor.UseVisualStyleBackColor = false;
            this.btnAdmVendedor.Click += new System.EventHandler(this.btnAdmVendedor_Click);
            this.btnAdmVendedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnAdmVendedor.MouseEnter += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnAdmUsuarios
            // 
            this.btnAdmUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmUsuarios.FlatAppearance.BorderSize = 0;
            this.btnAdmUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAdmUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnAdmUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnAdmUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmUsuarios.IconSize = 30;
            this.btnAdmUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmUsuarios.Location = new System.Drawing.Point(0, 146);
            this.btnAdmUsuarios.Name = "btnAdmUsuarios";
            this.btnAdmUsuarios.Size = new System.Drawing.Size(180, 56);
            this.btnAdmUsuarios.TabIndex = 22;
            this.btnAdmUsuarios.Text = "Usuarios";
            this.btnAdmUsuarios.UseVisualStyleBackColor = false;
            this.btnAdmUsuarios.Click += new System.EventHandler(this.btnAdmUsuarios_Click);
            this.btnAdmUsuarios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnAdmUsuarios.MouseEnter += new System.EventHandler(this.btn_MouseHover);
            // 
            // panelInfoUser
            // 
            this.panelInfoUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInfoUser.Controls.Add(this.lblAdmRol);
            this.panelInfoUser.Controls.Add(this.lblAdmUser);
            this.panelInfoUser.Controls.Add(this.guna2CirclePictureBox1);
            this.panelInfoUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoUser.Location = new System.Drawing.Point(0, 0);
            this.panelInfoUser.Name = "panelInfoUser";
            this.panelInfoUser.Size = new System.Drawing.Size(180, 146);
            this.panelInfoUser.TabIndex = 14;
            // 
            // lblAdmRol
            // 
            this.lblAdmRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmRol.Location = new System.Drawing.Point(13, 117);
            this.lblAdmRol.Name = "lblAdmRol";
            this.lblAdmRol.Size = new System.Drawing.Size(151, 26);
            this.lblAdmRol.TabIndex = 15;
            this.lblAdmRol.Text = "Administrador";
            this.lblAdmRol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAdmUser
            // 
            this.lblAdmUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmUser.Location = new System.Drawing.Point(12, 86);
            this.lblAdmUser.Name = "lblAdmUser";
            this.lblAdmUser.Size = new System.Drawing.Size(152, 21);
            this.lblAdmUser.TabIndex = 14;
            this.lblAdmUser.Text = "Username";
            this.lblAdmUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.panelContenedor.Controls.Add(this.Bienv);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(180, 75);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(994, 566);
            this.panelContenedor.TabIndex = 17;
            // 
            // Bienv
            // 
            this.Bienv.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienv.Location = new System.Drawing.Point(250, 99);
            this.Bienv.Name = "Bienv";
            this.Bienv.Size = new System.Drawing.Size(490, 44);
            this.Bienv.TabIndex = 17;
            this.Bienv.Text = "¡Bienvenidos a ElectroHogar SA!";
            // 
            // frmPerfilAdministrador
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
            this.Name = "frmPerfilAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroHogar SA - Panel Administrador";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelInfoUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Panel panelInfoUser;
        private FontAwesome.Sharp.IconButton btnAdmVendedor;
        private FontAwesome.Sharp.IconButton btnAdmProveed;
        private FontAwesome.Sharp.IconButton btnAdmSuperv;
        private FontAwesome.Sharp.IconButton btnAdmReportes;
        private FontAwesome.Sharp.IconButton btnAdmProduct;
        private FontAwesome.Sharp.IconButton btnAdmLogout;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblAdmRol;
        private System.Windows.Forms.Label lblAdmUser;
        private System.Windows.Forms.Label lblTopTitulo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblDescSistema;
        private FontAwesome.Sharp.IconButton btnAdmUsuarios;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label Bienv;
    }
}