namespace Presentacion
{
    partial class frmAdmProveedoresModif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmProveedoresModif));
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblInfoDatosUser = new System.Windows.Forms.Label();
            this.btnModificarProvee = new FontAwesome.Sharp.IconButton();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.grpDatosUser = new System.Windows.Forms.GroupBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxDni = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.panelAdmUsersAlta.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.grpDatosUser.SuspendLayout();
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
            this.lblTop.Text = "Panel de Proveedores - Modificar Proveedores";
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
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(47, 68);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(206, 25);
            this.txtBoxUsuario.TabIndex = 24;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(105, 25);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(7, 85);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(105, 25);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoDatosUser
            // 
            this.lblInfoDatosUser.AutoSize = true;
            this.lblInfoDatosUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoDatosUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDatosUser.Location = new System.Drawing.Point(23, 33);
            this.lblInfoDatosUser.Name = "lblInfoDatosUser";
            this.lblInfoDatosUser.Size = new System.Drawing.Size(336, 21);
            this.lblInfoDatosUser.TabIndex = 22;
            this.lblInfoDatosUser.Text = "Ingrese el Usuario del Proveedor a Modificar";
            this.lblInfoDatosUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnModificarProvee
            // 
            this.btnModificarProvee.BackColor = System.Drawing.Color.Orange;
            this.btnModificarProvee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProvee.FlatAppearance.BorderSize = 0;
            this.btnModificarProvee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.btnModificarProvee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btnModificarProvee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProvee.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProvee.ForeColor = System.Drawing.Color.Black;
            this.btnModificarProvee.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btnModificarProvee.IconColor = System.Drawing.Color.Black;
            this.btnModificarProvee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarProvee.IconSize = 30;
            this.btnModificarProvee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProvee.Location = new System.Drawing.Point(728, 455);
            this.btnModificarProvee.Name = "btnModificarProvee";
            this.btnModificarProvee.Size = new System.Drawing.Size(195, 41);
            this.btnModificarProvee.TabIndex = 29;
            this.btnModificarProvee.Text = "Modificar Proveedor";
            this.btnModificarProvee.UseVisualStyleBackColor = false;
            this.btnModificarProvee.Click += new System.EventHandler(this.btnModificarProveedor_Click);
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarProveedor_click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContenedor.Controls.Add(this.grpDatosUser);
            this.panelContenedor.Controls.Add(this.btnBuscar);
            this.panelContenedor.Controls.Add(this.btnVolver);
            this.panelContenedor.Controls.Add(this.btnModificarProvee);
            this.panelContenedor.Controls.Add(this.lblInfoDatosUser);
            this.panelContenedor.Controls.Add(this.txtBoxUsuario);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(18, 56);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(976, 510);
            this.panelContenedor.TabIndex = 33;
            // 
            // grpDatosUser
            // 
            this.grpDatosUser.Controls.Add(this.rbInactivo);
            this.grpDatosUser.Controls.Add(this.rbActivo);
            this.grpDatosUser.Controls.Add(this.lblEstado);
            this.grpDatosUser.Controls.Add(this.txtBoxEmail);
            this.grpDatosUser.Controls.Add(this.lblEmail);
            this.grpDatosUser.Controls.Add(this.txtBoxDni);
            this.grpDatosUser.Controls.Add(this.txtBoxApellido);
            this.grpDatosUser.Controls.Add(this.txtBoxNombre);
            this.grpDatosUser.Controls.Add(this.lblCuit);
            this.grpDatosUser.Controls.Add(this.lblNombre);
            this.grpDatosUser.Controls.Add(this.lblApellido);
            this.grpDatosUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosUser.Location = new System.Drawing.Point(528, 33);
            this.grpDatosUser.Name = "grpDatosUser";
            this.grpDatosUser.Size = new System.Drawing.Size(395, 293);
            this.grpDatosUser.TabIndex = 35;
            this.grpDatosUser.TabStop = false;
            this.grpDatosUser.Text = "Datos de Usuario";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxEmail.Enabled = false;
            this.txtBoxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(130, 134);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(230, 25);
            this.txtBoxEmail.TabIndex = 52;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(7, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(105, 25);
            this.lblEmail.TabIndex = 51;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxDni
            // 
            this.txtBoxDni.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxDni.Enabled = false;
            this.txtBoxDni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDni.Location = new System.Drawing.Point(130, 182);
            this.txtBoxDni.Name = "txtBoxDni";
            this.txtBoxDni.Size = new System.Drawing.Size(230, 25);
            this.txtBoxDni.TabIndex = 43;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxApellido.Enabled = false;
            this.txtBoxApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxApellido.Location = new System.Drawing.Point(131, 86);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(230, 25);
            this.txtBoxApellido.TabIndex = 42;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxNombre.Enabled = false;
            this.txtBoxNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombre.Location = new System.Drawing.Point(130, 38);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(230, 25);
            this.txtBoxNombre.TabIndex = 2;
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.txtBoxNombre_TextChanged);
            // 
            // lblCuit
            // 
            this.lblCuit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCuit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.Location = new System.Drawing.Point(7, 181);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(105, 25);
            this.lblCuit.TabIndex = 38;
            this.lblCuit.Text = "CUIT";
            this.lblCuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(7, 228);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(105, 25);
            this.lblEstado.TabIndex = 53;
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rbActivo.Enabled = false;
            this.rbActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbActivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivo.Location = new System.Drawing.Point(131, 232);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(60, 21);
            this.rbActivo.TabIndex = 55;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = false;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rbInactivo.Enabled = false;
            this.rbInactivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbInactivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbInactivo.Location = new System.Drawing.Point(291, 232);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(69, 21);
            this.rbInactivo.TabIndex = 56;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = false;
            // 
            // frmAdmProveedoresModif
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
            this.Name = "frmAdmProveedoresModif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmUsuariosAlta";
            this.Load += new System.EventHandler(this.frmAdmUsuariosModif_Load);
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.grpDatosUser.ResumeLayout(false);
            this.grpDatosUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblInfoDatosUser;
        private FontAwesome.Sharp.IconButton btnModificarProvee;
        private FontAwesome.Sharp.IconButton btnVolver;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.GroupBox grpDatosUser;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtBoxDni;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
    }
}