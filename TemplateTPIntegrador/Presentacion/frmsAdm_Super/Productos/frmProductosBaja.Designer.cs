namespace Presentacion
{
    partial class frmProductosBaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductosBaja));
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.txtBoxNombreProd = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblInfoDatosVend = new System.Windows.Forms.Label();
            this.btnEliminarProd = new FontAwesome.Sharp.IconButton();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.lblContIdProv = new System.Windows.Forms.Label();
            this.lblIdProv = new System.Windows.Forms.Label();
            this.lblContIdProd = new System.Windows.Forms.Label();
            this.lblContStock = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblIdProd = new System.Windows.Forms.Label();
            this.lblContFechaAlta = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblContPrecio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblContHost = new System.Windows.Forms.Label();
            this.lblProvee = new System.Windows.Forms.Label();
            this.lblContEstado = new System.Windows.Forms.Label();
            this.lblContNombre = new System.Windows.Forms.Label();
            this.lblContCategoria = new System.Windows.Forms.Label();
            this.panelAdmUsersAlta.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.grpProducto.SuspendLayout();
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
            this.lblTop.Text = "Panel de Productos - Eliminar Productos";
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
            // txtBoxNombreProd
            // 
            this.txtBoxNombreProd.Location = new System.Drawing.Point(47, 68);
            this.txtBoxNombreProd.Name = "txtBoxNombreProd";
            this.txtBoxNombreProd.Size = new System.Drawing.Size(206, 25);
            this.txtBoxNombreProd.TabIndex = 24;
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(6, 94);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(105, 25);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 141);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(105, 25);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(553, 188);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(105, 25);
            this.lblEstado.TabIndex = 32;
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoDatosVend
            // 
            this.lblInfoDatosVend.AutoSize = true;
            this.lblInfoDatosVend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoDatosVend.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDatosVend.Location = new System.Drawing.Point(23, 33);
            this.lblInfoDatosVend.Name = "lblInfoDatosVend";
            this.lblInfoDatosVend.Size = new System.Drawing.Size(343, 21);
            this.lblInfoDatosVend.TabIndex = 22;
            this.lblInfoDatosVend.Text = "Ingrese el Nombre del Producto a dar de Baja";
            this.lblInfoDatosVend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProd.FlatAppearance.BorderSize = 0;
            this.btnEliminarProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnEliminarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarProd.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarProd.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarProd.IconSize = 30;
            this.btnEliminarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProd.Location = new System.Drawing.Point(737, 455);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(195, 41);
            this.btnEliminarProd.TabIndex = 29;
            this.btnEliminarProd.Text = "Eliminar Producto";
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            //this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
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
            this.btnVolver.Location = new System.Drawing.Point(26, 455);
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContenedor.Controls.Add(this.grpProducto);
            this.panelContenedor.Controls.Add(this.btnBuscar);
            this.panelContenedor.Controls.Add(this.btnVolver);
            this.panelContenedor.Controls.Add(this.btnEliminarProd);
            this.panelContenedor.Controls.Add(this.lblInfoDatosVend);
            this.panelContenedor.Controls.Add(this.txtBoxNombreProd);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(18, 56);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(976, 510);
            this.panelContenedor.TabIndex = 33;
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.lblContIdProv);
            this.grpProducto.Controls.Add(this.lblIdProv);
            this.grpProducto.Controls.Add(this.lblContIdProd);
            this.grpProducto.Controls.Add(this.lblContStock);
            this.grpProducto.Controls.Add(this.lblStock);
            this.grpProducto.Controls.Add(this.lblIdProd);
            this.grpProducto.Controls.Add(this.lblContFechaAlta);
            this.grpProducto.Controls.Add(this.lblFechaAlta);
            this.grpProducto.Controls.Add(this.lblContPrecio);
            this.grpProducto.Controls.Add(this.lblPrecio);
            this.grpProducto.Controls.Add(this.lblContHost);
            this.grpProducto.Controls.Add(this.lblProvee);
            this.grpProducto.Controls.Add(this.lblContEstado);
            this.grpProducto.Controls.Add(this.lblContNombre);
            this.grpProducto.Controls.Add(this.lblContCategoria);
            this.grpProducto.Controls.Add(this.lblCategoria);
            this.grpProducto.Controls.Add(this.lblNombre);
            this.grpProducto.Controls.Add(this.lblEstado);
            this.grpProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProducto.Location = new System.Drawing.Point(27, 131);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(920, 293);
            this.grpProducto.TabIndex = 35;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Datos de Producto";
            // 
            // lblContIdProv
            // 
            this.lblContIdProv.BackColor = System.Drawing.Color.DarkGray;
            this.lblContIdProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContIdProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContIdProv.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContIdProv.Location = new System.Drawing.Point(675, 47);
            this.lblContIdProv.Name = "lblContIdProv";
            this.lblContIdProv.Size = new System.Drawing.Size(230, 25);
            this.lblContIdProv.TabIndex = 47;
            this.lblContIdProv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdProv
            // 
            this.lblIdProv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdProv.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProv.Location = new System.Drawing.Point(553, 47);
            this.lblIdProv.Name = "lblIdProv";
            this.lblIdProv.Size = new System.Drawing.Size(105, 25);
            this.lblIdProv.TabIndex = 46;
            this.lblIdProv.Text = "ID Proveedor";
            this.lblIdProv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContIdProd
            // 
            this.lblContIdProd.BackColor = System.Drawing.Color.DarkGray;
            this.lblContIdProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContIdProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContIdProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContIdProd.Location = new System.Drawing.Point(129, 47);
            this.lblContIdProd.Name = "lblContIdProd";
            this.lblContIdProd.Size = new System.Drawing.Size(230, 25);
            this.lblContIdProd.TabIndex = 45;
            this.lblContIdProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContStock
            // 
            this.lblContStock.BackColor = System.Drawing.Color.DarkGray;
            this.lblContStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContStock.Location = new System.Drawing.Point(129, 235);
            this.lblContStock.Name = "lblContStock";
            this.lblContStock.Size = new System.Drawing.Size(230, 25);
            this.lblContStock.TabIndex = 43;
            this.lblContStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(6, 235);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(105, 25);
            this.lblStock.TabIndex = 42;
            this.lblStock.Text = "Stock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdProd
            // 
            this.lblIdProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProd.Location = new System.Drawing.Point(6, 47);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(105, 25);
            this.lblIdProd.TabIndex = 44;
            this.lblIdProd.Text = "ID Producto";
            this.lblIdProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContFechaAlta
            // 
            this.lblContFechaAlta.BackColor = System.Drawing.Color.DarkGray;
            this.lblContFechaAlta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContFechaAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContFechaAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContFechaAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblContFechaAlta.Location = new System.Drawing.Point(676, 141);
            this.lblContFechaAlta.Name = "lblContFechaAlta";
            this.lblContFechaAlta.Size = new System.Drawing.Size(230, 25);
            this.lblContFechaAlta.TabIndex = 41;
            this.lblContFechaAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.Location = new System.Drawing.Point(553, 141);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(105, 25);
            this.lblFechaAlta.TabIndex = 40;
            this.lblFechaAlta.Text = "Fecha de Alta";
            this.lblFechaAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lblContHost
            // 
            this.lblContHost.BackColor = System.Drawing.Color.DarkGray;
            this.lblContHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContHost.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContHost.Location = new System.Drawing.Point(675, 94);
            this.lblContHost.Name = "lblContHost";
            this.lblContHost.Size = new System.Drawing.Size(230, 25);
            this.lblContHost.TabIndex = 37;
            this.lblContHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProvee
            // 
            this.lblProvee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblProvee.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvee.Location = new System.Drawing.Point(553, 94);
            this.lblProvee.Name = "lblProvee";
            this.lblProvee.Size = new System.Drawing.Size(105, 25);
            this.lblProvee.TabIndex = 36;
            this.lblProvee.Text = "Proveedor";
            this.lblProvee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContEstado
            // 
            this.lblContEstado.BackColor = System.Drawing.Color.DarkGray;
            this.lblContEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContEstado.Location = new System.Drawing.Point(676, 188);
            this.lblContEstado.Name = "lblContEstado";
            this.lblContEstado.Size = new System.Drawing.Size(230, 25);
            this.lblContEstado.TabIndex = 35;
            this.lblContEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContNombre
            // 
            this.lblContNombre.BackColor = System.Drawing.Color.DarkGray;
            this.lblContNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContNombre.Location = new System.Drawing.Point(129, 141);
            this.lblContNombre.Name = "lblContNombre";
            this.lblContNombre.Size = new System.Drawing.Size(230, 25);
            this.lblContNombre.TabIndex = 34;
            this.lblContNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContCategoria
            // 
            this.lblContCategoria.BackColor = System.Drawing.Color.DarkGray;
            this.lblContCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContCategoria.Location = new System.Drawing.Point(129, 94);
            this.lblContCategoria.Name = "lblContCategoria";
            this.lblContCategoria.Size = new System.Drawing.Size(230, 25);
            this.lblContCategoria.TabIndex = 33;
            this.lblContCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmProductosBaja
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
            this.Name = "frmProductosBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmUsuariosAlta";
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.grpProducto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.TextBox txtBoxNombreProd;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblInfoDatosVend;
        private FontAwesome.Sharp.IconButton btnEliminarProd;
        private FontAwesome.Sharp.IconButton btnVolver;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.Label lblContEstado;
        private System.Windows.Forms.Label lblContNombre;
        private System.Windows.Forms.Label lblContCategoria;
        private System.Windows.Forms.Label lblContFechaAlta;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblContPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblContHost;
        private System.Windows.Forms.Label lblProvee;
        private System.Windows.Forms.Label lblContStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblContIdProv;
        private System.Windows.Forms.Label lblIdProv;
        private System.Windows.Forms.Label lblContIdProd;
        private System.Windows.Forms.Label lblIdProd;
    }
}