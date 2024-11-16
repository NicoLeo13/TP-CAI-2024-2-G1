namespace Presentacion
{
    partial class frmMenuReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuReportes));
            this.panelAdmvend = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlStockCritico = new System.Windows.Forms.Panel();
            this.lblProdCriticos = new System.Windows.Forms.Label();
            this.lblTopStockCritico = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnReporteStockCritico = new FontAwesome.Sharp.IconButton();
            this.btnReporteVtasVendedor = new FontAwesome.Sharp.IconButton();
            this.btnReporteProdTopVentas = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVendActivos = new System.Windows.Forms.Label();
            this.lblTopVendActivos = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTopProdActivos = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelAdmvend.SuspendLayout();
            this.pnlStockCritico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
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
            this.lblTop.Text = "Panel de Reportes - Seleccione un Reporte a Emitir";
            // 
            // pnlStockCritico
            // 
            this.pnlStockCritico.Controls.Add(this.lblProdCriticos);
            this.pnlStockCritico.Controls.Add(this.lblTopStockCritico);
            this.pnlStockCritico.Controls.Add(this.guna2CirclePictureBox2);
            this.pnlStockCritico.Location = new System.Drawing.Point(318, 62);
            this.pnlStockCritico.Name = "pnlStockCritico";
            this.pnlStockCritico.Size = new System.Drawing.Size(349, 119);
            this.pnlStockCritico.TabIndex = 8;
            this.pnlStockCritico.Visible = false;
            // 
            // lblProdCriticos
            // 
            this.lblProdCriticos.AutoSize = true;
            this.lblProdCriticos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdCriticos.ForeColor = System.Drawing.Color.DarkRed;
            this.lblProdCriticos.Location = new System.Drawing.Point(172, 49);
            this.lblProdCriticos.Name = "lblProdCriticos";
            this.lblProdCriticos.Size = new System.Drawing.Size(44, 20);
            this.lblProdCriticos.TabIndex = 14;
            this.lblProdCriticos.Text = "Total";
            this.lblProdCriticos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopStockCritico
            // 
            this.lblTopStockCritico.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopStockCritico.Location = new System.Drawing.Point(73, 26);
            this.lblTopStockCritico.Name = "lblTopStockCritico";
            this.lblTopStockCritico.Size = new System.Drawing.Size(252, 23);
            this.lblTopStockCritico.TabIndex = 12;
            this.lblTopStockCritico.Text = "Hay Productos con Stock Critico!";
            this.lblTopStockCritico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(3, 26);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 13;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // btnReporteStockCritico
            // 
            this.btnReporteStockCritico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReporteStockCritico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteStockCritico.FlatAppearance.BorderSize = 0;
            this.btnReporteStockCritico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnReporteStockCritico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReporteStockCritico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteStockCritico.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteStockCritico.IconChar = FontAwesome.Sharp.IconChar.CircleExclamation;
            this.btnReporteStockCritico.IconColor = System.Drawing.Color.Black;
            this.btnReporteStockCritico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporteStockCritico.IconSize = 30;
            this.btnReporteStockCritico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteStockCritico.Location = new System.Drawing.Point(340, 233);
            this.btnReporteStockCritico.Name = "btnReporteStockCritico";
            this.btnReporteStockCritico.Size = new System.Drawing.Size(306, 56);
            this.btnReporteStockCritico.TabIndex = 18;
            this.btnReporteStockCritico.Text = "Emitir Reporte Stock Critico";
            this.btnReporteStockCritico.UseVisualStyleBackColor = false;
            this.btnReporteStockCritico.Click += new System.EventHandler(this.btnReporteStockCritico_Click);
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
            this.btnReporteVtasVendedor.Location = new System.Drawing.Point(340, 335);
            this.btnReporteVtasVendedor.Name = "btnReporteVtasVendedor";
            this.btnReporteVtasVendedor.Size = new System.Drawing.Size(306, 56);
            this.btnReporteVtasVendedor.TabIndex = 19;
            this.btnReporteVtasVendedor.Text = "Emitir Reporte Ventas por Vendedor";
            this.btnReporteVtasVendedor.UseVisualStyleBackColor = false;
            this.btnReporteVtasVendedor.Click += new System.EventHandler(this.btnReporteVtasVendedor_Click);
            // 
            // btnReporteProdTopVentas
            // 
            this.btnReporteProdTopVentas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReporteProdTopVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteProdTopVentas.FlatAppearance.BorderSize = 0;
            this.btnReporteProdTopVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnReporteProdTopVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReporteProdTopVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteProdTopVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteProdTopVentas.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnReporteProdTopVentas.IconColor = System.Drawing.Color.Black;
            this.btnReporteProdTopVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporteProdTopVentas.IconSize = 30;
            this.btnReporteProdTopVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteProdTopVentas.Location = new System.Drawing.Point(340, 438);
            this.btnReporteProdTopVentas.Name = "btnReporteProdTopVentas";
            this.btnReporteProdTopVentas.Size = new System.Drawing.Size(306, 56);
            this.btnReporteProdTopVentas.TabIndex = 20;
            this.btnReporteProdTopVentas.Text = "Emitir Reporte Producto Mas Vendido";
            this.btnReporteProdTopVentas.UseVisualStyleBackColor = false;
            this.btnReporteProdTopVentas.Click += new System.EventHandler(this.btnReporteProdTopVentas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblVendActivos);
            this.panel1.Controls.Add(this.lblTopVendActivos);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 119);
            this.panel1.TabIndex = 21;
            // 
            // lblVendActivos
            // 
            this.lblVendActivos.AutoSize = true;
            this.lblVendActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendActivos.Location = new System.Drawing.Point(119, 49);
            this.lblVendActivos.Name = "lblVendActivos";
            this.lblVendActivos.Size = new System.Drawing.Size(32, 15);
            this.lblVendActivos.TabIndex = 14;
            this.lblVendActivos.Text = "Total";
            this.lblVendActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopVendActivos
            // 
            this.lblTopVendActivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopVendActivos.Location = new System.Drawing.Point(73, 26);
            this.lblTopVendActivos.Name = "lblTopVendActivos";
            this.lblTopVendActivos.Size = new System.Drawing.Size(136, 23);
            this.lblTopVendActivos.TabIndex = 12;
            this.lblTopVendActivos.Text = "Vendedores Activos";
            this.lblTopVendActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 26);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 13;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblTopProdActivos);
            this.panel3.Controls.Add(this.guna2CirclePictureBox3);
            this.panel3.Location = new System.Drawing.Point(762, 62);
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
            // frmMenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReporteProdTopVentas);
            this.Controls.Add(this.btnReporteVtasVendedor);
            this.Controls.Add(this.btnReporteStockCritico);
            this.Controls.Add(this.pnlStockCritico);
            this.Controls.Add(this.panelAdmvend);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.panelAdmvend.ResumeLayout(false);
            this.pnlStockCritico.ResumeLayout(false);
            this.pnlStockCritico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmvend;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel pnlStockCritico;
        private System.Windows.Forms.Label lblProdCriticos;
        private System.Windows.Forms.Label lblTopStockCritico;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private FontAwesome.Sharp.IconButton btnReporteStockCritico;
        private FontAwesome.Sharp.IconButton btnReporteVtasVendedor;
        private FontAwesome.Sharp.IconButton btnReporteProdTopVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVendActivos;
        private System.Windows.Forms.Label lblTopVendActivos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTopProdActivos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
    }
}