﻿namespace Presentacion
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            this.linkLabelForgotPass = new System.Windows.Forms.LinkLabel();
            this.guna2CustomGradientLeftLogin = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblSistema = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTopText = new System.Windows.Forms.Label();
            this.guna2CustomGradientLeftLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(751, 256);
            this.txtBoxUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBoxUser.MaxLength = 15;
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(230, 29);
            this.txtBoxUser.TabIndex = 1;
            this.txtBoxUser.Enter += new System.EventHandler(this.txtBoxUser_Focus);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(751, 355);
            this.txtBoxPass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBoxPass.MaxLength = 15;
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '*';
            this.txtBoxPass.Size = new System.Drawing.Size(230, 29);
            this.txtBoxPass.TabIndex = 2;
            this.txtBoxPass.Enter += new System.EventHandler(this.txtBoxPass_Focus);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(745, 216);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(77, 25);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(745, 316);
            this.labelContraseña.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(109, 25);
            this.labelContraseña.TabIndex = 4;
            this.labelContraseña.Text = "Contraseña";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnIniciarSesion.IconColor = System.Drawing.SystemColors.Control;
            this.btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIniciarSesion.IconSize = 21;
            this.btnIniciarSesion.Location = new System.Drawing.Point(751, 419);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(232, 55);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // linkLabelForgotPass
            // 
            this.linkLabelForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelForgotPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgotPass.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabelForgotPass.Location = new System.Drawing.Point(748, 490);
            this.linkLabelForgotPass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabelForgotPass.Name = "linkLabelForgotPass";
            this.linkLabelForgotPass.Size = new System.Drawing.Size(235, 21);
            this.linkLabelForgotPass.TabIndex = 4;
            this.linkLabelForgotPass.TabStop = true;
            this.linkLabelForgotPass.Text = "¿Olvidaste tu contraseña?";
            this.linkLabelForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guna2CustomGradientLeftLogin
            // 
            this.guna2CustomGradientLeftLogin.Controls.Add(this.lblVersion);
            this.guna2CustomGradientLeftLogin.Controls.Add(this.lblSistema);
            this.guna2CustomGradientLeftLogin.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientLeftLogin.Controls.Add(this.lblName);
            this.guna2CustomGradientLeftLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientLeftLogin.FillColor2 = System.Drawing.SystemColors.Highlight;
            this.guna2CustomGradientLeftLogin.FillColor3 = System.Drawing.Color.Navy;
            this.guna2CustomGradientLeftLogin.FillColor4 = System.Drawing.Color.DeepSkyBlue;
            this.guna2CustomGradientLeftLogin.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientLeftLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientLeftLogin.Name = "guna2CustomGradientLeftLogin";
            this.guna2CustomGradientLeftLogin.Size = new System.Drawing.Size(632, 662);
            this.guna2CustomGradientLeftLogin.TabIndex = 7;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVersion.Location = new System.Drawing.Point(522, 631);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(106, 26);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "V1.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSistema
            // 
            this.lblSistema.BackColor = System.Drawing.Color.Transparent;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSistema.Location = new System.Drawing.Point(394, 582);
            this.lblSistema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(235, 49);
            this.lblSistema.TabIndex = 2;
            this.lblSistema.Text = "Sistema de Gestión";
            this.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 216);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(79, 29);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(446, 144);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Bienvenido a ElectroHogar S.A.";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopText
            // 
            this.lblTopText.BackColor = System.Drawing.Color.Transparent;
            this.lblTopText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTopText.Location = new System.Drawing.Point(750, 121);
            this.lblTopText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopText.Name = "lblTopText";
            this.lblTopText.Size = new System.Drawing.Size(234, 51);
            this.lblTopText.TabIndex = 8;
            this.lblTopText.Text = "Inicio de Sesión";
            this.lblTopText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1112, 662);
            this.Controls.Add(this.lblTopText);
            this.Controls.Add(this.guna2CustomGradientLeftLogin);
            this.Controls.Add(this.linkLabelForgotPass);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxUser);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ElectroHogar SA - Inicio de sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2CustomGradientLeftLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private System.Windows.Forms.LinkLabel linkLabelForgotPass;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientLeftLogin;
        private System.Windows.Forms.Label lblTopText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSistema;
    }
}

