namespace Presentacion
{
    partial class frmPerfliSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfliSupervisor));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblDescSistema = new System.Windows.Forms.Label();
            this.lblTopTitulo = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAdmLogout = new FontAwesome.Sharp.IconButton();
            this.panelInfoUser = new System.Windows.Forms.Panel();
            this.lblSupUser = new System.Windows.Forms.Label();
            this.lblVendUser = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(606, 81);
            this.panelTop.TabIndex = 13;
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
            this.btnAdmLogout.Location = new System.Drawing.Point(0, 415);
            this.btnAdmLogout.Name = "btnAdmLogout";
            this.btnAdmLogout.Size = new System.Drawing.Size(606, 56);
            this.btnAdmLogout.TabIndex = 22;
            this.btnAdmLogout.Text = "Cerrar Sesión";
            this.btnAdmLogout.UseVisualStyleBackColor = false;
            // 
            // panelInfoUser
            // 
            this.panelInfoUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInfoUser.Controls.Add(this.lblSupUser);
            this.panelInfoUser.Controls.Add(this.lblVendUser);
            this.panelInfoUser.Controls.Add(this.guna2CirclePictureBox1);
            this.panelInfoUser.Location = new System.Drawing.Point(3, 81);
            this.panelInfoUser.Name = "panelInfoUser";
            this.panelInfoUser.Size = new System.Drawing.Size(164, 149);
            this.panelInfoUser.TabIndex = 23;
            // 
            // lblSupUser
            // 
            this.lblSupUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupUser.Location = new System.Drawing.Point(35, 117);
            this.lblSupUser.Name = "lblSupUser";
            this.lblSupUser.Size = new System.Drawing.Size(110, 21);
            this.lblSupUser.TabIndex = 15;
            this.lblSupUser.Text = "Supervisor";
            this.lblSupUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSupUser.Click += new System.EventHandler(this.lblVendRol_Click);
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
            this.panelContenedor.Location = new System.Drawing.Point(173, 81);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(433, 335);
            this.panelContenedor.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reportes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 71);
            this.button2.TabIndex = 25;
            this.button2.Text = "Productos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPerfliSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 471);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelInfoUser);
            this.Controls.Add(this.btnAdmLogout);
            this.Controls.Add(this.panelTop);
            this.Name = "frmPerfliSupervisor";
            this.Text = "frmPerfliSupervisor";
            this.Load += new System.EventHandler(this.frmPerfliSupervisor_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelInfoUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblDescSistema;
        private System.Windows.Forms.Label lblTopTitulo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private FontAwesome.Sharp.IconButton btnAdmLogout;
        private System.Windows.Forms.Panel panelInfoUser;
        private System.Windows.Forms.Label lblSupUser;
        private System.Windows.Forms.Label lblVendUser;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}