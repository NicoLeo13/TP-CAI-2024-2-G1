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
            this.labelContraseña = new System.Windows.Forms.Label();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNewPass2 = new System.Windows.Forms.TextBox();
            this.btnGuardarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(28, 18);
            this.labelContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(129, 20);
            this.labelContraseña.TabIndex = 6;
            this.labelContraseña.Text = "Contraseña Actual";
            this.labelContraseña.Click += new System.EventHandler(this.labelContraseña_Click);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(71, 58);
            this.txtBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '*';
            this.txtBoxPass.Size = new System.Drawing.Size(185, 20);
            this.txtBoxPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nueva Contraseña";
            // 
            // txtBoxNewPass
            // 
            this.txtBoxNewPass.Location = new System.Drawing.Point(71, 132);
            this.txtBoxNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNewPass.Name = "txtBoxNewPass";
            this.txtBoxNewPass.PasswordChar = '*';
            this.txtBoxNewPass.Size = new System.Drawing.Size(185, 20);
            this.txtBoxNewPass.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reingrese Nueva Contraseña";
            // 
            // txtBoxNewPass2
            // 
            this.txtBoxNewPass2.Location = new System.Drawing.Point(71, 210);
            this.txtBoxNewPass2.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNewPass2.Name = "txtBoxNewPass2";
            this.txtBoxNewPass2.PasswordChar = '*';
            this.txtBoxNewPass2.Size = new System.Drawing.Size(185, 20);
            this.txtBoxNewPass2.TabIndex = 9;
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
            this.btnGuardarUsuario.Location = new System.Drawing.Point(183, 268);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(175, 40);
            this.btnGuardarUsuario.TabIndex = 30;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = false;
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
            this.btnVolver.Location = new System.Drawing.Point(45, 267);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 41);
            this.btnVolver.TabIndex = 32;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // frmResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 336);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNewPass2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNewPass);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.txtBoxPass);
            this.Name = "frmResetPass";
            this.Text = "ElectroHogar S.A - Cambio de Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNewPass2;
        private FontAwesome.Sharp.IconButton btnGuardarUsuario;
        private FontAwesome.Sharp.IconButton btnVolver;
    }
}