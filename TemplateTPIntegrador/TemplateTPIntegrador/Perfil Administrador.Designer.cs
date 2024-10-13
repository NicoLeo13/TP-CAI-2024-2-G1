namespace TemplateTPIntegrador
{
    partial class Perfil_Administrador
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmVend = new System.Windows.Forms.Button();
            this.btnAdmProv = new System.Windows.Forms.Button();
            this.btnAdmProd = new System.Windows.Forms.Button();
            this.btnAdmRep = new System.Windows.Forms.Button();
            this.btnAdmSup = new System.Windows.Forms.Button();
            this.btnAdmSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione opcion a gestionar";
            // 
            // btnAdmVend
            // 
            this.btnAdmVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmVend.Location = new System.Drawing.Point(41, 59);
            this.btnAdmVend.Name = "btnAdmVend";
            this.btnAdmVend.Size = new System.Drawing.Size(206, 67);
            this.btnAdmVend.TabIndex = 6;
            this.btnAdmVend.Text = "Vendedores";
            this.btnAdmVend.UseVisualStyleBackColor = true;
            this.btnAdmVend.Click += new System.EventHandler(this.btnAdmVend_Click);
            // 
            // btnAdmProv
            // 
            this.btnAdmProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmProv.Location = new System.Drawing.Point(41, 132);
            this.btnAdmProv.Name = "btnAdmProv";
            this.btnAdmProv.Size = new System.Drawing.Size(206, 67);
            this.btnAdmProv.TabIndex = 7;
            this.btnAdmProv.Text = "Proveedores";
            this.btnAdmProv.UseVisualStyleBackColor = true;
            this.btnAdmProv.Click += new System.EventHandler(this.btnAdmProv_Click);
            // 
            // btnAdmProd
            // 
            this.btnAdmProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmProd.Location = new System.Drawing.Point(41, 205);
            this.btnAdmProd.Name = "btnAdmProd";
            this.btnAdmProd.Size = new System.Drawing.Size(206, 67);
            this.btnAdmProd.TabIndex = 8;
            this.btnAdmProd.Text = "Productos";
            this.btnAdmProd.UseVisualStyleBackColor = true;
            // 
            // btnAdmRep
            // 
            this.btnAdmRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmRep.Location = new System.Drawing.Point(41, 278);
            this.btnAdmRep.Name = "btnAdmRep";
            this.btnAdmRep.Size = new System.Drawing.Size(206, 67);
            this.btnAdmRep.TabIndex = 9;
            this.btnAdmRep.Text = "Reportes";
            this.btnAdmRep.UseVisualStyleBackColor = true;
            // 
            // btnAdmSup
            // 
            this.btnAdmSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmSup.Location = new System.Drawing.Point(41, 351);
            this.btnAdmSup.Name = "btnAdmSup";
            this.btnAdmSup.Size = new System.Drawing.Size(206, 67);
            this.btnAdmSup.TabIndex = 10;
            this.btnAdmSup.Text = "Supervisores";
            this.btnAdmSup.UseVisualStyleBackColor = true;
            this.btnAdmSup.Click += new System.EventHandler(this.btnAdmSup_Click);
            // 
            // btnAdmSalir
            // 
            this.btnAdmSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmSalir.Location = new System.Drawing.Point(203, 439);
            this.btnAdmSalir.Name = "btnAdmSalir";
            this.btnAdmSalir.Size = new System.Drawing.Size(99, 38);
            this.btnAdmSalir.TabIndex = 11;
            this.btnAdmSalir.Text = "Salir";
            this.btnAdmSalir.UseVisualStyleBackColor = true;
            this.btnAdmSalir.Click += new System.EventHandler(this.btnAdmSalir_Click);
            // 
            // Perfil_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 493);
            this.Controls.Add(this.btnAdmSalir);
            this.Controls.Add(this.btnAdmSup);
            this.Controls.Add(this.btnAdmRep);
            this.Controls.Add(this.btnAdmProd);
            this.Controls.Add(this.btnAdmProv);
            this.Controls.Add(this.btnAdmVend);
            this.Controls.Add(this.label1);
            this.Name = "Perfil_Administrador";
            this.Text = "Perfil_Administrador";
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
        private System.Windows.Forms.Button btnAdmSalir;
    }
}