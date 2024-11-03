namespace Presentacion
{
    partial class frmProductos
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
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelAdmUsersAlta = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.btnEliminarProducto = new FontAwesome.Sharp.IconButton();
            this.btnAgragarProducto = new FontAwesome.Sharp.IconButton();
            this.panelAdmUsersAlta.SuspendLayout();
            this.SuspendLayout();
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
            this.btnVolver.Location = new System.Drawing.Point(49, 471);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 41);
            this.btnVolver.TabIndex = 56;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Teal;
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(18, 535);
            this.panelSide.TabIndex = 59;
            // 
            // panelAdmUsersAlta
            // 
            this.panelAdmUsersAlta.Controls.Add(this.lblTop);
            this.panelAdmUsersAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmUsersAlta.Location = new System.Drawing.Point(18, 0);
            this.panelAdmUsersAlta.Name = "panelAdmUsersAlta";
            this.panelAdmUsersAlta.Size = new System.Drawing.Size(1227, 56);
            this.panelAdmUsersAlta.TabIndex = 60;
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(3, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(591, 39);
            this.lblTop.TabIndex = 7;
            this.lblTop.Text = "Panel de Vendedor - Lista de Productos";
            this.lblTop.Click += new System.EventHandler(this.lblTop_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnEliminarProducto.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarProducto.IconSize = 30;
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(836, 472);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(195, 41);
            this.btnEliminarProducto.TabIndex = 62;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // btnAgragarProducto
            // 
            this.btnAgragarProducto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgragarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgragarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgragarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnAgragarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnAgragarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgragarProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgragarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgragarProducto.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAgragarProducto.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgragarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgragarProducto.IconSize = 30;
            this.btnAgragarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgragarProducto.Location = new System.Drawing.Point(836, 425);
            this.btnAgragarProducto.Name = "btnAgragarProducto";
            this.btnAgragarProducto.Size = new System.Drawing.Size(195, 41);
            this.btnAgragarProducto.TabIndex = 61;
            this.btnAgragarProducto.Text = "Agragar Producto";
            this.btnAgragarProducto.UseVisualStyleBackColor = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 535);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAgragarProducto);
            this.Controls.Add(this.panelAdmUsersAlta);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.panelAdmUsersAlta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelAdmUsersAlta;
        private System.Windows.Forms.Label lblTop;
        private FontAwesome.Sharp.IconButton btnEliminarProducto;
        private FontAwesome.Sharp.IconButton btnAgragarProducto;
    }
}