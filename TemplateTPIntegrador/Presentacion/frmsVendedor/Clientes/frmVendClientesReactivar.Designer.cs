namespace Presentacion
{
    partial class frmVendClientesReactivar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendClientesReactivar));
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.txtBoxCliente = new System.Windows.Forms.TextBox();
            this.lblInfoDatosCliente = new System.Windows.Forms.Label();
            this.btnReactivarCliente = new FontAwesome.Sharp.IconButton();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelAdmUsersAlta.SuspendLayout();
            this.panelContenedor.SuspendLayout();
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
            this.lblTop.Text = "Panel de Clientes - Reactivar Cliente";
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
            // txtBoxCliente
            // 
            this.txtBoxCliente.Location = new System.Drawing.Point(351, 78);
            this.txtBoxCliente.Name = "txtBoxCliente";
            this.txtBoxCliente.Size = new System.Drawing.Size(263, 25);
            this.txtBoxCliente.TabIndex = 24;
            // 
            // lblInfoDatosCliente
            // 
            this.lblInfoDatosCliente.AutoSize = true;
            this.lblInfoDatosCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoDatosCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDatosCliente.Location = new System.Drawing.Point(347, 30);
            this.lblInfoDatosCliente.Name = "lblInfoDatosCliente";
            this.lblInfoDatosCliente.Size = new System.Drawing.Size(263, 21);
            this.lblInfoDatosCliente.TabIndex = 22;
            this.lblInfoDatosCliente.Text = "Ingrese el ID de Cliente a Reactivar";
            this.lblInfoDatosCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReactivarCliente
            // 
            this.btnReactivarCliente.BackColor = System.Drawing.Color.ForestGreen;
            this.btnReactivarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReactivarCliente.FlatAppearance.BorderSize = 0;
            this.btnReactivarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnReactivarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnReactivarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReactivarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReactivarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReactivarCliente.IconChar = FontAwesome.Sharp.IconChar.CreativeCommonsSa;
            this.btnReactivarCliente.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnReactivarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReactivarCliente.IconSize = 30;
            this.btnReactivarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReactivarCliente.Location = new System.Drawing.Point(383, 145);
            this.btnReactivarCliente.Name = "btnReactivarCliente";
            this.btnReactivarCliente.Size = new System.Drawing.Size(206, 41);
            this.btnReactivarCliente.TabIndex = 29;
            this.btnReactivarCliente.Text = "Reactivar Cliente";
            this.btnReactivarCliente.UseVisualStyleBackColor = false;
            this.btnReactivarCliente.Click += new System.EventHandler(this.btnReactivarCliente_Click);
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
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContenedor.Controls.Add(this.btnVolver);
            this.panelContenedor.Controls.Add(this.btnReactivarCliente);
            this.panelContenedor.Controls.Add(this.lblInfoDatosCliente);
            this.panelContenedor.Controls.Add(this.txtBoxCliente);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(18, 56);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(976, 510);
            this.panelContenedor.TabIndex = 33;
            // 
            // frmVendClientesReactivar
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
            this.Name = "frmVendClientesReactivar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedor - Reactivar Clientes";
            this.Load += new System.EventHandler(this.frmVendClientesReactivar_Load);
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.TextBox txtBoxCliente;
        private System.Windows.Forms.Label lblInfoDatosCliente;
        private FontAwesome.Sharp.IconButton btnReactivarCliente;
        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Panel panelContenedor;
    }
}