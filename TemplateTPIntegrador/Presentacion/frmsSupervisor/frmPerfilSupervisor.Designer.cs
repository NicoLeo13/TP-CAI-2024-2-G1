namespace Presentacion
{
    partial class frmPerfilSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilSupervisor));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblDescSistema = new System.Windows.Forms.Label();
            this.lblTopTitulo = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnSupLogout = new FontAwesome.Sharp.IconButton();
            this.btnSupReportes = new FontAwesome.Sharp.IconButton();
            this.btnSupDevoluciones = new FontAwesome.Sharp.IconButton();
            this.btnSupProduct = new FontAwesome.Sharp.IconButton();
            this.btnSupervInicio = new FontAwesome.Sharp.IconButton();
            this.panelInfoUser = new System.Windows.Forms.Panel();
            this.lblSupRol = new System.Windows.Forms.Label();
            this.lblAdmUser = new System.Windows.Forms.Label();
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
            this.panelTop.BackColor = System.Drawing.Color.MediumAquamarine;
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
            this.panelOpciones.Controls.Add(this.btnSupLogout);
            this.panelOpciones.Controls.Add(this.btnSupReportes);
            this.panelOpciones.Controls.Add(this.btnSupDevoluciones);
            this.panelOpciones.Controls.Add(this.btnSupProduct);
            this.panelOpciones.Controls.Add(this.btnSupervInicio);
            this.panelOpciones.Controls.Add(this.panelInfoUser);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 75);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(180, 566);
            this.panelOpciones.TabIndex = 13;
            // 
            // btnSupLogout
            // 
            this.btnSupLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSupLogout.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSupLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnSupLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSupLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSupLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnSupLogout.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSupLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSupLogout.IconSize = 30;
            this.btnSupLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupLogout.Location = new System.Drawing.Point(0, 510);
            this.btnSupLogout.Name = "btnSupLogout";
            this.btnSupLogout.Size = new System.Drawing.Size(180, 56);
            this.btnSupLogout.TabIndex = 21;
            this.btnSupLogout.Text = "Cerrar Sesión";
            this.btnSupLogout.UseVisualStyleBackColor = false;
            this.btnSupLogout.Click += new System.EventHandler(this.btnSupLogout_Click);
            // 
            // btnSupReportes
            // 
            this.btnSupReportes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSupReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupReportes.FlatAppearance.BorderSize = 0;
            this.btnSupReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnSupReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupReportes.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnSupReportes.IconColor = System.Drawing.Color.Black;
            this.btnSupReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSupReportes.IconSize = 30;
            this.btnSupReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupReportes.Location = new System.Drawing.Point(0, 314);
            this.btnSupReportes.Name = "btnSupReportes";
            this.btnSupReportes.Size = new System.Drawing.Size(180, 56);
            this.btnSupReportes.TabIndex = 19;
            this.btnSupReportes.Text = "Reportes";
            this.btnSupReportes.UseVisualStyleBackColor = false;
            this.btnSupReportes.Click += new System.EventHandler(this.btnSupReportes_Click);
            this.btnSupReportes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnSupReportes.MouseEnter += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnSupDevoluciones
            // 
            this.btnSupDevoluciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSupDevoluciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupDevoluciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupDevoluciones.FlatAppearance.BorderSize = 0;
            this.btnSupDevoluciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnSupDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupDevoluciones.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnSupDevoluciones.IconColor = System.Drawing.Color.Black;
            this.btnSupDevoluciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSupDevoluciones.IconSize = 30;
            this.btnSupDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupDevoluciones.Location = new System.Drawing.Point(0, 258);
            this.btnSupDevoluciones.Name = "btnSupDevoluciones";
            this.btnSupDevoluciones.Size = new System.Drawing.Size(180, 56);
            this.btnSupDevoluciones.TabIndex = 22;
            this.btnSupDevoluciones.Text = "Devoluciones";
            this.btnSupDevoluciones.UseVisualStyleBackColor = false;
            this.btnSupDevoluciones.Click += new System.EventHandler(this.btnSupDevoluciones_Click);
            this.btnSupDevoluciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnSupDevoluciones.MouseEnter += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnSupProduct
            // 
            this.btnSupProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSupProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupProduct.FlatAppearance.BorderSize = 0;
            this.btnSupProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnSupProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupProduct.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnSupProduct.IconColor = System.Drawing.Color.Black;
            this.btnSupProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSupProduct.IconSize = 30;
            this.btnSupProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupProduct.Location = new System.Drawing.Point(0, 202);
            this.btnSupProduct.Name = "btnSupProduct";
            this.btnSupProduct.Size = new System.Drawing.Size(180, 56);
            this.btnSupProduct.TabIndex = 18;
            this.btnSupProduct.Text = "Productos";
            this.btnSupProduct.UseVisualStyleBackColor = false;
            this.btnSupProduct.Click += new System.EventHandler(this.btnSupProduct_Click);
            this.btnSupProduct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnSupProduct.MouseEnter += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnSupervInicio
            // 
            this.btnSupervInicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSupervInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupervInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupervInicio.FlatAppearance.BorderSize = 0;
            this.btnSupervInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnSupervInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupervInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnSupervInicio.IconColor = System.Drawing.Color.Black;
            this.btnSupervInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSupervInicio.IconSize = 30;
            this.btnSupervInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupervInicio.Location = new System.Drawing.Point(0, 146);
            this.btnSupervInicio.Name = "btnSupervInicio";
            this.btnSupervInicio.Size = new System.Drawing.Size(180, 56);
            this.btnSupervInicio.TabIndex = 24;
            this.btnSupervInicio.Text = "Inicio";
            this.btnSupervInicio.UseVisualStyleBackColor = false;
            this.btnSupervInicio.Click += new System.EventHandler(this.btnSupervInicio_Click);
            this.btnSupervInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnSupervInicio.MouseEnter += new System.EventHandler(this.btn_MouseHover);
            // 
            // panelInfoUser
            // 
            this.panelInfoUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInfoUser.Controls.Add(this.lblSupRol);
            this.panelInfoUser.Controls.Add(this.lblAdmUser);
            this.panelInfoUser.Controls.Add(this.guna2CirclePictureBox1);
            this.panelInfoUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoUser.Location = new System.Drawing.Point(0, 0);
            this.panelInfoUser.Name = "panelInfoUser";
            this.panelInfoUser.Size = new System.Drawing.Size(180, 146);
            this.panelInfoUser.TabIndex = 14;
            // 
            // lblSupRol
            // 
            this.lblSupRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupRol.Location = new System.Drawing.Point(13, 117);
            this.lblSupRol.Name = "lblSupRol";
            this.lblSupRol.Size = new System.Drawing.Size(151, 26);
            this.lblSupRol.TabIndex = 15;
            this.lblSupRol.Text = "Supervisor";
            this.lblSupRol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(180, 75);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(994, 566);
            this.panelContenedor.TabIndex = 17;
            // 
            // frmPerfilSupervisor
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
            this.Name = "frmPerfilSupervisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroHogar SA - Panel Supervisor";
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
        private FontAwesome.Sharp.IconButton btnSupReportes;
        private FontAwesome.Sharp.IconButton btnSupProduct;
        private FontAwesome.Sharp.IconButton btnSupLogout;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblSupRol;
        private System.Windows.Forms.Label lblAdmUser;
        private System.Windows.Forms.Label lblTopTitulo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblDescSistema;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnSupDevoluciones;
        private FontAwesome.Sharp.IconButton btnSupervInicio;
    }
}