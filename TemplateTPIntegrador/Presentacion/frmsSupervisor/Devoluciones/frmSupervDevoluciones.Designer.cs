namespace Presentacion
{
    partial class frmSupervDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupervDevoluciones));
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.txtBoxIdVenta = new System.Windows.Forms.TextBox();
            this.lblProdId = new System.Windows.Forms.Label();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.lblInfoDatosVenta = new System.Windows.Forms.Label();
            this.btnDevolverVenta = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.grpDatosVentaCliente = new System.Windows.Forms.GroupBox();
            this.lblContClienteId = new System.Windows.Forms.Label();
            this.lblContClienteEmail = new System.Windows.Forms.Label();
            this.lblClienteEmail = new System.Windows.Forms.Label();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.lblContClienteDni = new System.Windows.Forms.Label();
            this.lblClienteDni = new System.Windows.Forms.Label();
            this.lblContClienteApellido = new System.Windows.Forms.Label();
            this.lblContClienteNombre = new System.Windows.Forms.Label();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.lblClienteApellido = new System.Windows.Forms.Label();
            this.grpVenta = new System.Windows.Forms.GroupBox();
            this.lblContVendId = new System.Windows.Forms.Label();
            this.lblContCantidad = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblIdVendVenta = new System.Windows.Forms.Label();
            this.lblContPrecio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblContProducto = new System.Windows.Forms.Label();
            this.lblContProductoId = new System.Windows.Forms.Label();
            this.panelAdmUsersAlta.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.grpDatosVentaCliente.SuspendLayout();
            this.grpVenta.SuspendLayout();
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
            this.lblTop.Text = "Panel de Devoluciones - Devolver Venta";
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
            // txtBoxIdVenta
            // 
            this.txtBoxIdVenta.Location = new System.Drawing.Point(47, 68);
            this.txtBoxIdVenta.Name = "txtBoxIdVenta";
            this.txtBoxIdVenta.Size = new System.Drawing.Size(206, 25);
            this.txtBoxIdVenta.TabIndex = 24;
            // 
            // lblProdId
            // 
            this.lblProdId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblProdId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdId.Location = new System.Drawing.Point(6, 94);
            this.lblProdId.Name = "lblProdId";
            this.lblProdId.Size = new System.Drawing.Size(105, 25);
            this.lblProdId.TabIndex = 9;
            this.lblProdId.Text = "ID Producto";
            this.lblProdId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.Location = new System.Drawing.Point(6, 141);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(105, 25);
            this.lblNombreProd.TabIndex = 12;
            this.lblNombreProd.Text = "Producto";
            this.lblNombreProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoDatosVenta
            // 
            this.lblInfoDatosVenta.AutoSize = true;
            this.lblInfoDatosVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoDatosVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDatosVenta.Location = new System.Drawing.Point(23, 33);
            this.lblInfoDatosVenta.Name = "lblInfoDatosVenta";
            this.lblInfoDatosVenta.Size = new System.Drawing.Size(279, 21);
            this.lblInfoDatosVenta.TabIndex = 22;
            this.lblInfoDatosVenta.Text = "Ingrese el ID de Venta a dar Devolver";
            this.lblInfoDatosVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDevolverVenta
            // 
            this.btnDevolverVenta.BackColor = System.Drawing.Color.Firebrick;
            this.btnDevolverVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolverVenta.FlatAppearance.BorderSize = 0;
            this.btnDevolverVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnDevolverVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnDevolverVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolverVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDevolverVenta.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDevolverVenta.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnDevolverVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDevolverVenta.IconSize = 30;
            this.btnDevolverVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolverVenta.Location = new System.Drawing.Point(737, 455);
            this.btnDevolverVenta.Name = "btnDevolverVenta";
            this.btnDevolverVenta.Size = new System.Drawing.Size(195, 41);
            this.btnDevolverVenta.TabIndex = 29;
            this.btnDevolverVenta.Text = "Devolver Venta";
            this.btnDevolverVenta.UseVisualStyleBackColor = false;
            this.btnDevolverVenta.Click += new System.EventHandler(this.btnDevolverVenta_Click);
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarVenta_click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContenedor.Controls.Add(this.grpDatosVentaCliente);
            this.panelContenedor.Controls.Add(this.grpVenta);
            this.panelContenedor.Controls.Add(this.btnBuscar);
            this.panelContenedor.Controls.Add(this.btnDevolverVenta);
            this.panelContenedor.Controls.Add(this.lblInfoDatosVenta);
            this.panelContenedor.Controls.Add(this.txtBoxIdVenta);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(18, 56);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(976, 510);
            this.panelContenedor.TabIndex = 33;
            // 
            // grpDatosVentaCliente
            // 
            this.grpDatosVentaCliente.Controls.Add(this.lblContClienteId);
            this.grpDatosVentaCliente.Controls.Add(this.lblContClienteEmail);
            this.grpDatosVentaCliente.Controls.Add(this.lblClienteEmail);
            this.grpDatosVentaCliente.Controls.Add(this.lblClienteId);
            this.grpDatosVentaCliente.Controls.Add(this.lblContClienteDni);
            this.grpDatosVentaCliente.Controls.Add(this.lblClienteDni);
            this.grpDatosVentaCliente.Controls.Add(this.lblContClienteApellido);
            this.grpDatosVentaCliente.Controls.Add(this.lblContClienteNombre);
            this.grpDatosVentaCliente.Controls.Add(this.lblClienteNombre);
            this.grpDatosVentaCliente.Controls.Add(this.lblClienteApellido);
            this.grpDatosVentaCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosVentaCliente.Location = new System.Drawing.Point(547, 119);
            this.grpDatosVentaCliente.Name = "grpDatosVentaCliente";
            this.grpDatosVentaCliente.Size = new System.Drawing.Size(385, 293);
            this.grpDatosVentaCliente.TabIndex = 46;
            this.grpDatosVentaCliente.TabStop = false;
            this.grpDatosVentaCliente.Text = "Datos de Cliente";
            // 
            // lblContClienteId
            // 
            this.lblContClienteId.BackColor = System.Drawing.Color.DarkGray;
            this.lblContClienteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContClienteId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContClienteId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContClienteId.Location = new System.Drawing.Point(129, 47);
            this.lblContClienteId.Name = "lblContClienteId";
            this.lblContClienteId.Size = new System.Drawing.Size(230, 25);
            this.lblContClienteId.TabIndex = 45;
            this.lblContClienteId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContClienteEmail
            // 
            this.lblContClienteEmail.BackColor = System.Drawing.Color.DarkGray;
            this.lblContClienteEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContClienteEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContClienteEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContClienteEmail.Location = new System.Drawing.Point(129, 235);
            this.lblContClienteEmail.Name = "lblContClienteEmail";
            this.lblContClienteEmail.Size = new System.Drawing.Size(230, 25);
            this.lblContClienteEmail.TabIndex = 43;
            this.lblContClienteEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClienteEmail
            // 
            this.lblClienteEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblClienteEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteEmail.Location = new System.Drawing.Point(6, 235);
            this.lblClienteEmail.Name = "lblClienteEmail";
            this.lblClienteEmail.Size = new System.Drawing.Size(105, 25);
            this.lblClienteEmail.TabIndex = 42;
            this.lblClienteEmail.Text = "Email";
            this.lblClienteEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClienteId
            // 
            this.lblClienteId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblClienteId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteId.Location = new System.Drawing.Point(6, 47);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(105, 25);
            this.lblClienteId.TabIndex = 44;
            this.lblClienteId.Text = "ID Cliente";
            this.lblClienteId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContClienteDni
            // 
            this.lblContClienteDni.BackColor = System.Drawing.Color.DarkGray;
            this.lblContClienteDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContClienteDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContClienteDni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContClienteDni.Location = new System.Drawing.Point(129, 188);
            this.lblContClienteDni.Name = "lblContClienteDni";
            this.lblContClienteDni.Size = new System.Drawing.Size(230, 25);
            this.lblContClienteDni.TabIndex = 39;
            this.lblContClienteDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClienteDni
            // 
            this.lblClienteDni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblClienteDni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteDni.Location = new System.Drawing.Point(6, 188);
            this.lblClienteDni.Name = "lblClienteDni";
            this.lblClienteDni.Size = new System.Drawing.Size(105, 25);
            this.lblClienteDni.TabIndex = 38;
            this.lblClienteDni.Text = "DNI";
            this.lblClienteDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContClienteApellido
            // 
            this.lblContClienteApellido.BackColor = System.Drawing.Color.DarkGray;
            this.lblContClienteApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContClienteApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContClienteApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContClienteApellido.Location = new System.Drawing.Point(129, 141);
            this.lblContClienteApellido.Name = "lblContClienteApellido";
            this.lblContClienteApellido.Size = new System.Drawing.Size(230, 25);
            this.lblContClienteApellido.TabIndex = 34;
            this.lblContClienteApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContClienteNombre
            // 
            this.lblContClienteNombre.BackColor = System.Drawing.Color.DarkGray;
            this.lblContClienteNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContClienteNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContClienteNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContClienteNombre.Location = new System.Drawing.Point(129, 94);
            this.lblContClienteNombre.Name = "lblContClienteNombre";
            this.lblContClienteNombre.Size = new System.Drawing.Size(230, 25);
            this.lblContClienteNombre.TabIndex = 33;
            this.lblContClienteNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblClienteNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.Location = new System.Drawing.Point(6, 94);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(105, 25);
            this.lblClienteNombre.TabIndex = 9;
            this.lblClienteNombre.Text = "Nombre";
            this.lblClienteNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClienteApellido
            // 
            this.lblClienteApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblClienteApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteApellido.Location = new System.Drawing.Point(6, 141);
            this.lblClienteApellido.Name = "lblClienteApellido";
            this.lblClienteApellido.Size = new System.Drawing.Size(105, 25);
            this.lblClienteApellido.TabIndex = 12;
            this.lblClienteApellido.Text = "Apellido";
            this.lblClienteApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpVenta
            // 
            this.grpVenta.Controls.Add(this.lblContVendId);
            this.grpVenta.Controls.Add(this.lblContCantidad);
            this.grpVenta.Controls.Add(this.lblCantidad);
            this.grpVenta.Controls.Add(this.lblIdVendVenta);
            this.grpVenta.Controls.Add(this.lblContPrecio);
            this.grpVenta.Controls.Add(this.lblPrecio);
            this.grpVenta.Controls.Add(this.lblContProducto);
            this.grpVenta.Controls.Add(this.lblContProductoId);
            this.grpVenta.Controls.Add(this.lblProdId);
            this.grpVenta.Controls.Add(this.lblNombreProd);
            this.grpVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVenta.Location = new System.Drawing.Point(25, 119);
            this.grpVenta.Name = "grpVenta";
            this.grpVenta.Size = new System.Drawing.Size(385, 293);
            this.grpVenta.TabIndex = 35;
            this.grpVenta.TabStop = false;
            this.grpVenta.Text = "Datos de Venta";
            // 
            // lblContVendId
            // 
            this.lblContVendId.BackColor = System.Drawing.Color.DarkGray;
            this.lblContVendId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContVendId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContVendId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContVendId.Location = new System.Drawing.Point(129, 47);
            this.lblContVendId.Name = "lblContVendId";
            this.lblContVendId.Size = new System.Drawing.Size(230, 25);
            this.lblContVendId.TabIndex = 45;
            this.lblContVendId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContCantidad
            // 
            this.lblContCantidad.BackColor = System.Drawing.Color.DarkGray;
            this.lblContCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContCantidad.Location = new System.Drawing.Point(129, 235);
            this.lblContCantidad.Name = "lblContCantidad";
            this.lblContCantidad.Size = new System.Drawing.Size(230, 25);
            this.lblContCantidad.TabIndex = 43;
            this.lblContCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(6, 235);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(105, 25);
            this.lblCantidad.TabIndex = 42;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdVendVenta
            // 
            this.lblIdVendVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdVendVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVendVenta.Location = new System.Drawing.Point(6, 47);
            this.lblIdVendVenta.Name = "lblIdVendVenta";
            this.lblIdVendVenta.Size = new System.Drawing.Size(105, 25);
            this.lblIdVendVenta.TabIndex = 44;
            this.lblIdVendVenta.Text = "ID Vendedor";
            this.lblIdVendVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContPrecio
            // 
            this.lblContPrecio.BackColor = System.Drawing.Color.DarkGray;
            this.lblContPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContPrecio.Location = new System.Drawing.Point(129, 188);
            this.lblContPrecio.Name = "lblContPrecio";
            this.lblContPrecio.Size = new System.Drawing.Size(230, 25);
            this.lblContPrecio.TabIndex = 39;
            this.lblContPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(6, 188);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(105, 25);
            this.lblPrecio.TabIndex = 38;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContProducto
            // 
            this.lblContProducto.BackColor = System.Drawing.Color.DarkGray;
            this.lblContProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContProducto.Location = new System.Drawing.Point(129, 141);
            this.lblContProducto.Name = "lblContProducto";
            this.lblContProducto.Size = new System.Drawing.Size(230, 25);
            this.lblContProducto.TabIndex = 34;
            this.lblContProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContProductoId
            // 
            this.lblContProductoId.BackColor = System.Drawing.Color.DarkGray;
            this.lblContProductoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContProductoId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContProductoId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContProductoId.Location = new System.Drawing.Point(129, 94);
            this.lblContProductoId.Name = "lblContProductoId";
            this.lblContProductoId.Size = new System.Drawing.Size(230, 25);
            this.lblContProductoId.TabIndex = 33;
            this.lblContProductoId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSupervDevoluciones
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
            this.Name = "frmSupervDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Devoluciones";
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.grpDatosVentaCliente.ResumeLayout(false);
            this.grpVenta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.TextBox txtBoxIdVenta;
        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Label lblInfoDatosVenta;
        private FontAwesome.Sharp.IconButton btnDevolverVenta;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.GroupBox grpVenta;
        private System.Windows.Forms.Label lblContProducto;
        private System.Windows.Forms.Label lblContProductoId;
        private System.Windows.Forms.Label lblContPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblContCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblContVendId;
        private System.Windows.Forms.Label lblIdVendVenta;
        private System.Windows.Forms.GroupBox grpDatosVentaCliente;
        private System.Windows.Forms.Label lblContClienteId;
        private System.Windows.Forms.Label lblContClienteEmail;
        private System.Windows.Forms.Label lblClienteEmail;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.Label lblContClienteDni;
        private System.Windows.Forms.Label lblClienteDni;
        private System.Windows.Forms.Label lblContClienteApellido;
        private System.Windows.Forms.Label lblContClienteNombre;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.Label lblClienteApellido;
    }
}