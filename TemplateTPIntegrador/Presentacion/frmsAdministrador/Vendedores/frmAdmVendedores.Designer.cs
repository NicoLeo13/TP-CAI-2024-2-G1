namespace Presentacion
{
    partial class frmAdmVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmVendedores));
            this.panelAdmvend = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVendActivos = new System.Windows.Forms.Label();
            this.lblTopVendActivos = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnAltaVendedor = new FontAwesome.Sharp.IconButton();
            this.btnModificarVendedor = new FontAwesome.Sharp.IconButton();
            this.btnEliminarVendedor = new FontAwesome.Sharp.IconButton();
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
            this.lblTop.Text = "Panel de Vendedores - Seleccione una Acción";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblVendActivos);
            this.panel2.Controls.Add(this.lblTopVendActivos);
            this.panel2.Controls.Add(this.guna2CirclePictureBox2);
            this.panel2.Location = new System.Drawing.Point(387, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 119);
            this.panel2.TabIndex = 8;
            // 
            // lblVendActivos
            // 
            this.lblVendActivos.AutoSize = true;
            this.lblVendActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendActivos.Location = new System.Drawing.Point(119, 49);
            this.lblVendActivos.Name = "lblVendActivos";
            this.lblVendActivos.Size = new System.Drawing.Size(32, 15);
            this.lblVendActivos.TabIndex = 14;
            this.lblVendActivos.Text = "Total";
            this.lblVendActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopVendActivos
            // 
            this.lblTopVendActivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopVendActivos.Location = new System.Drawing.Point(73, 26);
            this.lblTopVendActivos.Name = "lblTopVendActivos";
            this.lblTopVendActivos.Size = new System.Drawing.Size(136, 23);
            this.lblTopVendActivos.TabIndex = 12;
            this.lblTopVendActivos.Text = "Vendedores Activos";
            this.lblTopVendActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnAltaVendedor
            // 
            this.btnAltaVendedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAltaVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaVendedor.FlatAppearance.BorderSize = 0;
            this.btnAltaVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAltaVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAltaVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaVendedor.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAltaVendedor.IconColor = System.Drawing.Color.Black;
            this.btnAltaVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltaVendedor.IconSize = 30;
            this.btnAltaVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaVendedor.Location = new System.Drawing.Point(387, 237);
            this.btnAltaVendedor.Name = "btnAltaVendedor";
            this.btnAltaVendedor.Size = new System.Drawing.Size(220, 56);
            this.btnAltaVendedor.TabIndex = 18;
            this.btnAltaVendedor.Text = "Agregar Vendedor";
            this.btnAltaVendedor.UseVisualStyleBackColor = false;
            this.btnAltaVendedor.Click += new System.EventHandler(this.btnAltaVend_Click);
            // 
            // btnModificarVendedor
            // 
            this.btnModificarVendedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarVendedor.FlatAppearance.BorderSize = 0;
            this.btnModificarVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnModificarVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarVendedor.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificarVendedor.IconColor = System.Drawing.Color.Black;
            this.btnModificarVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarVendedor.IconSize = 30;
            this.btnModificarVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarVendedor.Location = new System.Drawing.Point(387, 340);
            this.btnModificarVendedor.Name = "btnModificarVendedor";
            this.btnModificarVendedor.Size = new System.Drawing.Size(220, 56);
            this.btnModificarVendedor.TabIndex = 19;
            this.btnModificarVendedor.Text = "Modificar Vendedor";
            this.btnModificarVendedor.UseVisualStyleBackColor = false;
            this.btnModificarVendedor.Click += new System.EventHandler(this.btnModVend_Click);
            // 
            // btnEliminarVendedor
            // 
            this.btnEliminarVendedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarVendedor.FlatAppearance.BorderSize = 0;
            this.btnEliminarVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEliminarVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVendedor.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnEliminarVendedor.IconColor = System.Drawing.Color.Black;
            this.btnEliminarVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarVendedor.IconSize = 30;
            this.btnEliminarVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarVendedor.Location = new System.Drawing.Point(387, 443);
            this.btnEliminarVendedor.Name = "btnEliminarVendedor";
            this.btnEliminarVendedor.Size = new System.Drawing.Size(220, 56);
            this.btnEliminarVendedor.TabIndex = 20;
            this.btnEliminarVendedor.Text = "Eliminar Vendedor";
            this.btnEliminarVendedor.UseVisualStyleBackColor = false;
            this.btnEliminarVendedor.Click += new System.EventHandler(this.btnBajaVend_Click);
            // 
            // frmAdmVendedores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.btnEliminarVendedor);
            this.Controls.Add(this.btnModificarVendedor);
            this.Controls.Add(this.btnAltaVendedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelAdmvend);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmVendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Vendedores - Administrador";
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
        private System.Windows.Forms.Label lblVendActivos;
        private System.Windows.Forms.Label lblTopVendActivos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private FontAwesome.Sharp.IconButton btnAltaVendedor;
        private FontAwesome.Sharp.IconButton btnModificarVendedor;
        private FontAwesome.Sharp.IconButton btnEliminarVendedor;
    }
}