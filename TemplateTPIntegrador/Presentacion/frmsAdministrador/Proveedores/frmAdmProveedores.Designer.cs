namespace Presentacion
{
    partial class frmAdmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmProveedores));
            this.panelAdmvend = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProveeActivos = new System.Windows.Forms.Label();
            this.lblTopProveActivos = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnAltaProveedor = new FontAwesome.Sharp.IconButton();
            this.btnModificarProveedor = new FontAwesome.Sharp.IconButton();
            this.btnEliminarProveedor = new FontAwesome.Sharp.IconButton();
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
            this.lblTop.Text = "Proveedores";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblProveeActivos);
            this.panel2.Controls.Add(this.lblTopProveActivos);
            this.panel2.Controls.Add(this.guna2CirclePictureBox2);
            this.panel2.Location = new System.Drawing.Point(387, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 119);
            this.panel2.TabIndex = 8;
            // 
            // lblProveeActivos
            // 
            this.lblProveeActivos.AutoSize = true;
            this.lblProveeActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveeActivos.Location = new System.Drawing.Point(119, 49);
            this.lblProveeActivos.Name = "lblProveeActivos";
            this.lblProveeActivos.Size = new System.Drawing.Size(32, 15);
            this.lblProveeActivos.TabIndex = 14;
            this.lblProveeActivos.Text = "Total";
            this.lblProveeActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopProveActivos
            // 
            this.lblTopProveActivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopProveActivos.Location = new System.Drawing.Point(73, 26);
            this.lblTopProveActivos.Name = "lblTopProveActivos";
            this.lblTopProveActivos.Size = new System.Drawing.Size(136, 23);
            this.lblTopProveActivos.TabIndex = 12;
            this.lblTopProveActivos.Text = "Proveedores activos";
            this.lblTopProveActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnAltaProveedor
            // 
            this.btnAltaProveedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAltaProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaProveedor.FlatAppearance.BorderSize = 0;
            this.btnAltaProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAltaProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAltaProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaProveedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProveedor.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnAltaProveedor.IconColor = System.Drawing.Color.Black;
            this.btnAltaProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltaProveedor.IconSize = 30;
            this.btnAltaProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaProveedor.Location = new System.Drawing.Point(387, 237);
            this.btnAltaProveedor.Name = "btnAltaProveedor";
            this.btnAltaProveedor.Size = new System.Drawing.Size(220, 56);
            this.btnAltaProveedor.TabIndex = 18;
            this.btnAltaProveedor.Text = "Agregar proveedor";
            this.btnAltaProveedor.UseVisualStyleBackColor = false;
            this.btnAltaProveedor.Click += new System.EventHandler(this.btnAltaProve_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProveedor.FlatAppearance.BorderSize = 0;
            this.btnModificarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnModificarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProveedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProveedor.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnModificarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarProveedor.IconSize = 30;
            this.btnModificarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProveedor.Location = new System.Drawing.Point(387, 340);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(220, 56);
            this.btnModificarProveedor.TabIndex = 19;
            this.btnModificarProveedor.Text = "Modificar proveedor";
            this.btnModificarProveedor.UseVisualStyleBackColor = false;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModProve_Click);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProveedor.FlatAppearance.BorderSize = 0;
            this.btnEliminarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEliminarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnEliminarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnEliminarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarProveedor.IconSize = 30;
            this.btnEliminarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(387, 443);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(220, 56);
            this.btnEliminarProveedor.TabIndex = 20;
            this.btnEliminarProveedor.Text = "Eliminar proveedor";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnBajaProve_Click);
            // 
            // frmAdmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.btnAltaProveedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelAdmvend);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Proveedores - Administrador";
            this.Load += new System.EventHandler(this.frmAdmProveedores_Load);
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
        private System.Windows.Forms.Label lblProveeActivos;
        private System.Windows.Forms.Label lblTopProveActivos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private FontAwesome.Sharp.IconButton btnAltaProveedor;
        private FontAwesome.Sharp.IconButton btnModificarProveedor;
        private FontAwesome.Sharp.IconButton btnEliminarProveedor;
    }
}