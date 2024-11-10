namespace Presentacion
{
    partial class frmAdmSupervisores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmSupervisores));
            this.panelAdmvend = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSupervActivos = new System.Windows.Forms.Label();
            this.lblTopSupervActivos = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnAltaSupervisor = new FontAwesome.Sharp.IconButton();
            this.btnModificarSupervisor = new FontAwesome.Sharp.IconButton();
            this.btnEliminarSupervisor = new FontAwesome.Sharp.IconButton();
            this.panelAdmvend.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdmvend
            // 
            this.panelAdmvend.Controls.Add(this.lblTop);
            this.panelAdmvend.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmvend.Location = new System.Drawing.Point(0, 0);
            this.panelAdmvend.Name = "panelAdmvend";
            this.panelAdmvend.Size = new System.Drawing.Size(994, 56);
            this.panelAdmvend.TabIndex = 6;
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(3, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(589, 39);
            this.lblTop.TabIndex = 7;
            this.lblTop.Text = "Panel de Supervisores - Seleccione una Acción";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSupervActivos);
            this.panel2.Controls.Add(this.lblTopSupervActivos);
            this.panel2.Controls.Add(this.guna2CirclePictureBox2);
            this.panel2.Location = new System.Drawing.Point(387, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 119);
            this.panel2.TabIndex = 8;
            // 
            // lblSupervActivos
            // 
            this.lblSupervActivos.AutoSize = true;
            this.lblSupervActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervActivos.Location = new System.Drawing.Point(119, 49);
            this.lblSupervActivos.Name = "lblSupervActivos";
            this.lblSupervActivos.Size = new System.Drawing.Size(32, 15);
            this.lblSupervActivos.TabIndex = 14;
            this.lblSupervActivos.Text = "Total";
            this.lblSupervActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopSupervActivos
            // 
            this.lblTopSupervActivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopSupervActivos.Location = new System.Drawing.Point(73, 26);
            this.lblTopSupervActivos.Name = "lblTopSupervActivos";
            this.lblTopSupervActivos.Size = new System.Drawing.Size(136, 23);
            this.lblTopSupervActivos.TabIndex = 12;
            this.lblTopSupervActivos.Text = "Supervisores Activos";
            this.lblTopSupervActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnAltaSupervisor
            // 
            this.btnAltaSupervisor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAltaSupervisor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaSupervisor.FlatAppearance.BorderSize = 0;
            this.btnAltaSupervisor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAltaSupervisor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAltaSupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaSupervisor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaSupervisor.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAltaSupervisor.IconColor = System.Drawing.Color.Black;
            this.btnAltaSupervisor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltaSupervisor.IconSize = 30;
            this.btnAltaSupervisor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaSupervisor.Location = new System.Drawing.Point(387, 237);
            this.btnAltaSupervisor.Name = "btnAltaSupervisor";
            this.btnAltaSupervisor.Size = new System.Drawing.Size(220, 56);
            this.btnAltaSupervisor.TabIndex = 18;
            this.btnAltaSupervisor.Text = "Agregar Supervisor";
            this.btnAltaSupervisor.UseVisualStyleBackColor = false;
            this.btnAltaSupervisor.Click += new System.EventHandler(this.btnAltaSuperv_Click);
            // 
            // btnModificarSupervisor
            // 
            this.btnModificarSupervisor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarSupervisor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarSupervisor.FlatAppearance.BorderSize = 0;
            this.btnModificarSupervisor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnModificarSupervisor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarSupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarSupervisor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarSupervisor.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificarSupervisor.IconColor = System.Drawing.Color.Black;
            this.btnModificarSupervisor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarSupervisor.IconSize = 30;
            this.btnModificarSupervisor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarSupervisor.Location = new System.Drawing.Point(387, 340);
            this.btnModificarSupervisor.Name = "btnModificarSupervisor";
            this.btnModificarSupervisor.Size = new System.Drawing.Size(220, 56);
            this.btnModificarSupervisor.TabIndex = 19;
            this.btnModificarSupervisor.Text = "Modificar Supervisor";
            this.btnModificarSupervisor.UseVisualStyleBackColor = false;
            this.btnModificarSupervisor.Click += new System.EventHandler(this.btnModSuperv_Click);
            // 
            // btnEliminarSupervisor
            // 
            this.btnEliminarSupervisor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarSupervisor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarSupervisor.FlatAppearance.BorderSize = 0;
            this.btnEliminarSupervisor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEliminarSupervisor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarSupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarSupervisor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSupervisor.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnEliminarSupervisor.IconColor = System.Drawing.Color.Black;
            this.btnEliminarSupervisor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarSupervisor.IconSize = 30;
            this.btnEliminarSupervisor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarSupervisor.Location = new System.Drawing.Point(387, 443);
            this.btnEliminarSupervisor.Name = "btnEliminarSupervisor";
            this.btnEliminarSupervisor.Size = new System.Drawing.Size(220, 56);
            this.btnEliminarSupervisor.TabIndex = 20;
            this.btnEliminarSupervisor.Text = "Eliminar Supervisor";
            this.btnEliminarSupervisor.UseVisualStyleBackColor = false;
            this.btnEliminarSupervisor.Click += new System.EventHandler(this.btnBajaSuperv_Click);
            // 
            // frmAdmSupervisores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.btnEliminarSupervisor);
            this.Controls.Add(this.btnModificarSupervisor);
            this.Controls.Add(this.btnAltaSupervisor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelAdmvend);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmSupervisores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Supervisores - Administrador";
            this.Load += new System.EventHandler(this.frmAdmUsuarios_Load);
            this.panelAdmvend.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmvend;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSupervActivos;
        private System.Windows.Forms.Label lblTopSupervActivos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private FontAwesome.Sharp.IconButton btnAltaSupervisor;
        private FontAwesome.Sharp.IconButton btnModificarSupervisor;
        private FontAwesome.Sharp.IconButton btnEliminarSupervisor;
    }
}