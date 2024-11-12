namespace Presentacion
{
    partial class frmAdmUsuariosModif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmUsuariosModif));
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblInfoDatosUser = new System.Windows.Forms.Label();
            this.btnModificarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.grpDatosModif = new System.Windows.Forms.GroupBox();
            this.txtBoxConfrimNuevaContra = new System.Windows.Forms.TextBox();
            this.txtBoxNuevaContra = new System.Windows.Forms.TextBox();
            this.txtBoxContraActual = new System.Windows.Forms.TextBox();
            this.lblConfirmaContra = new System.Windows.Forms.Label();
            this.lblContraActual = new System.Windows.Forms.Label();
            this.lblNuevaContra = new System.Windows.Forms.Label();
            this.grpDatosUser = new System.Windows.Forms.GroupBox();
            this.txtBoxHost = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtBoxUserId = new System.Windows.Forms.TextBox();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.txtBoxDni = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.panelAdmUsersAlta.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.grpDatosModif.SuspendLayout();
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
            this.lblTop.Size = new System.Drawing.Size(473, 39);
            this.lblTop.TabIndex = 7;
            this.lblTop.Text = "Panel de Usuarios - Modificar Contraseña Usuario";
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
            this.lblInfoDatosUser.Size = new System.Drawing.Size(228, 21);
            this.lblInfoDatosUser.TabIndex = 22;
            this.lblInfoDatosUser.Text = "Ingrese el Usuario a Modificar";
            this.lblInfoDatosUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.Color.Orange;
            this.btnModificarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarUsuario.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.btnModificarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnModificarUsuario.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btnModificarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnModificarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarUsuario.IconSize = 30;
            this.btnModificarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUsuario.Location = new System.Drawing.Point(756, 455);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(195, 41);
            this.btnModificarUsuario.TabIndex = 29;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarUsuario_click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContenedor.Controls.Add(this.grpDatosModif);
            this.panelContenedor.Controls.Add(this.grpDatosUser);
            this.panelContenedor.Controls.Add(this.btnBuscar);
            this.panelContenedor.Controls.Add(this.btnVolver);
            this.panelContenedor.Controls.Add(this.btnModificarUsuario);
            this.panelContenedor.Controls.Add(this.lblInfoDatosUser);
            this.panelContenedor.Controls.Add(this.txtBoxUsuario);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(18, 56);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(976, 510);
            this.panelContenedor.TabIndex = 33;
            // 
            // grpDatosModif
            // 
            this.grpDatosModif.Controls.Add(this.txtBoxConfrimNuevaContra);
            this.grpDatosModif.Controls.Add(this.txtBoxNuevaContra);
            this.grpDatosModif.Controls.Add(this.txtBoxContraActual);
            this.grpDatosModif.Controls.Add(this.lblConfirmaContra);
            this.grpDatosModif.Controls.Add(this.lblContraActual);
            this.grpDatosModif.Controls.Add(this.lblNuevaContra);
            this.grpDatosModif.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosModif.Location = new System.Drawing.Point(524, 111);
            this.grpDatosModif.Name = "grpDatosModif";
            this.grpDatosModif.Size = new System.Drawing.Size(427, 208);
            this.grpDatosModif.TabIndex = 60;
            this.grpDatosModif.TabStop = false;
            this.grpDatosModif.Text = "Modificar Contraseña de Usuario";
            // 
            // txtBoxConfrimNuevaContra
            // 
            this.txtBoxConfrimNuevaContra.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxConfrimNuevaContra.Enabled = false;
            this.txtBoxConfrimNuevaContra.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfrimNuevaContra.Location = new System.Drawing.Point(171, 134);
            this.txtBoxConfrimNuevaContra.Name = "txtBoxConfrimNuevaContra";
            this.txtBoxConfrimNuevaContra.Size = new System.Drawing.Size(230, 25);
            this.txtBoxConfrimNuevaContra.TabIndex = 43;
            // 
            // txtBoxNuevaContra
            // 
            this.txtBoxNuevaContra.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxNuevaContra.Enabled = false;
            this.txtBoxNuevaContra.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNuevaContra.Location = new System.Drawing.Point(171, 85);
            this.txtBoxNuevaContra.Name = "txtBoxNuevaContra";
            this.txtBoxNuevaContra.Size = new System.Drawing.Size(230, 25);
            this.txtBoxNuevaContra.TabIndex = 42;
            // 
            // txtBoxContraActual
            // 
            this.txtBoxContraActual.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxContraActual.Enabled = false;
            this.txtBoxContraActual.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContraActual.Location = new System.Drawing.Point(171, 38);
            this.txtBoxContraActual.Name = "txtBoxContraActual";
            this.txtBoxContraActual.Size = new System.Drawing.Size(230, 25);
            this.txtBoxContraActual.TabIndex = 2;
            // 
            // lblConfirmaContra
            // 
            this.lblConfirmaContra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblConfirmaContra.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaContra.Location = new System.Drawing.Point(7, 134);
            this.lblConfirmaContra.Name = "lblConfirmaContra";
            this.lblConfirmaContra.Size = new System.Drawing.Size(142, 25);
            this.lblConfirmaContra.TabIndex = 38;
            this.lblConfirmaContra.Text = "Repita Contraseña";
            this.lblConfirmaContra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContraActual
            // 
            this.lblContraActual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblContraActual.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraActual.Location = new System.Drawing.Point(7, 38);
            this.lblContraActual.Name = "lblContraActual";
            this.lblContraActual.Size = new System.Drawing.Size(142, 25);
            this.lblContraActual.TabIndex = 9;
            this.lblContraActual.Text = "Contraseña Actual";
            this.lblContraActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNuevaContra
            // 
            this.lblNuevaContra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNuevaContra.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContra.Location = new System.Drawing.Point(7, 85);
            this.lblNuevaContra.Name = "lblNuevaContra";
            this.lblNuevaContra.Size = new System.Drawing.Size(142, 25);
            this.lblNuevaContra.TabIndex = 12;
            this.lblNuevaContra.Text = "Nueva Contraseña";
            this.lblNuevaContra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpDatosUser
            // 
            this.grpDatosUser.Controls.Add(this.txtBoxHost);
            this.grpDatosUser.Controls.Add(this.lblPerfil);
            this.grpDatosUser.Controls.Add(this.txtBoxUserId);
            this.grpDatosUser.Controls.Add(this.lblIdUser);
            this.grpDatosUser.Controls.Add(this.txtBoxDni);
            this.grpDatosUser.Controls.Add(this.txtBoxApellido);
            this.grpDatosUser.Controls.Add(this.txtBoxNombre);
            this.grpDatosUser.Controls.Add(this.lblDni);
            this.grpDatosUser.Controls.Add(this.lblNombre);
            this.grpDatosUser.Controls.Add(this.lblApellido);
            this.grpDatosUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosUser.Location = new System.Drawing.Point(27, 111);
            this.grpDatosUser.Name = "grpDatosUser";
            this.grpDatosUser.Size = new System.Drawing.Size(385, 318);
            this.grpDatosUser.TabIndex = 35;
            this.grpDatosUser.TabStop = false;
            this.grpDatosUser.Text = "Informacion de Usuario";
            // 
            // txtBoxHost
            // 
            this.txtBoxHost.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxHost.Enabled = false;
            this.txtBoxHost.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHost.Location = new System.Drawing.Point(130, 236);
            this.txtBoxHost.Name = "txtBoxHost";
            this.txtBoxHost.Size = new System.Drawing.Size(230, 25);
            this.txtBoxHost.TabIndex = 59;
            // 
            // lblPerfil
            // 
            this.lblPerfil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(7, 236);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(105, 25);
            this.lblPerfil.TabIndex = 58;
            this.lblPerfil.Text = "Perfil";
            this.lblPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxUserId
            // 
            this.txtBoxUserId.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxUserId.Enabled = false;
            this.txtBoxUserId.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserId.Location = new System.Drawing.Point(131, 185);
            this.txtBoxUserId.Name = "txtBoxUserId";
            this.txtBoxUserId.Size = new System.Drawing.Size(230, 22);
            this.txtBoxUserId.TabIndex = 57;
            // 
            // lblIdUser
            // 
            this.lblIdUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUser.Location = new System.Drawing.Point(7, 182);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(105, 25);
            this.lblIdUser.TabIndex = 56;
            this.lblIdUser.Text = "ID Usuario";
            this.lblIdUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxDni
            // 
            this.txtBoxDni.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxDni.Enabled = false;
            this.txtBoxDni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDni.Location = new System.Drawing.Point(130, 134);
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
            // lblDni
            // 
            this.lblDni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(7, 133);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(105, 25);
            this.lblDni.TabIndex = 38;
            this.lblDni.Text = "DNI";
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAdmUsuariosModif
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
            this.Name = "frmAdmUsuariosModif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmUsuariosModif";
            this.Load += new System.EventHandler(this.frmAdmUsuariosModif_Load);
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.grpDatosModif.ResumeLayout(false);
            this.grpDatosModif.PerformLayout();
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
        private FontAwesome.Sharp.IconButton btnModificarUsuario;
        private FontAwesome.Sharp.IconButton btnVolver;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.GroupBox grpDatosUser;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtBoxDni;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.GroupBox grpDatosModif;
        private System.Windows.Forms.TextBox txtBoxConfrimNuevaContra;
        private System.Windows.Forms.TextBox txtBoxNuevaContra;
        private System.Windows.Forms.TextBox txtBoxContraActual;
        private System.Windows.Forms.Label lblConfirmaContra;
        private System.Windows.Forms.Label lblContraActual;
        private System.Windows.Forms.Label lblNuevaContra;
        private System.Windows.Forms.TextBox txtBoxHost;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtBoxUserId;
        private System.Windows.Forms.Label lblIdUser;
    }
}