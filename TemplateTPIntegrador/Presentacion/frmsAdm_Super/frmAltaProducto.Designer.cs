namespace Presentacion
{
    partial class frmAltaProducto
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
            this.panelSupProdAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxStock = new System.Windows.Forms.TextBox();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxIDProveedor = new System.Windows.Forms.TextBox();
            this.txtBoxIDUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxIDCategoria = new System.Windows.Forms.TextBox();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.btnGuardarProducto = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarCampos = new FontAwesome.Sharp.IconButton();
            this.panelSupProdAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSupProdAlta
            // 
            this.panelSupProdAlta.Controls.Add(this.lblTop);
            this.panelSupProdAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupProdAlta.Location = new System.Drawing.Point(0, 0);
            this.panelSupProdAlta.Name = "panelSupProdAlta";
            this.panelSupProdAlta.Size = new System.Drawing.Size(465, 56);
            this.panelSupProdAlta.TabIndex = 8;
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(3, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(409, 39);
            this.lblTop.TabIndex = 7;
            this.lblTop.Text = "Panel de Productos - Agregar Producto";
            // 
            // lblDni
            // 
            this.lblDni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(55, 237);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(105, 25);
            this.lblDni.TabIndex = 39;
            this.lblDni.Text = "Stock";
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(55, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(105, 25);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "Precio";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelefono
            // 
            this.lblTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(55, 175);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(105, 25);
            this.lblTelefono.TabIndex = 43;
            this.lblTelefono.Text = "Nombre";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDireccion
            // 
            this.lblDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(55, 144);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(105, 25);
            this.lblDireccion.TabIndex = 37;
            this.lblDireccion.Text = "ID Proveedor";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(55, 113);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(105, 25);
            this.lblApellido.TabIndex = 35;
            this.lblApellido.Text = "ID Usuario";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(56, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(105, 25);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "ID Categoria";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxStock
            // 
            this.txtBoxStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStock.Location = new System.Drawing.Point(165, 238);
            this.txtBoxStock.Name = "txtBoxStock";
            this.txtBoxStock.Size = new System.Drawing.Size(258, 23);
            this.txtBoxStock.TabIndex = 40;
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrecio.Location = new System.Drawing.Point(166, 207);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(257, 23);
            this.txtBoxPrecio.TabIndex = 42;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombre.Location = new System.Drawing.Point(166, 176);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(257, 23);
            this.txtBoxNombre.TabIndex = 44;
            // 
            // txtBoxIDProveedor
            // 
            this.txtBoxIDProveedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIDProveedor.Location = new System.Drawing.Point(166, 145);
            this.txtBoxIDProveedor.Name = "txtBoxIDProveedor";
            this.txtBoxIDProveedor.Size = new System.Drawing.Size(257, 23);
            this.txtBoxIDProveedor.TabIndex = 38;
            // 
            // txtBoxIDUsuario
            // 
            this.txtBoxIDUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIDUsuario.Location = new System.Drawing.Point(166, 114);
            this.txtBoxIDUsuario.Name = "txtBoxIDUsuario";
            this.txtBoxIDUsuario.Size = new System.Drawing.Size(257, 23);
            this.txtBoxIDUsuario.TabIndex = 36;
            // 
            // txtBoxIDCategoria
            // 
            this.txtBoxIDCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIDCategoria.Location = new System.Drawing.Point(165, 82);
            this.txtBoxIDCategoria.Name = "txtBoxIDCategoria";
            this.txtBoxIDCategoria.Size = new System.Drawing.Size(257, 23);
            this.txtBoxIDCategoria.TabIndex = 34;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.btnVolver.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 30;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(22, 311);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 41);
            this.btnVolver.TabIndex = 45;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarProducto.FlatAppearance.BorderSize = 0;
            this.btnGuardarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnGuardarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarProducto.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarProducto.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarProducto.IconSize = 30;
            this.btnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProducto.Location = new System.Drawing.Point(258, 289);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(195, 41);
            this.btnGuardarProducto.TabIndex = 46;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnLimpiarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarCampos.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarCampos.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarCampos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarCampos.IconSize = 30;
            this.btnLimpiarCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(258, 347);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(195, 41);
            this.btnLimpiarCampos.TabIndex = 47;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // AltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 400);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxStock);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtBoxIDProveedor);
            this.Controls.Add(this.txtBoxIDUsuario);
            this.Controls.Add(this.txtBoxIDCategoria);
            this.Controls.Add(this.panelSupProdAlta);
            this.Name = "AltaProducto";
            this.Text = "ElectroHogar S.A - Alta de Producto";
            this.panelSupProdAlta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSupProdAlta;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxStock;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxIDProveedor;
        private System.Windows.Forms.TextBox txtBoxIDUsuario;
        private System.Windows.Forms.TextBox txtBoxIDCategoria;
        private FontAwesome.Sharp.IconButton btnVolver;
        private FontAwesome.Sharp.IconButton btnGuardarProducto;
        private FontAwesome.Sharp.IconButton btnLimpiarCampos;
    }
}