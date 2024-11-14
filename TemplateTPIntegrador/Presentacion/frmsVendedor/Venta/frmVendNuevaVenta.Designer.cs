namespace Presentacion
{
    partial class frmVendNuevaVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendNuevaVenta));
            this.btnCargarVenta = new FontAwesome.Sharp.IconButton();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.lblInfoDatosProd = new System.Windows.Forms.Label();
            this.txtBoxNombreProd = new System.Windows.Forms.TextBox();
            this.grpDatosStock = new System.Windows.Forms.GroupBox();
            this.lblContIdProd = new System.Windows.Forms.Label();
            this.lblIdProd = new System.Windows.Forms.Label();
            this.lblContStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblContPrecio = new System.Windows.Forms.Label();
            this.grpVenta = new System.Windows.Forms.GroupBox();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblCliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregarAlCarrito = new FontAwesome.Sharp.IconButton();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStockFinal = new System.Windows.Forms.Label();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.lblContNombreApellido = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblContClienteTelefono = new System.Windows.Forms.Label();
            this.lblClienteDireccion = new System.Windows.Forms.Label();
            this.lblClienteTelefono = new System.Windows.Forms.Label();
            this.lblContClienteDireccion = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarDelCarrito = new FontAwesome.Sharp.IconButton();
            this.btnCancelarOperacion = new FontAwesome.Sharp.IconButton();
            this.panelAdmUsersAlta.SuspendLayout();
            this.grpDatosStock.SuspendLayout();
            this.grpVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.grpCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargarVenta
            // 
            this.btnCargarVenta.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCargarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarVenta.FlatAppearance.BorderSize = 0;
            this.btnCargarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnCargarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnCargarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCargarVenta.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnCargarVenta.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnCargarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarVenta.IconSize = 30;
            this.btnCargarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarVenta.Location = new System.Drawing.Point(781, 513);
            this.btnCargarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarVenta.Name = "btnCargarVenta";
            this.btnCargarVenta.Size = new System.Drawing.Size(195, 41);
            this.btnCargarVenta.TabIndex = 37;
            this.btnCargarVenta.Text = "Guardar";
            this.btnCargarVenta.UseVisualStyleBackColor = false;
            this.btnCargarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Teal;
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(18, 566);
            this.panelSide.TabIndex = 63;
            // 
            // panelAdmUsersAlta
            // 
            this.panelAdmUsersAlta.Controls.Add(this.lblTop);
            this.panelAdmUsersAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmUsersAlta.Location = new System.Drawing.Point(18, 0);
            this.panelAdmUsersAlta.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdmUsersAlta.Name = "panelAdmUsersAlta";
            this.panelAdmUsersAlta.Size = new System.Drawing.Size(976, 46);
            this.panelAdmUsersAlta.TabIndex = 64;
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(2, 7);
            this.lblTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(579, 32);
            this.lblTop.TabIndex = 7;
            this.lblTop.Text = "Panel de Vendedor - Ingrese nueva venta\r\n";
            this.lblTop.Click += new System.EventHandler(this.lblTop_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(304, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 34);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblInfoDatosProd
            // 
            this.lblInfoDatosProd.AutoSize = true;
            this.lblInfoDatosProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoDatosProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDatosProd.Location = new System.Drawing.Point(48, 61);
            this.lblInfoDatosProd.Name = "lblInfoDatosProd";
            this.lblInfoDatosProd.Size = new System.Drawing.Size(246, 21);
            this.lblInfoDatosProd.TabIndex = 71;
            this.lblInfoDatosProd.Text = "Ingrese el Nombre del Producto";
            this.lblInfoDatosProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxNombreProd
            // 
            this.txtBoxNombreProd.Location = new System.Drawing.Point(72, 96);
            this.txtBoxNombreProd.Name = "txtBoxNombreProd";
            this.txtBoxNombreProd.Size = new System.Drawing.Size(206, 25);
            this.txtBoxNombreProd.TabIndex = 1;
            // 
            // grpDatosStock
            // 
            this.grpDatosStock.Controls.Add(this.lblContIdProd);
            this.grpDatosStock.Controls.Add(this.lblIdProd);
            this.grpDatosStock.Controls.Add(this.lblContStock);
            this.grpDatosStock.Controls.Add(this.lblPrecio);
            this.grpDatosStock.Controls.Add(this.lblStock);
            this.grpDatosStock.Controls.Add(this.lblContPrecio);
            this.grpDatosStock.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosStock.Location = new System.Drawing.Point(52, 130);
            this.grpDatosStock.Name = "grpDatosStock";
            this.grpDatosStock.Size = new System.Drawing.Size(385, 172);
            this.grpDatosStock.TabIndex = 74;
            this.grpDatosStock.TabStop = false;
            this.grpDatosStock.Text = "Datos de Producto";
            // 
            // lblContIdProd
            // 
            this.lblContIdProd.BackColor = System.Drawing.Color.DarkGray;
            this.lblContIdProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContIdProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContIdProd.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContIdProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContIdProd.Location = new System.Drawing.Point(129, 33);
            this.lblContIdProd.Name = "lblContIdProd";
            this.lblContIdProd.Size = new System.Drawing.Size(230, 25);
            this.lblContIdProd.TabIndex = 80;
            this.lblContIdProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdProd
            // 
            this.lblIdProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProd.Location = new System.Drawing.Point(6, 33);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(105, 25);
            this.lblIdProd.TabIndex = 79;
            this.lblIdProd.Text = "ID Producto";
            this.lblIdProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContStock
            // 
            this.lblContStock.BackColor = System.Drawing.Color.DarkGray;
            this.lblContStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContStock.Location = new System.Drawing.Point(129, 125);
            this.lblContStock.Name = "lblContStock";
            this.lblContStock.Size = new System.Drawing.Size(230, 25);
            this.lblContStock.TabIndex = 78;
            this.lblContStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(6, 78);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(105, 25);
            this.lblPrecio.TabIndex = 75;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(6, 125);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(105, 25);
            this.lblStock.TabIndex = 77;
            this.lblStock.Text = "Stock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContPrecio
            // 
            this.lblContPrecio.BackColor = System.Drawing.Color.DarkGray;
            this.lblContPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContPrecio.Location = new System.Drawing.Point(129, 78);
            this.lblContPrecio.Name = "lblContPrecio";
            this.lblContPrecio.Size = new System.Drawing.Size(230, 25);
            this.lblContPrecio.TabIndex = 76;
            this.lblContPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpVenta
            // 
            this.grpVenta.Controls.Add(this.label2);
            this.grpVenta.Controls.Add(this.lblStockFinal);
            this.grpVenta.Controls.Add(this.label1);
            this.grpVenta.Controls.Add(this.lblPrecioFinal);
            this.grpVenta.Controls.Add(this.btnAgregarAlCarrito);
            this.grpVenta.Controls.Add(this.txtBoxCantidad);
            this.grpVenta.Controls.Add(this.lblCantidad);
            this.grpVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVenta.Location = new System.Drawing.Point(52, 321);
            this.grpVenta.Name = "grpVenta";
            this.grpVenta.Size = new System.Drawing.Size(385, 233);
            this.grpVenta.TabIndex = 81;
            this.grpVenta.TabStop = false;
            this.grpVenta.Text = "Seleccionar Cantidad";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxCantidad.Enabled = false;
            this.txtBoxCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCantidad.Location = new System.Drawing.Point(129, 34);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(230, 25);
            this.txtBoxCantidad.TabIndex = 44;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(6, 33);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(105, 25);
            this.lblCantidad.TabIndex = 43;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(843, 90);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(133, 34);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(587, 61);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(196, 21);
            this.lblCliente.TabIndex = 82;
            this.lblCliente.Text = "Ingrese el DNI del Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(611, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 25);
            this.textBox1.TabIndex = 3;
            // 
            // btnAgregarAlCarrito
            // 
            this.btnAgregarAlCarrito.BackColor = System.Drawing.Color.Peru;
            this.btnAgregarAlCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAlCarrito.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlCarrito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAgregarAlCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregarAlCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlCarrito.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlCarrito.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarAlCarrito.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAgregarAlCarrito.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarAlCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarAlCarrito.IconSize = 30;
            this.btnAgregarAlCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAlCarrito.Location = new System.Drawing.Point(200, 172);
            this.btnAgregarAlCarrito.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            this.btnAgregarAlCarrito.Size = new System.Drawing.Size(159, 34);
            this.btnAgregarAlCarrito.TabIndex = 86;
            this.btnAgregarAlCarrito.Text = "Agregar al Carrito";
            this.btnAgregarAlCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarAlCarrito.UseVisualStyleBackColor = false;
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFinal.Location = new System.Drawing.Point(6, 77);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(105, 25);
            this.lblPrecioFinal.TabIndex = 87;
            this.lblPrecioFinal.Text = "Precio Final";
            this.lblPrecioFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(129, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 81;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(129, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 88;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStockFinal
            // 
            this.lblStockFinal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblStockFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockFinal.Location = new System.Drawing.Point(6, 121);
            this.lblStockFinal.Name = "lblStockFinal";
            this.lblStockFinal.Size = new System.Drawing.Size(105, 25);
            this.lblStockFinal.TabIndex = 89;
            this.lblStockFinal.Text = "Stock Final";
            this.lblStockFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCarrito
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCarrito.ColumnHeadersHeight = 25;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoria,
            this.Nombre,
            this.cantidad,
            this.precioUnitario,
            this.precioFinal});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCarrito.EnableHeadersVisualStyles = false;
            this.dgvCarrito.Location = new System.Drawing.Point(498, 308);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(478, 176);
            this.dgvCarrito.TabIndex = 85;
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.lblContNombreApellido);
            this.grpCliente.Controls.Add(this.lblNombreApellido);
            this.grpCliente.Controls.Add(this.lblContClienteTelefono);
            this.grpCliente.Controls.Add(this.lblClienteDireccion);
            this.grpCliente.Controls.Add(this.lblClienteTelefono);
            this.grpCliente.Controls.Add(this.lblContClienteDireccion);
            this.grpCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCliente.Location = new System.Drawing.Point(591, 130);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(385, 172);
            this.grpCliente.TabIndex = 81;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Datos del Cliente";
            // 
            // lblContNombreApellido
            // 
            this.lblContNombreApellido.BackColor = System.Drawing.Color.DarkGray;
            this.lblContNombreApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContNombreApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContNombreApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContNombreApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContNombreApellido.Location = new System.Drawing.Point(129, 33);
            this.lblContNombreApellido.Name = "lblContNombreApellido";
            this.lblContNombreApellido.Size = new System.Drawing.Size(230, 25);
            this.lblContNombreApellido.TabIndex = 80;
            this.lblContNombreApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.Location = new System.Drawing.Point(6, 24);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(117, 45);
            this.lblNombreApellido.TabIndex = 79;
            this.lblNombreApellido.Text = "Nombre y Apellido";
            this.lblNombreApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContClienteTelefono
            // 
            this.lblContClienteTelefono.BackColor = System.Drawing.Color.DarkGray;
            this.lblContClienteTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContClienteTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContClienteTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContClienteTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContClienteTelefono.Location = new System.Drawing.Point(129, 125);
            this.lblContClienteTelefono.Name = "lblContClienteTelefono";
            this.lblContClienteTelefono.Size = new System.Drawing.Size(230, 25);
            this.lblContClienteTelefono.TabIndex = 78;
            this.lblContClienteTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClienteDireccion
            // 
            this.lblClienteDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblClienteDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteDireccion.Location = new System.Drawing.Point(6, 78);
            this.lblClienteDireccion.Name = "lblClienteDireccion";
            this.lblClienteDireccion.Size = new System.Drawing.Size(105, 25);
            this.lblClienteDireccion.TabIndex = 75;
            this.lblClienteDireccion.Text = "Direccion";
            this.lblClienteDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClienteTelefono
            // 
            this.lblClienteTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblClienteTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteTelefono.Location = new System.Drawing.Point(6, 125);
            this.lblClienteTelefono.Name = "lblClienteTelefono";
            this.lblClienteTelefono.Size = new System.Drawing.Size(105, 25);
            this.lblClienteTelefono.TabIndex = 77;
            this.lblClienteTelefono.Text = "Telefono";
            this.lblClienteTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContClienteDireccion
            // 
            this.lblContClienteDireccion.BackColor = System.Drawing.Color.DarkGray;
            this.lblContClienteDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContClienteDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContClienteDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContClienteDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContClienteDireccion.Location = new System.Drawing.Point(129, 78);
            this.lblContClienteDireccion.Name = "lblContClienteDireccion";
            this.lblContClienteDireccion.Size = new System.Drawing.Size(230, 25);
            this.lblContClienteDireccion.TabIndex = 76;
            this.lblContClienteDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.FillWeight = 72.75491F;
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.categoria.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.FillWeight = 126.0259F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Nombre.Width = 113;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.FillWeight = 68.26125F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cantidad.Width = 65;
            // 
            // precioUnitario
            // 
            this.precioUnitario.DataPropertyName = "precioUnitario";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.precioUnitario.DefaultCellStyle = dataGridViewCellStyle3;
            this.precioUnitario.FillWeight = 108.684F;
            this.precioUnitario.HeaderText = "Precio Unitario";
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            this.precioUnitario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.precioUnitario.Width = 110;
            // 
            // precioFinal
            // 
            this.precioFinal.DataPropertyName = "precioFinal";
            this.precioFinal.FillWeight = 113.4107F;
            this.precioFinal.HeaderText = "Precio Final";
            this.precioFinal.Name = "precioFinal";
            this.precioFinal.ReadOnly = true;
            this.precioFinal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.precioFinal.Width = 98;
            // 
            // btnEliminarDelCarrito
            // 
            this.btnEliminarDelCarrito.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarDelCarrito.IconChar = FontAwesome.Sharp.IconChar.SquareXmark;
            this.btnEliminarDelCarrito.IconColor = System.Drawing.Color.DarkRed;
            this.btnEliminarDelCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarDelCarrito.Location = new System.Drawing.Point(453, 443);
            this.btnEliminarDelCarrito.Name = "btnEliminarDelCarrito";
            this.btnEliminarDelCarrito.Size = new System.Drawing.Size(39, 41);
            this.btnEliminarDelCarrito.TabIndex = 86;
            this.btnEliminarDelCarrito.UseVisualStyleBackColor = false;
            this.btnEliminarDelCarrito.Click += new System.EventHandler(this.btnEliminarDelCarrito_Click);
            // 
            // btnCancelarOperacion
            // 
            this.btnCancelarOperacion.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarOperacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarOperacion.FlatAppearance.BorderSize = 0;
            this.btnCancelarOperacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCancelarOperacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCancelarOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarOperacion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarOperacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelarOperacion.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnCancelarOperacion.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelarOperacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarOperacion.IconSize = 30;
            this.btnCancelarOperacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarOperacion.Location = new System.Drawing.Point(549, 513);
            this.btnCancelarOperacion.Name = "btnCancelarOperacion";
            this.btnCancelarOperacion.Size = new System.Drawing.Size(195, 41);
            this.btnCancelarOperacion.TabIndex = 87;
            this.btnCancelarOperacion.Text = "Cancelar Operacion";
            this.btnCancelarOperacion.UseVisualStyleBackColor = false;
            this.btnCancelarOperacion.Click += new System.EventHandler(this.btnCancelarOperacion_Click);
            // 
            // frmVendNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.btnCancelarOperacion);
            this.Controls.Add(this.btnEliminarDelCarrito);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpVenta);
            this.Controls.Add(this.grpDatosStock);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblInfoDatosProd);
            this.Controls.Add(this.txtBoxNombreProd);
            this.Controls.Add(this.panelAdmUsersAlta);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.btnCargarVenta);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVendNuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaVenta";
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.grpDatosStock.ResumeLayout(false);
            this.grpVenta.ResumeLayout(false);
            this.grpVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.grpCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnCargarVenta;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label lblTop;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label lblInfoDatosProd;
        private System.Windows.Forms.TextBox txtBoxNombreProd;
        private System.Windows.Forms.GroupBox grpDatosStock;
        private System.Windows.Forms.Label lblContIdProd;
        private System.Windows.Forms.Label lblIdProd;
        private System.Windows.Forms.Label lblContStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblContPrecio;
        private System.Windows.Forms.GroupBox grpVenta;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnAgregarAlCarrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStockFinal;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Label lblContNombreApellido;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblContClienteTelefono;
        private System.Windows.Forms.Label lblClienteDireccion;
        private System.Windows.Forms.Label lblClienteTelefono;
        private System.Windows.Forms.Label lblContClienteDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioFinal;
        private FontAwesome.Sharp.IconButton btnEliminarDelCarrito;
        private FontAwesome.Sharp.IconButton btnCancelarOperacion;
    }
}