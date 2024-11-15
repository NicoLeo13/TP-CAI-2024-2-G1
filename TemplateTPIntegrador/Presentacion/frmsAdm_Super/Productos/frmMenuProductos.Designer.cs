namespace Presentacion
{
    partial class frmMenuProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuProductos));
            this.panelAdmvend = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProdActivos = new System.Windows.Forms.Label();
            this.lblTopProdActivos = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnAltaProducto = new FontAwesome.Sharp.IconButton();
            this.btnModificarProducto = new FontAwesome.Sharp.IconButton();
            this.btnEliminarProducto = new FontAwesome.Sharp.IconButton();
            this.btnListarProductos = new FontAwesome.Sharp.IconButton();
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
            this.lblTop.Text = "Panel de Productos - Seleccione una Acción";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblProdActivos);
            this.panel2.Controls.Add(this.lblTopProdActivos);
            this.panel2.Controls.Add(this.guna2CirclePictureBox2);
            this.panel2.Location = new System.Drawing.Point(387, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 119);
            this.panel2.TabIndex = 8;
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
            // btnAltaProducto
            // 
            this.btnAltaProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAltaProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaProducto.FlatAppearance.BorderSize = 0;
            this.btnAltaProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAltaProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAltaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProducto.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.btnAltaProducto.IconColor = System.Drawing.Color.Black;
            this.btnAltaProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltaProducto.IconSize = 30;
            this.btnAltaProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaProducto.Location = new System.Drawing.Point(387, 297);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(220, 56);
            this.btnAltaProducto.TabIndex = 18;
            this.btnAltaProducto.Text = "Agregar Producto";
            this.btnAltaProducto.UseVisualStyleBackColor = false;
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProducto.FlatAppearance.BorderSize = 0;
            this.btnModificarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnModificarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificarProducto.IconColor = System.Drawing.Color.Black;
            this.btnModificarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarProducto.IconSize = 30;
            this.btnModificarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProducto.Location = new System.Drawing.Point(387, 393);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(220, 56);
            this.btnModificarProducto.TabIndex = 19;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarProducto.IconColor = System.Drawing.Color.Black;
            this.btnEliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarProducto.IconSize = 30;
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(387, 489);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(220, 56);
            this.btnEliminarProducto.TabIndex = 20;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnBajaProd_Click);
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnListarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarProductos.FlatAppearance.BorderSize = 0;
            this.btnListarProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnListarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnListarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProductos.IconChar = FontAwesome.Sharp.IconChar.ClipboardQuestion;
            this.btnListarProductos.IconColor = System.Drawing.Color.Black;
            this.btnListarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarProductos.IconSize = 30;
            this.btnListarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarProductos.Location = new System.Drawing.Point(390, 201);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(220, 56);
            this.btnListarProductos.TabIndex = 69;
            this.btnListarProductos.Text = "Listar Productos";
            this.btnListarProductos.UseVisualStyleBackColor = false;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // frmMenuProductos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.btnListarProductos);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnAltaProducto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelAdmvend);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
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
        private System.Windows.Forms.Label lblProdActivos;
        private System.Windows.Forms.Label lblTopProdActivos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private FontAwesome.Sharp.IconButton btnAltaProducto;
        private FontAwesome.Sharp.IconButton btnModificarProducto;
        private FontAwesome.Sharp.IconButton btnEliminarProducto;
        private FontAwesome.Sharp.IconButton btnListarProductos;
    }
}