namespace Presentacion
{
    partial class frmSupervInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupervInicio));
            this.panelAdmUsers = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.lblProdActivos = new System.Windows.Forms.Label();
            this.lblTopProdActivos = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelAdmUsers.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdmUsers
            // 
            this.panelAdmUsers.Controls.Add(this.lblTop);
            this.panelAdmUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmUsers.Location = new System.Drawing.Point(0, 0);
            this.panelAdmUsers.Name = "panelAdmUsers";
            this.panelAdmUsers.Size = new System.Drawing.Size(994, 56);
            this.panelAdmUsers.TabIndex = 6;
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(3, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(589, 39);
            this.lblTop.TabIndex = 7;
            this.lblTop.Text = "Bienvenido a ElectroHogar SA!";
            // 
            // pnlProductos
            // 
            this.pnlProductos.Controls.Add(this.lblProdActivos);
            this.pnlProductos.Controls.Add(this.lblTopProdActivos);
            this.pnlProductos.Controls.Add(this.guna2CirclePictureBox4);
            this.pnlProductos.Location = new System.Drawing.Point(387, 62);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(220, 119);
            this.pnlProductos.TabIndex = 10;
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
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CirclePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox4.Image")));
            this.guna2CirclePictureBox4.ImageRotate = 0F;
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(3, 26);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox4.TabIndex = 13;
            this.guna2CirclePictureBox4.TabStop = false;
            // 
            // frmSupervInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.pnlProductos);
            this.Controls.Add(this.panelAdmUsers);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSupervInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Inicio - Supervisor";
            this.Load += new System.EventHandler(this.frmSupervInicio_Load);
            this.panelAdmUsers.ResumeLayout(false);
            this.pnlProductos.ResumeLayout(false);
            this.pnlProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmUsers;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Label lblProdActivos;
        private System.Windows.Forms.Label lblTopProdActivos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
    }
}