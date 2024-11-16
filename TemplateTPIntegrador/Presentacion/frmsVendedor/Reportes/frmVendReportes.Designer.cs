namespace Presentacion
{
    partial class frmVendReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendReportes));
            this.panelAdmvend = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.btnReporteVtasVendedor = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTopProdActivos = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelAdmvend.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdmvend
            // 
            this.panelAdmvend.Controls.Add(this.lblTop);
            this.panelAdmvend.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmvend.Location = new System.Drawing.Point(0, 0);
            this.panelAdmvend.Name = "panelAdmvend";
            this.panelAdmvend.Size = new System.Drawing.Size(994, 56);
            this.panelAdmvend.TabIndex = 6;
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(3, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(589, 39);
            this.lblTop.TabIndex = 7;
            this.lblTop.Text = "Panel de Reportes - Emitir Reportes";
            // 
            // btnReporteVtasVendedor
            // 
            this.btnReporteVtasVendedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReporteVtasVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteVtasVendedor.FlatAppearance.BorderSize = 0;
            this.btnReporteVtasVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnReporteVtasVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReporteVtasVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteVtasVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVtasVendedor.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnReporteVtasVendedor.IconColor = System.Drawing.Color.Black;
            this.btnReporteVtasVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporteVtasVendedor.IconSize = 30;
            this.btnReporteVtasVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteVtasVendedor.Location = new System.Drawing.Point(339, 237);
            this.btnReporteVtasVendedor.Name = "btnReporteVtasVendedor";
            this.btnReporteVtasVendedor.Size = new System.Drawing.Size(306, 56);
            this.btnReporteVtasVendedor.TabIndex = 19;
            this.btnReporteVtasVendedor.Text = "Emitir Reporte Ventas por Vendedor";
            this.btnReporteVtasVendedor.UseVisualStyleBackColor = false;
            this.btnReporteVtasVendedor.Click += new System.EventHandler(this.btnReporteVtasVendedor_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblTopProdActivos);
            this.panel3.Controls.Add(this.guna2CirclePictureBox3);
            this.panel3.Location = new System.Drawing.Point(381, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 119);
            this.panel3.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopProdActivos
            // 
            this.lblTopProdActivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopProdActivos.Location = new System.Drawing.Point(73, 26);
            this.lblTopProdActivos.Name = "lblTopProdActivos";
            this.lblTopProdActivos.Size = new System.Drawing.Size(136, 23);
            this.lblTopProdActivos.TabIndex = 12;
            this.lblTopProdActivos.Text = "Productos Activos";
            this.lblTopProdActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(3, 26);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox3.TabIndex = 13;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // frmVendReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnReporteVtasVendedor);
            this.Controls.Add(this.panelAdmvend);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Vendedor Reporte";
            this.Load += new System.EventHandler(this.frmVendReporte_Load);
            this.panelAdmvend.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmvend;
        private System.Windows.Forms.Label lblTop;
        private FontAwesome.Sharp.IconButton btnReporteVtasVendedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTopProdActivos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
    }
}