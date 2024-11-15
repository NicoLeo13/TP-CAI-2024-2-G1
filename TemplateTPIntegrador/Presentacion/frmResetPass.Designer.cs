namespace Presentacion
{
    partial class frmResetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetPass));
            this.labelContraseña = new System.Windows.Forms.Label();
            this.txtBoxContraseñaActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNuevaContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxReingresoNuevaContraseña = new System.Windows.Forms.TextBox();
            this.btnGuardarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(87, 31);
            this.labelContraseña.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(133, 20);
            this.labelContraseña.TabIndex = 6;
            this.labelContraseña.Text = "Contraseña Actual";
            // 
            // txtBoxContraseñaActual
            // 
            this.txtBoxContraseñaActual.Location = new System.Drawing.Point(132, 56);
            this.txtBoxContraseñaActual.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxContraseñaActual.Name = "txtBoxContraseñaActual";
            this.txtBoxContraseñaActual.PasswordChar = '*';
            this.txtBoxContraseñaActual.Size = new System.Drawing.Size(215, 25);
            this.txtBoxContraseñaActual.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nueva Contraseña";
            // 
            // txtBoxNuevaContraseña
            // 
            this.txtBoxNuevaContraseña.Location = new System.Drawing.Point(132, 137);
            this.txtBoxNuevaContraseña.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxNuevaContraseña.Name = "txtBoxNuevaContraseña";
            this.txtBoxNuevaContraseña.PasswordChar = '*';
            this.txtBoxNuevaContraseña.Size = new System.Drawing.Size(215, 25);
            this.txtBoxNuevaContraseña.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reingrese Nueva Contraseña";
            // 
            // txtBoxReingresoNuevaContraseña
            // 
            this.txtBoxReingresoNuevaContraseña.Location = new System.Drawing.Point(132, 218);
            this.txtBoxReingresoNuevaContraseña.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxReingresoNuevaContraseña.Name = "txtBoxReingresoNuevaContraseña";
            this.txtBoxReingresoNuevaContraseña.PasswordChar = '*';
            this.txtBoxReingresoNuevaContraseña.Size = new System.Drawing.Size(215, 25);
            this.txtBoxReingresoNuevaContraseña.TabIndex = 9;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarUsuario.FlatAppearance.BorderSize = 0;
            this.btnGuardarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnGuardarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarUsuario.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarUsuario.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarUsuario.IconSize = 30;
            this.btnGuardarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(132, 272);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(215, 39);
            this.btnGuardarUsuario.TabIndex = 30;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = false;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
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
            this.btnVolver.Location = new System.Drawing.Point(179, 335);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(123, 39);
            this.btnVolver.TabIndex = 32;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(462, 428);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxReingresoNuevaContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNuevaContraseña);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.txtBoxContraseñaActual);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroHogar S.A - Cambio de Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox txtBoxContraseñaActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNuevaContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxReingresoNuevaContraseña;
        private FontAwesome.Sharp.IconButton btnGuardarUsuario;
        private FontAwesome.Sharp.IconButton btnVolver;
    }
}