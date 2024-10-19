namespace Presentacion
{
    partial class Alta_de_Usuario
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
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.datepickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.groupBoxCreacionUsuario = new System.Windows.Forms.GroupBox();
            this.btnradioVendedor = new System.Windows.Forms.RadioButton();
            this.btnradioSupervisor = new System.Windows.Forms.RadioButton();
            this.btnradioAdministrador = new System.Windows.Forms.RadioButton();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBoxDatosPersonales.SuspendLayout();
            this.groupBoxCreacionUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.Controls.Add(this.datepickerFechaNacimiento);
            this.groupBoxDatosPersonales.Controls.Add(this.txtDni);
            this.groupBoxDatosPersonales.Controls.Add(this.lblDni);
            this.groupBoxDatosPersonales.Controls.Add(this.txtEmail);
            this.groupBoxDatosPersonales.Controls.Add(this.txtTelefono);
            this.groupBoxDatosPersonales.Controls.Add(this.txtDireccion);
            this.groupBoxDatosPersonales.Controls.Add(this.txtApellido);
            this.groupBoxDatosPersonales.Controls.Add(this.txtNombre);
            this.groupBoxDatosPersonales.Controls.Add(this.lblNombre);
            this.groupBoxDatosPersonales.Controls.Add(this.lblFechaNacimiento);
            this.groupBoxDatosPersonales.Controls.Add(this.lblApellido);
            this.groupBoxDatosPersonales.Controls.Add(this.lblEmail);
            this.groupBoxDatosPersonales.Controls.Add(this.lblDireccion);
            this.groupBoxDatosPersonales.Controls.Add(this.lblTelefono);
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(425, 242);
            this.groupBoxDatosPersonales.TabIndex = 7;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "Datos Personales";
            this.groupBoxDatosPersonales.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // datepickerFechaNacimiento
            // 
            this.datepickerFechaNacimiento.Location = new System.Drawing.Point(121, 192);
            this.datepickerFechaNacimiento.Name = "datepickerFechaNacimiento";
            this.datepickerFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.datepickerFechaNacimiento.TabIndex = 14;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(115, 159);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(253, 20);
            this.txtDni.TabIndex = 13;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(6, 165);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 12;
            this.lblDni.Text = "DNI";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(114, 107);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(253, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(114, 78);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(253, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(114, 53);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(253, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(6, 192);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 5;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 53);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 136);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 78);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 105);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono";
            // 
            // groupBoxCreacionUsuario
            // 
            this.groupBoxCreacionUsuario.Controls.Add(this.btnradioVendedor);
            this.groupBoxCreacionUsuario.Controls.Add(this.btnradioSupervisor);
            this.groupBoxCreacionUsuario.Controls.Add(this.btnradioAdministrador);
            this.groupBoxCreacionUsuario.Controls.Add(this.lblHost);
            this.groupBoxCreacionUsuario.Controls.Add(this.lblContraseña);
            this.groupBoxCreacionUsuario.Controls.Add(this.txtContraseña);
            this.groupBoxCreacionUsuario.Controls.Add(this.txtUsuario);
            this.groupBoxCreacionUsuario.Controls.Add(this.lblUsuario);
            this.groupBoxCreacionUsuario.Location = new System.Drawing.Point(12, 260);
            this.groupBoxCreacionUsuario.Name = "groupBoxCreacionUsuario";
            this.groupBoxCreacionUsuario.Size = new System.Drawing.Size(264, 187);
            this.groupBoxCreacionUsuario.TabIndex = 8;
            this.groupBoxCreacionUsuario.TabStop = false;
            this.groupBoxCreacionUsuario.Text = "Creacion de Usuario";
            // 
            // btnradioVendedor
            // 
            this.btnradioVendedor.AutoSize = true;
            this.btnradioVendedor.Location = new System.Drawing.Point(108, 155);
            this.btnradioVendedor.Name = "btnradioVendedor";
            this.btnradioVendedor.Size = new System.Drawing.Size(71, 17);
            this.btnradioVendedor.TabIndex = 17;
            this.btnradioVendedor.TabStop = true;
            this.btnradioVendedor.Text = "Vendedor";
            this.btnradioVendedor.UseVisualStyleBackColor = true;
            // 
            // btnradioSupervisor
            // 
            this.btnradioSupervisor.AutoSize = true;
            this.btnradioSupervisor.Location = new System.Drawing.Point(108, 132);
            this.btnradioSupervisor.Name = "btnradioSupervisor";
            this.btnradioSupervisor.Size = new System.Drawing.Size(75, 17);
            this.btnradioSupervisor.TabIndex = 16;
            this.btnradioSupervisor.TabStop = true;
            this.btnradioSupervisor.Text = "Supervisor";
            this.btnradioSupervisor.UseVisualStyleBackColor = true;
            // 
            // btnradioAdministrador
            // 
            this.btnradioAdministrador.AutoSize = true;
            this.btnradioAdministrador.Location = new System.Drawing.Point(108, 109);
            this.btnradioAdministrador.Name = "btnradioAdministrador";
            this.btnradioAdministrador.Size = new System.Drawing.Size(88, 17);
            this.btnradioAdministrador.TabIndex = 15;
            this.btnradioAdministrador.TabStop = true;
            this.btnradioAdministrador.Text = "Administrador";
            this.btnradioAdministrador.UseVisualStyleBackColor = true;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(9, 111);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(29, 13);
            this.lblHost.TabIndex = 14;
            this.lblHost.Text = "Host";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(9, 73);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 13;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(107, 73);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(125, 20);
            this.txtContraseña.TabIndex = 12;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(108, 34);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(125, 20);
            this.txtUsuario.TabIndex = 11;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(9, 37);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(336, 276);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(101, 38);
            this.btnCrearUsuario.TabIndex = 9;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUser_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Location = new System.Drawing.Point(336, 333);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(101, 38);
            this.btnLimpiarDatos.TabIndex = 10;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(336, 400);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(101, 38);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Alta_de_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 460);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.groupBoxCreacionUsuario);
            this.Controls.Add(this.groupBoxDatosPersonales);
            this.Name = "Alta_de_Usuario";
            this.Text = "Alta_de_Usuario";
            this.Load += new System.EventHandler(this.Alta_de_Usuario_Load);
            this.groupBoxDatosPersonales.ResumeLayout(false);
            this.groupBoxDatosPersonales.PerformLayout();
            this.groupBoxCreacionUsuario.ResumeLayout(false);
            this.groupBoxCreacionUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatosPersonales;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox groupBoxCreacionUsuario;
        private System.Windows.Forms.RadioButton btnradioVendedor;
        private System.Windows.Forms.RadioButton btnradioSupervisor;
        private System.Windows.Forms.RadioButton btnradioAdministrador;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DateTimePicker datepickerFechaNacimiento;
    }
}