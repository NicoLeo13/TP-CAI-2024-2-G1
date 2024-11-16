namespace Presentacion
{
    partial class frmProductosModif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductosModif));
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.txtBoxProd = new System.Windows.Forms.TextBox();
            this.lblInfoDatosProd = new System.Windows.Forms.Label();
            this.btnModificarProd = new FontAwesome.Sharp.IconButton();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.grpDatosProd = new System.Windows.Forms.GroupBox();
            this.txtBoxStockProd = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtBoxPrecioProd = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.panelAdmUsersAlta.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.grpDatosProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdmUsersAlta
            // 
            this.panelAdmUsersAlta.Controls.Add(this.lblTop);
            this.panelAdmUsersAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmUsersAlta.Location = new System.Drawing.Point(18, 0);
            this.panelAdmUsersAlta.Name = "panelAdmUsersAlta";
            this.panelAdmUsersAlta.Size = new System.Drawing.Size(976, 56);
            this.panelAdmUsersAlta.TabIndex = 7;
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(3, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(409, 39);
            this.lblTop.TabIndex = 7;
            this.lblTop.Text = "Panel de Productos - Modificar Productos";
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Teal;
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(18, 566);
            this.panelSide.TabIndex = 34;
            // 
            // txtBoxProd
            // 
            this.txtBoxProd.Location = new System.Drawing.Point(47, 68);
            this.txtBoxProd.Name = "txtBoxProd";
            this.txtBoxProd.Size = new System.Drawing.Size(206, 25);
            this.txtBoxProd.TabIndex = 24;
            // 
            // lblInfoDatosProd
            // 
            this.lblInfoDatosProd.AutoSize = true;
            this.lblInfoDatosProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoDatosProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDatosProd.Location = new System.Drawing.Point(23, 33);
            this.lblInfoDatosProd.Name = "lblInfoDatosProd";
            this.lblInfoDatosProd.Size = new System.Drawing.Size(333, 21);
            this.lblInfoDatosProd.TabIndex = 22;
            this.lblInfoDatosProd.Text = "Ingrese el Nombre del Producto a Modificar";
            this.lblInfoDatosProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnModificarProd
            // 
            this.btnModificarProd.BackColor = System.Drawing.Color.Orange;
            this.btnModificarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProd.FlatAppearance.BorderSize = 0;
            this.btnModificarProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.btnModificarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btnModificarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProd.ForeColor = System.Drawing.Color.Black;
            this.btnModificarProd.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btnModificarProd.IconColor = System.Drawing.Color.Black;
            this.btnModificarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarProd.IconSize = 30;
            this.btnModificarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProd.Location = new System.Drawing.Point(736, 455);
            this.btnModificarProd.Name = "btnModificarProd";
            this.btnModificarProd.Size = new System.Drawing.Size(195, 41);
            this.btnModificarProd.TabIndex = 29;
            this.btnModificarProd.Text = "Modificar Producto";
            this.btnModificarProd.UseVisualStyleBackColor = false;
            this.btnModificarProd.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.btnVolver.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 30;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(27, 455);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 41);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 30;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(279, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 34);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarProducto_click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContenedor.Controls.Add(this.grpDatosProd);
            this.panelContenedor.Controls.Add(this.btnBuscar);
            this.panelContenedor.Controls.Add(this.btnVolver);
            this.panelContenedor.Controls.Add(this.btnModificarProd);
            this.panelContenedor.Controls.Add(this.lblInfoDatosProd);
            this.panelContenedor.Controls.Add(this.txtBoxProd);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(18, 56);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(976, 510);
            this.panelContenedor.TabIndex = 33;
            // 
            // grpDatosProd
            // 
            this.grpDatosProd.Controls.Add(this.txtBoxStockProd);
            this.grpDatosProd.Controls.Add(this.lblStock);
            this.grpDatosProd.Controls.Add(this.txtBoxPrecioProd);
            this.grpDatosProd.Controls.Add(this.lblPrecio);
            this.grpDatosProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosProd.Location = new System.Drawing.Point(318, 131);
            this.grpDatosProd.Name = "grpDatosProd";
            this.grpDatosProd.Size = new System.Drawing.Size(385, 195);
            this.grpDatosProd.TabIndex = 35;
            this.grpDatosProd.TabStop = false;
            this.grpDatosProd.Text = "Datos de Producto";
            // 
            // txtBoxStockProd
            // 
            this.txtBoxStockProd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxStockProd.Enabled = false;
            this.txtBoxStockProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStockProd.Location = new System.Drawing.Point(140, 101);
            this.txtBoxStockProd.Name = "txtBoxStockProd";
            this.txtBoxStockProd.Size = new System.Drawing.Size(230, 25);
            this.txtBoxStockProd.TabIndex = 48;
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(17, 101);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(105, 25);
            this.lblStock.TabIndex = 47;
            this.lblStock.Text = "Stock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxPrecioProd
            // 
            this.txtBoxPrecioProd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxPrecioProd.Enabled = false;
            this.txtBoxPrecioProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrecioProd.Location = new System.Drawing.Point(140, 53);
            this.txtBoxPrecioProd.Name = "txtBoxPrecioProd";
            this.txtBoxPrecioProd.Size = new System.Drawing.Size(230, 25);
            this.txtBoxPrecioProd.TabIndex = 43;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(17, 52);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(105, 25);
            this.lblPrecio.TabIndex = 38;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmProductosModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelAdmUsersAlta);
            this.Controls.Add(this.panelSide);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductosModif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmUsuariosAlta";
            this.Load += new System.EventHandler(this.frmProductosModif_Load);
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.grpDatosProd.ResumeLayout(false);
            this.grpDatosProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.TextBox txtBoxProd;
        private System.Windows.Forms.Label lblInfoDatosProd;
        private FontAwesome.Sharp.IconButton btnModificarProd;
        private FontAwesome.Sharp.IconButton btnVolver;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.GroupBox grpDatosProd;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtBoxPrecioProd;
        private System.Windows.Forms.TextBox txtBoxStockProd;
        private System.Windows.Forms.Label lblStock;
    }
}