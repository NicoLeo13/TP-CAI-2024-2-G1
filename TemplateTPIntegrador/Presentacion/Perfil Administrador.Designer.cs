namespace Presentacion
{
    partial class PerfilAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilAdministrador));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmVend = new System.Windows.Forms.Button();
            this.btnAdmProv = new System.Windows.Forms.Button();
            this.btnAdmProd = new System.Windows.Forms.Button();
            this.btnAdmRep = new System.Windows.Forms.Button();
            this.btnAdmSup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione la opcion a gestionar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdmVend
            // 
            this.btnAdmVend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmVend.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmVend.Location = new System.Drawing.Point(48, 77);
            this.btnAdmVend.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmVend.Name = "btnAdmVend";
            this.btnAdmVend.Size = new System.Drawing.Size(240, 88);
            this.btnAdmVend.TabIndex = 6;
            this.btnAdmVend.Text = "Vendedores";
            this.btnAdmVend.UseVisualStyleBackColor = true;
            this.btnAdmVend.Click += new System.EventHandler(this.btnAdmVend_Click);
            // 
            // btnAdmProv
            // 
            this.btnAdmProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmProv.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmProv.Location = new System.Drawing.Point(48, 173);
            this.btnAdmProv.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmProv.Name = "btnAdmProv";
            this.btnAdmProv.Size = new System.Drawing.Size(240, 88);
            this.btnAdmProv.TabIndex = 7;
            this.btnAdmProv.Text = "Proveedores";
            this.btnAdmProv.UseVisualStyleBackColor = true;
            this.btnAdmProv.Click += new System.EventHandler(this.btnAdmProv_Click);
            // 
            // btnAdmProd
            // 
            this.btnAdmProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmProd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmProd.Location = new System.Drawing.Point(48, 268);
            this.btnAdmProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmProd.Name = "btnAdmProd";
            this.btnAdmProd.Size = new System.Drawing.Size(240, 88);
            this.btnAdmProd.TabIndex = 8;
            this.btnAdmProd.Text = "Productos";
            this.btnAdmProd.UseVisualStyleBackColor = true;
            // 
            // btnAdmRep
            // 
            this.btnAdmRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmRep.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmRep.Location = new System.Drawing.Point(48, 364);
            this.btnAdmRep.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmRep.Name = "btnAdmRep";
            this.btnAdmRep.Size = new System.Drawing.Size(240, 88);
            this.btnAdmRep.TabIndex = 9;
            this.btnAdmRep.Text = "Reportes";
            this.btnAdmRep.UseVisualStyleBackColor = true;
            // 
            // btnAdmSup
            // 
            this.btnAdmSup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmSup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmSup.Location = new System.Drawing.Point(48, 459);
            this.btnAdmSup.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmSup.Name = "btnAdmSup";
            this.btnAdmSup.Size = new System.Drawing.Size(240, 88);
            this.btnAdmSup.TabIndex = 10;
            this.btnAdmSup.Text = "Supervisores";
            this.btnAdmSup.UseVisualStyleBackColor = true;
            this.btnAdmSup.Click += new System.EventHandler(this.btnAdmSup_Click);
            // 
            // PerfilAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 645);
            this.Controls.Add(this.btnAdmSup);
            this.Controls.Add(this.btnAdmRep);
            this.Controls.Add(this.btnAdmProd);
            this.Controls.Add(this.btnAdmProv);
            this.Controls.Add(this.btnAdmVend);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PerfilAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroHogar SA - Panel Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmVend;
        private System.Windows.Forms.Button btnAdmProv;
        private System.Windows.Forms.Button btnAdmProd;
        private System.Windows.Forms.Button btnAdmRep;
        private System.Windows.Forms.Button btnAdmSup;
    }
}