namespace Presentacion
{
    partial class frmAdmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmUsuarios));
            this.panelAdmUsers = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSupervActivos = new System.Windows.Forms.Label();
            this.lblDescSupervActivos = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblActivos = new System.Windows.Forms.Label();
            this.lblUsersActivos = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblVendActivos = new System.Windows.Forms.Label();
            this.lblDescVendActivos = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnAltaUsuario = new FontAwesome.Sharp.IconButton();
            this.btnModificarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnEliminarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnListarUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnReactivarUsuario = new FontAwesome.Sharp.IconButton();
            this.panelAdmUsers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdmUsers
            // 
            this.panelAdmUsers.Controls.Add(this.label2);
            this.panelAdmUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmUsers.Location = new System.Drawing.Point(0, 0);
            this.panelAdmUsers.Name = "panelAdmUsers";
            this.panelAdmUsers.Size = new System.Drawing.Size(994, 56);
            this.panelAdmUsers.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(589, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Panel de Usuarios - Seleccione una Acción";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSupervActivos);
            this.panel1.Controls.Add(this.lblDescSupervActivos);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Location = new System.Drawing.Point(387, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 119);
            this.panel1.TabIndex = 7;
            // 
            // lblSupervActivos
            // 
            this.lblSupervActivos.AutoSize = true;
            this.lblSupervActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervActivos.Location = new System.Drawing.Point(116, 49);
            this.lblSupervActivos.Name = "lblSupervActivos";
            this.lblSupervActivos.Size = new System.Drawing.Size(32, 15);
            this.lblSupervActivos.TabIndex = 11;
            this.lblSupervActivos.Text = "Total";
            this.lblSupervActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescSupervActivos
            // 
            this.lblDescSupervActivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSupervActivos.Location = new System.Drawing.Point(70, 26);
            this.lblDescSupervActivos.Name = "lblDescSupervActivos";
            this.lblDescSupervActivos.Size = new System.Drawing.Size(136, 23);
            this.lblDescSupervActivos.TabIndex = 10;
            this.lblDescSupervActivos.Text = "Supervisores Activos";
            this.lblDescSupervActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.lblActivos);
            this.panel2.Controls.Add(this.lblUsersActivos);
            this.panel2.Controls.Add(this.guna2CirclePictureBox2);
            this.panel2.Location = new System.Drawing.Point(22, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 119);
            this.panel2.TabIndex = 8;
            // 
            // lblActivos
            // 
            this.lblActivos.AutoSize = true;
            this.lblActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivos.Location = new System.Drawing.Point(119, 49);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(32, 15);
            this.lblActivos.TabIndex = 14;
            this.lblActivos.Text = "Total";
            this.lblActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsersActivos
            // 
            this.lblUsersActivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersActivos.Location = new System.Drawing.Point(73, 26);
            this.lblUsersActivos.Name = "lblUsersActivos";
            this.lblUsersActivos.Size = new System.Drawing.Size(136, 23);
            this.lblUsersActivos.TabIndex = 12;
            this.lblUsersActivos.Text = "Usuarios Activos";
            this.lblUsersActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.lblVendActivos);
            this.panel3.Controls.Add(this.lblDescVendActivos);
            this.panel3.Controls.Add(this.guna2CirclePictureBox3);
            this.panel3.Location = new System.Drawing.Point(752, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 119);
            this.panel3.TabIndex = 9;
            // 
            // lblVendActivos
            // 
            this.lblVendActivos.AutoSize = true;
            this.lblVendActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendActivos.Location = new System.Drawing.Point(127, 49);
            this.lblVendActivos.Name = "lblVendActivos";
            this.lblVendActivos.Size = new System.Drawing.Size(32, 15);
            this.lblVendActivos.TabIndex = 17;
            this.lblVendActivos.Text = "Total";
            this.lblVendActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescVendActivos
            // 
            this.lblDescVendActivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescVendActivos.Location = new System.Drawing.Point(81, 26);
            this.lblDescVendActivos.Name = "lblDescVendActivos";
            this.lblDescVendActivos.Size = new System.Drawing.Size(136, 23);
            this.lblDescVendActivos.TabIndex = 15;
            this.lblDescVendActivos.Text = "Vendedores Activos";
            this.lblDescVendActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(11, 26);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox3.TabIndex = 16;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAltaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaUsuario.FlatAppearance.BorderSize = 0;
            this.btnAltaUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAltaUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAltaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAltaUsuario.IconColor = System.Drawing.Color.Black;
            this.btnAltaUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltaUsuario.IconSize = 30;
            this.btnAltaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaUsuario.Location = new System.Drawing.Point(387, 337);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(220, 56);
            this.btnAltaUsuario.TabIndex = 18;
            this.btnAltaUsuario.Text = "Agregar Usuarios";
            this.btnAltaUsuario.UseVisualStyleBackColor = false;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarUsuario.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnModificarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnModificarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarUsuario.IconSize = 30;
            this.btnModificarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUsuario.Location = new System.Drawing.Point(387, 412);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(220, 56);
            this.btnModificarUsuario.TabIndex = 19;
            this.btnModificarUsuario.Text = "Modificar Contraseña de Usuario";
            this.btnModificarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEliminarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnEliminarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnEliminarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarUsuario.IconSize = 30;
            this.btnEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(387, 487);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(220, 56);
            this.btnEliminarUsuario.TabIndex = 20;
            this.btnEliminarUsuario.Text = "Eliminar Usuarios";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnBajaUsuario_Click);
            // 
            // btnListarUsuarios
            // 
            this.btnListarUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnListarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnListarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnListarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnListarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarUsuarios.IconChar = FontAwesome.Sharp.IconChar.PersonCircleQuestion;
            this.btnListarUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnListarUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarUsuarios.IconSize = 30;
            this.btnListarUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarUsuarios.Location = new System.Drawing.Point(387, 187);
            this.btnListarUsuarios.Name = "btnListarUsuarios";
            this.btnListarUsuarios.Size = new System.Drawing.Size(220, 56);
            this.btnListarUsuarios.TabIndex = 21;
            this.btnListarUsuarios.Text = "Listar Usuarios";
            this.btnListarUsuarios.UseVisualStyleBackColor = false;
            this.btnListarUsuarios.Click += new System.EventHandler(this.btnListarUsuarios_Click);
            // 
            // btnReactivarUsuario
            // 
            this.btnReactivarUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReactivarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReactivarUsuario.FlatAppearance.BorderSize = 0;
            this.btnReactivarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnReactivarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReactivarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReactivarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReactivarUsuario.IconChar = FontAwesome.Sharp.IconChar.CreativeCommonsSa;
            this.btnReactivarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnReactivarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReactivarUsuario.IconSize = 30;
            this.btnReactivarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReactivarUsuario.Location = new System.Drawing.Point(387, 262);
            this.btnReactivarUsuario.Name = "btnReactivarUsuario";
            this.btnReactivarUsuario.Size = new System.Drawing.Size(220, 56);
            this.btnReactivarUsuario.TabIndex = 22;
            this.btnReactivarUsuario.Text = "Reactivar Usuarios";
            this.btnReactivarUsuario.UseVisualStyleBackColor = false;
            this.btnReactivarUsuario.Click += new System.EventHandler(this.btnReactivarUsuario_Click);
            // 
            // frmAdmUsuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.btnReactivarUsuario);
            this.Controls.Add(this.btnListarUsuarios);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnAltaUsuario);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAdmUsers);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Usuarios - Administrador";
            this.Load += new System.EventHandler(this.frmAdmUsuarios_Load);
            this.panelAdmUsers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSupervActivos;
        private System.Windows.Forms.Label lblDescSupervActivos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblActivos;
        private System.Windows.Forms.Label lblUsersActivos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label lblVendActivos;
        private System.Windows.Forms.Label lblDescVendActivos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private FontAwesome.Sharp.IconButton btnAltaUsuario;
        private FontAwesome.Sharp.IconButton btnModificarUsuario;
        private FontAwesome.Sharp.IconButton btnEliminarUsuario;
        private FontAwesome.Sharp.IconButton btnListarUsuarios;
        private FontAwesome.Sharp.IconButton btnReactivarUsuario;
    }
}