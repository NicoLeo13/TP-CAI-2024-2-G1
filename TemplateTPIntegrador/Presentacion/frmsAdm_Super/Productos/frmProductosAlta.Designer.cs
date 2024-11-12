namespace Presentacion
{
    partial class frmProductosAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductosAlta));
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.btnGuardarProducto = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarCampos = new FontAwesome.Sharp.IconButton();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.grpDatosProvee = new System.Windows.Forms.GroupBox();
            this.btnProdBuscarProv = new FontAwesome.Sharp.IconButton();
            this.lblContProvEmail = new System.Windows.Forms.Label();
            this.lblProvEmail = new System.Windows.Forms.Label();
            this.lblContProvApellido = new System.Windows.Forms.Label();
            this.lblProvApellido = new System.Windows.Forms.Label();
            this.lblContProvNombre = new System.Windows.Forms.Label();
            this.lblProvNombre = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtBoxProvCuit = new System.Windows.Forms.TextBox();
            this.grpDatosProd = new System.Windows.Forms.GroupBox();
            this.lblProv = new System.Windows.Forms.Label();
            this.txtBoxIDProveedor = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtBoxStock = new System.Windows.Forms.TextBox();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelAdmUsersAlta.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.grpDatosProvee.SuspendLayout();
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
            this.lblTop.Text = "Panel de Productos - Agregar Productos";
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
            this.btnGuardarProducto.Location = new System.Drawing.Point(349, 460);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(195, 41);
            this.btnGuardarProducto.TabIndex = 29;
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
            this.btnLimpiarCampos.Location = new System.Drawing.Point(754, 460);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(195, 41);
            this.btnLimpiarCampos.TabIndex = 30;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SlateGray;
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
            this.btnVolver.Location = new System.Drawing.Point(27, 460);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 41);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContenedor.Controls.Add(this.grpDatosProvee);
            this.panelContenedor.Controls.Add(this.grpDatosProd);
            this.panelContenedor.Controls.Add(this.btnVolver);
            this.panelContenedor.Controls.Add(this.btnLimpiarCampos);
            this.panelContenedor.Controls.Add(this.btnGuardarProducto);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(18, 56);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(976, 510);
            this.panelContenedor.TabIndex = 33;
            // 
            // grpDatosProvee
            // 
            this.grpDatosProvee.Controls.Add(this.btnProdBuscarProv);
            this.grpDatosProvee.Controls.Add(this.lblContProvEmail);
            this.grpDatosProvee.Controls.Add(this.lblProvEmail);
            this.grpDatosProvee.Controls.Add(this.lblContProvApellido);
            this.grpDatosProvee.Controls.Add(this.lblProvApellido);
            this.grpDatosProvee.Controls.Add(this.lblContProvNombre);
            this.grpDatosProvee.Controls.Add(this.lblProvNombre);
            this.grpDatosProvee.Controls.Add(this.lblCuit);
            this.grpDatosProvee.Controls.Add(this.txtBoxProvCuit);
            this.grpDatosProvee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosProvee.Location = new System.Drawing.Point(538, 26);
            this.grpDatosProvee.Name = "grpDatosProvee";
            this.grpDatosProvee.Size = new System.Drawing.Size(410, 295);
            this.grpDatosProvee.TabIndex = 36;
            this.grpDatosProvee.TabStop = false;
            this.grpDatosProvee.Text = "Datos de Proveedor";
            // 
            // btnProdBuscarProv
            // 
            this.btnProdBuscarProv.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdBuscarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdBuscarProv.FlatAppearance.BorderSize = 0;
            this.btnProdBuscarProv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnProdBuscarProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnProdBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdBuscarProv.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdBuscarProv.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProdBuscarProv.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnProdBuscarProv.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnProdBuscarProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdBuscarProv.IconSize = 30;
            this.btnProdBuscarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdBuscarProv.Location = new System.Drawing.Point(240, 243);
            this.btnProdBuscarProv.Name = "btnProdBuscarProv";
            this.btnProdBuscarProv.Size = new System.Drawing.Size(133, 34);
            this.btnProdBuscarProv.TabIndex = 43;
            this.btnProdBuscarProv.Text = "Buscar";
            this.btnProdBuscarProv.UseVisualStyleBackColor = false;
            this.btnProdBuscarProv.Click += new System.EventHandler(this.btnProdBuscarProv_Click);
            // 
            // lblContProvEmail
            // 
            this.lblContProvEmail.BackColor = System.Drawing.Color.DarkGray;
            this.lblContProvEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContProvEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContProvEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContProvEmail.Location = new System.Drawing.Point(116, 189);
            this.lblContProvEmail.Name = "lblContProvEmail";
            this.lblContProvEmail.Size = new System.Drawing.Size(257, 25);
            this.lblContProvEmail.TabIndex = 42;
            this.lblContProvEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProvEmail
            // 
            this.lblProvEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblProvEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvEmail.Location = new System.Drawing.Point(6, 189);
            this.lblProvEmail.Name = "lblProvEmail";
            this.lblProvEmail.Size = new System.Drawing.Size(105, 25);
            this.lblProvEmail.TabIndex = 41;
            this.lblProvEmail.Text = "Email";
            this.lblProvEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContProvApellido
            // 
            this.lblContProvApellido.BackColor = System.Drawing.Color.DarkGray;
            this.lblContProvApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContProvApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContProvApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContProvApellido.Location = new System.Drawing.Point(116, 139);
            this.lblContProvApellido.Name = "lblContProvApellido";
            this.lblContProvApellido.Size = new System.Drawing.Size(257, 25);
            this.lblContProvApellido.TabIndex = 40;
            this.lblContProvApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProvApellido
            // 
            this.lblProvApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblProvApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvApellido.Location = new System.Drawing.Point(6, 139);
            this.lblProvApellido.Name = "lblProvApellido";
            this.lblProvApellido.Size = new System.Drawing.Size(105, 25);
            this.lblProvApellido.TabIndex = 39;
            this.lblProvApellido.Text = "Apellido";
            this.lblProvApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContProvNombre
            // 
            this.lblContProvNombre.BackColor = System.Drawing.Color.DarkGray;
            this.lblContProvNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContProvNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContProvNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContProvNombre.Location = new System.Drawing.Point(116, 89);
            this.lblContProvNombre.Name = "lblContProvNombre";
            this.lblContProvNombre.Size = new System.Drawing.Size(257, 25);
            this.lblContProvNombre.TabIndex = 38;
            this.lblContProvNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProvNombre
            // 
            this.lblProvNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblProvNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvNombre.Location = new System.Drawing.Point(6, 89);
            this.lblProvNombre.Name = "lblProvNombre";
            this.lblProvNombre.Size = new System.Drawing.Size(105, 25);
            this.lblProvNombre.TabIndex = 25;
            this.lblProvNombre.Text = "Nombre";
            this.lblProvNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCuit
            // 
            this.lblCuit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCuit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.Location = new System.Drawing.Point(6, 35);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(90, 25);
            this.lblCuit.TabIndex = 23;
            this.lblCuit.Text = "CUIT";
            this.lblCuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxProvCuit
            // 
            this.txtBoxProvCuit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProvCuit.Location = new System.Drawing.Point(116, 36);
            this.txtBoxProvCuit.MaxLength = 11;
            this.txtBoxProvCuit.Name = "txtBoxProvCuit";
            this.txtBoxProvCuit.Size = new System.Drawing.Size(257, 25);
            this.txtBoxProvCuit.TabIndex = 24;
            // 
            // grpDatosProd
            // 
            this.grpDatosProd.Controls.Add(this.lblProv);
            this.grpDatosProd.Controls.Add(this.txtBoxIDProveedor);
            this.grpDatosProd.Controls.Add(this.cmbCategoria);
            this.grpDatosProd.Controls.Add(this.lblCategoria);
            this.grpDatosProd.Controls.Add(this.lblNombre);
            this.grpDatosProd.Controls.Add(this.txtBoxNombre);
            this.grpDatosProd.Controls.Add(this.lblPrecio);
            this.grpDatosProd.Controls.Add(this.txtBoxPrecio);
            this.grpDatosProd.Controls.Add(this.lblStock);
            this.grpDatosProd.Controls.Add(this.txtBoxStock);
            this.grpDatosProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosProd.Location = new System.Drawing.Point(27, 26);
            this.grpDatosProd.Name = "grpDatosProd";
            this.grpDatosProd.Size = new System.Drawing.Size(454, 295);
            this.grpDatosProd.TabIndex = 35;
            this.grpDatosProd.TabStop = false;
            this.grpDatosProd.Text = "Datos de Producto";
            // 
            // lblProv
            // 
            this.lblProv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblProv.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProv.Location = new System.Drawing.Point(34, 243);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(90, 25);
            this.lblProv.TabIndex = 25;
            this.lblProv.Text = "ID Proveedor";
            this.lblProv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxIDProveedor
            // 
            this.txtBoxIDProveedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIDProveedor.Location = new System.Drawing.Point(144, 244);
            this.txtBoxIDProveedor.Name = "txtBoxIDProveedor";
            this.txtBoxIDProveedor.Size = new System.Drawing.Size(257, 25);
            this.txtBoxIDProveedor.TabIndex = 26;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(144, 35);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(257, 25);
            this.cmbCategoria.TabIndex = 22;
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(34, 34);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(105, 25);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "ID Categoria";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(34, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(105, 25);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombre.Location = new System.Drawing.Point(144, 85);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(257, 25);
            this.txtBoxNombre.TabIndex = 13;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(34, 134);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(105, 25);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrecio.Location = new System.Drawing.Point(144, 135);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(257, 25);
            this.txtBoxPrecio.TabIndex = 15;
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(34, 184);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(105, 25);
            this.lblStock.TabIndex = 20;
            this.lblStock.Text = "Stock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxStock
            // 
            this.txtBoxStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStock.Location = new System.Drawing.Point(146, 185);
            this.txtBoxStock.Name = "txtBoxStock";
            this.txtBoxStock.Size = new System.Drawing.Size(257, 25);
            this.txtBoxStock.TabIndex = 21;
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
            // frmProductosAlta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelAdmUsersAlta);
            this.Controls.Add(this.panelSide);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductosAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmUsuariosAlta";
            this.Load += new System.EventHandler(this.frmProductosAlta_Load);
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.grpDatosProvee.ResumeLayout(false);
            this.grpDatosProvee.PerformLayout();
            this.grpDatosProd.ResumeLayout(false);
            this.grpDatosProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label lblTop;
        private FontAwesome.Sharp.IconButton btnGuardarProducto;
        private FontAwesome.Sharp.IconButton btnLimpiarCampos;
        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.GroupBox grpDatosProd;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtBoxStock;
        private System.Windows.Forms.GroupBox grpDatosProvee;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtBoxProvCuit;
        private System.Windows.Forms.Label lblProvNombre;
        private System.Windows.Forms.Label lblContProvEmail;
        private System.Windows.Forms.Label lblProvEmail;
        private System.Windows.Forms.Label lblContProvApellido;
        private System.Windows.Forms.Label lblProvApellido;
        private System.Windows.Forms.Label lblContProvNombre;
        private FontAwesome.Sharp.IconButton btnProdBuscarProv;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.TextBox txtBoxIDProveedor;
    }
}